using MSCourseScraping.Domain.Interface;
using MSCourseScraping.Domain.Service;

namespace MSCourseScraping.Domain.Factory
{
    public class ScrapingFactory
    {
        public static IScrapingClient CreateScreenScraper()
        {
            return new MsCourseScrapingService();
        }
    }
}
