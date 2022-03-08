using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SACodeCampExercise
{
  
    [TestClass]
    public class BaseTest
    {
        public IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            var url = new Uri("https://d18u5zoaatmpxx.cloudfront.net/");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net";
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
