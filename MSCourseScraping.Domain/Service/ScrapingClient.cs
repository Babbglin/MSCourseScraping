using HtmlAgilityPack;
using MSCourseScraping.Domain.Interface;

namespace MSCourseScraping.Domain.Service
{
    public abstract class ScrapingClient : IScrapingClient
    {
        public abstract string Xpath { get; }
        public abstract string ScrapingUrl { get; }

        public string GetCourseNameById(string id)
        {
            var htmlWeb = new HtmlWeb();
            var webClient = htmlWeb.Load(ScrapingUrl + id);
            return webClient.DocumentNode.SelectSingleNode(Xpath).InnerText;
        }
    }
}
