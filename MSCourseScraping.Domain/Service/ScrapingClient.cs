using HtmlAgilityPack;
using MSCourseScraping.Domain.Interface;

namespace MSCourseScraping.Domain.Service
{
    public class ScrapingClient : IScrapingClient
    {
        public string Xpath { get; set; }
        public string ScrapingUrl { get; set; }

        public string GetCourseNameById(string id)
        {
            var htmlWeb = new HtmlWeb();
            var webClient = htmlWeb.Load(ScrapingUrl + id);
            return webClient.DocumentNode.SelectSingleNode(Xpath).InnerText;
        }
    }
}
