using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VietbankWebsite.Service;

namespace VietbankWebsite.HostedService
{
    public class TimedHostedService : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<TimedHostedService> _logger;
        private readonly IHomeService _homeService;
        private Timer _timer;
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(TimedHostedService));
        public TimedHostedService(ILogger<TimedHostedService> logger, IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            log.Info("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }
        private void DoWork(object state)
        {
            executionCount++;
            var vbMap = _homeService.GetVbMapUrl().Result;
            log.Info($"{vbMap.Count()} - Timed Hosted Service is working. Count: {_homeService.GetFormatSiteMap().Count()}");
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            log.Info("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
