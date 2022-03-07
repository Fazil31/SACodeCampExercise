using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SACodeCampExercise
{
    [TestClass]
    public class WebPlayground_VerifySubtotal
    {
        private IWebDriver driver;
        BaseTestClass manager = new();

        [TestInitialize]
        public void Setup()
        {
            driver = manager.ConfigDriver(driver);
        }

        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestCleanup]
        public void Cleaner()
        {
            manager.Cleanup(driver);
        }

    }
}