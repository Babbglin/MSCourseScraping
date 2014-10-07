using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSCourseScraping.Domain.Interface;
using MSCourseScraping.Domain.Service;

namespace MSCourseScraping.Domain.Factory
{
    class ScrapingFactory
    {
        public static IScrapingClient CreateScreenScraper(string id)
        {
                return new ScrapingClient();
        }
    }
}
