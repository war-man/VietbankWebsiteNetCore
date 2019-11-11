using Experimental.System.Messaging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using VietbankWebsite.Models;
using VietbankWebsite.Models.Queue;
using Microsoft.AspNetCore.Http.Extensions;
using System.Diagnostics;

namespace VietbankWebsite.Middleware
{
    public class RequestComputeMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly MessageQueueConfig _messageQueueConfig;
        private MessageQueue _qCountRequest;
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(RequestComputeMiddleware));
        public RequestComputeMiddleware(RequestDelegate next, IOptions<MessageQueueConfig> messageQueueConfig)
        {
            _next = next;
            _messageQueueConfig = messageQueueConfig.Value;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
             httpContext.Response.OnStarting(async () =>
            {
                watch.Stop();
                SendRequestToCountQueue(new CountRequestQueue()
                {
                    IpRequest = httpContext.Connection.RemoteIpAddress.ToString(),
                    UrlRequest = httpContext.Request.GetDisplayUrl(),
                    Time = watch.ElapsedMilliseconds
                });              
            });
            await _next(httpContext);
        }

        public void SendRequestToCountQueue(CountRequestQueue req)
        {
            if (MessageQueue.Exists(".\\private$\\" + _messageQueueConfig.QueueCountRequest))
            {
                _qCountRequest = new MessageQueue(".\\private$\\" + _messageQueueConfig.QueueCountRequest);
                _qCountRequest.Formatter = new XmlMessageFormatter(new Type[] { typeof(CountRequestQueue) });
                Message msgSend = new Message(req);
                _qCountRequest.Send(msgSend);
                _qCountRequest.Close();
            }
            else
            {
                log.Info($"{_messageQueueConfig.QueueCountRequest} queue is not existed!");
            }
        }

    }
}
