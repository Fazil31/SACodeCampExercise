using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SACodeCampExercise.models;

namespace SACodeCampExercise
{
    [TestClass]
    public class TableTests
    {
        IWebDriver driver;
        TablePage tablePage;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            tablePage = new(driver, "https://d18u5zoaatmpxx.cloudfront.net/#/");
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
