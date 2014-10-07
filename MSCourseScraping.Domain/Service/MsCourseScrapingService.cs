
namespace MSCourseScraping.Domain.Service
{
    public class MsCourseScrapingService : ScrapingClient
    {
        public override string Xpath
        {
            get { return "id('ctl00_msl2LASOCourseID0EAAABA_headingCourseTitle')"; }
        }

        public override string ScrapingUrl
        {
            get { return @"https://www.microsoft.com/learning/en-us/course.aspx?id="; }
        }
    }
}
