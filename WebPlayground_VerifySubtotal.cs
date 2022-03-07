using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SACodeCampExercise
{
    [TestCategory("CartTests")]
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
            Cart Row = GetNextRow();
            Cart Quantity = GetQuantity();
            Cart SinglePrice = GetPrice();
            Cart Subtotal = GetSubtotal();
               
        }

        [TestCleanup]
        public void Cleaner()
        {
            manager.Cleanup(driver);
        }

    }
}