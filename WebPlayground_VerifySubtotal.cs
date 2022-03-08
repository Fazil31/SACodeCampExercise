using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SACodeCampExercise
{
    [TestCategory("CartTests")]
    [TestClass]
    public class WebPlayground_VerifySubtotal
    {
        public ChromeDriver driver = new ChromeDriver();

        [TestInitialize]
        public void Setup()
        {
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/";
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Cart testCart = new(driver);
            string quantity = "6";

            Assert.AreEqual(expected: testCart.GetPriceData(quantity), actual: testCart.GetActualSubtotal());
        }

        [TestCleanup]
        public void Cleaner()
        {
            driver.Quit();
        }

    }
}