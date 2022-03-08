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
            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ReadOnlyCollection<IWebElement> Lists = driver.FindElements(By.TagName("ul"));
            foreach (var item in Lists)
            {
                item.FindElement(By.ClassName("list-list")).Click();
                break;     
            }
            
        }
        [TestInitialize()]
        public void Setup() {
             driver = new ChromeDriver(@"C:\Tools\chromedriver98");
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/";
        }
        [TestCleanup()]
        public void Cleanup()
        {
           // driver.Quit();
        }

    }
}