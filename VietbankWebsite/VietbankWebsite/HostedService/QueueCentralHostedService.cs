using Experimental.System.Messaging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;
using VietbankWebsite.Entities.Analytic;
using VietbankWebsite.Models;
using VietbankWebsite.Models.Queue;
using VietbankWebsite.Service;

namespace VietbankWebsite.HostedService
{
    public class QueueCentralHostedService : IHostedService, IDisposable
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(TimedHostedService));
        private MessageQueue _qRequestRecieve;
        private readonly MessageQueueConfig _messageQueueConfig;
        private Timer _timer;
        private readonly IRequestLogService _requestLogService;
        public QueueCentralHostedService(IOptions<MessageQueueConfig> messageQueueConfig, IRequestLogService requestLogService)
        {
            _messageQueueConfig = messageQueueConfig.Value;
            _requestLogService = requestLogService;
        }
        public void Dispose()
        {
            _timer?.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            DoWork();
            return Task.CompletedTask;
        }

        private void DoWork()
        {
            try
            {
                RecieveRequestToCountQueue();
            }
            catch (Exception e)
            {

                log.Error($"At QueueCentralHostedService function: {e.ToString()}");
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void RecieveRequestToCountQueue()
        {
            if (MessageQueue.Exists(".\\private$\\" + _messageQueueConfig.QueueCountRequest))
            {
                _qRequestRecieve = new MessageQueue((".\\private$\\" + _messageQueueConfig.QueueCountRequest));
                _qRequestRecieve.Formatter = new XmlMessageFormatter(new Type[] { typeof(CountRequestQueue) });
                _qRequestRecieve.ReceiveCompleted += ReceiveCompleted;
                _qRequestRecieve.BeginReceive();
            }
        }

        private void ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {

            Message mMessage = _qRequestRecieve.EndReceive(e.AsyncResult);
            CountRequestQueue recieve = (CountRequestQueue)mMessage.Body;
            if (!CheckExtension(recieve.UrlRequest))
            {
                try
                {
                    _requestLogService.Create(new RequestLogs()
                    {
                        IpRemote = recieve.IpRequest,
                        UrlRequest = recieve.UrlRequest,
                        Time = int.Parse(recieve.Time.ToString()),
                        Created = DateTime.Now
                    });
                }
                catch (Exception ex)
                {

                    log.Error(ex);
                }
            }
            _qRequestRecieve.BeginReceive();
        }

        private bool CheckExtension(string url)
        {
            string[] planets = { ".css", ".js", ".txt", ".png", ".jpg",".ico" };
            return Array.Exists(planets, element => element == url.Substring(url.Length - 4, 4)) || Array.Exists(planets, element => element == url.Substring(url.Length - 3, 3));
        }

        //private RequestLogs ClassifiedRequest(RequestLogs req)
        //{
        //    Uri url = new Uri(req.UrlRequest);
        //    url.
        //}
    }
}
