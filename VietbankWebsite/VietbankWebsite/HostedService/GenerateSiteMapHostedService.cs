using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using VietbankWebsite.Service;

namespace VietbankWebsite.HostedService
{
    public class GenerateSiteMapHostedService : IHostedService, IDisposable
    {
        /// <summary>
        /// Have to permit full controler for user iis_iusrs in file sitemap.xml
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(GenerateSiteMapHostedService));
        private readonly IHomeService _homeService;
        private Timer _timer;
        public GenerateSiteMapHostedService(IHomeService homeService)
        {
            _homeService = homeService;
        }
        public void Dispose()
        {
            _timer?.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            log.Info("Generate Site Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromDays(1));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            log.Info($"Generate sitemap file at: {DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")}");
            createXML();
        }

        public void createXML()
        {
            XmlTextWriter writer = new XmlTextWriter(System.IO.File.Create("wwwroot/sitemap.xml"), System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("urlset");
            writer.WriteAttributeString("xmlns", "https://www.sitemaps.org/schemas/sitemap/0.9");
            writer.WriteAttributeString("xmlns:xsi", "https://www.w3.org/2001/XMLSchema-instance");
            writer.WriteAttributeString("xsi:schemaLocation", "https://www.sitemaps.org/schemas/sitemap/0.9 https://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd");
            foreach (var item in _homeService.GetFormatSiteMap())
            {
                createNode($"https://www.vietbank.com.vn/{item.url}", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"), item.priority, writer);
            }
            writer.WriteEndDocument();
            writer.Close();
        }

        private void createNode(string loc, string lastmod, string priority, XmlTextWriter writer)
        {
            //parent node start
            writer.WriteStartElement("url");

            writer.WriteStartElement("loc");
            writer.WriteString(loc);
            writer.WriteEndElement();

            //Book Price
            writer.WriteStartElement("lastmod");
            writer.WriteString(lastmod);
            writer.WriteEndElement();

            //Book Price
            writer.WriteStartElement("priority");
            writer.WriteString(priority);
            writer.WriteEndElement();

            writer.WriteEndElement();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            log.Info("Generate Site Map Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }
    }
}
