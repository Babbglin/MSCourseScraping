using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSCourseScraping.Domain.Factory;
using MSCourseScraping.Domain.Service;

namespace MSCourseScraping.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string id = "20486B";
            const string expected = "Developing ASP.NET MVC 4 Web Applications";
            var client = ScrapingFactory.CreateScreenScraper();
            var result = client.GetCourseNameById(id);
            Assert.AreEqual(expected, result);
        }
    }
}
