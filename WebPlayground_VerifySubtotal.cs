using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SACodeCampExercise
{
    [TestClass]
    public class WebPlayground_VerifySubtotal
    {
        IWebDriver driver;
        BaseTestClass manager = new(driver);

        [TestInitialize]
        public void Setup()
        {
            manager.ConfigDriver(driver);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestCleanup]
        public void Cleaner()
        {
            manager.Cleanup();
        }

    }
}