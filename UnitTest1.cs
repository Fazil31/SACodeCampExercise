using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SACodeCampExercise
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver? driver;

        [TestMethod]
        public void PlayGroundVerifyPrice()
        {
            UnorderedListOperation Unorderlistoperation = new UnorderedListOperation(driver);
            Unorderlistoperation.ClickOnHeart();
            Assert.IsTrue(driver.FindElement(By.ClassName("popup-message")).Text == "You loved List Item 1");
        }
        
        [TestInitialize()]
        public void Setup() {
             driver = new ChromeDriver(@"C:\Tools\chromedriver98");
             driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/";
             driver.Manage().Window.Maximize();

        }
        [TestCleanup()]
        public void Cleanup()
        {
           // driver.Quit();
        }

    }
}