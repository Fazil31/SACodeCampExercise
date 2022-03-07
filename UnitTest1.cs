using System;
using System.Collections.Generic;
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
        private string webPlaygroundUri = "https://d18u5zoaatmpxx.cloudfront.net/#/";

        [TestMethod]
        public void TestUnorderedListFavouriteButtons()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(webPlaygroundUri);

            IWebElement unorderedListElement = driver.FindElement(By.XPath(".//div[contains(@class,'flexcard') and .//h3[.='Unordered List']]"));

            ReadOnlyCollection<IWebElement> listItemElements = unorderedListElement.FindElements(By.CssSelector("li"));

            foreach (IWebElement listElement in listItemElements)
            {
                listElement.FindElement(By.CssSelector("i")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(d => d.FindElement(By.CssSelector(".popup-message")).Displayed);

                string actualMessage = driver.FindElement(By.CssSelector(".popup-message")).Text;
                string expectedMessage = "You loved " + listElement.FindElement(By.ClassName("list-title")).Text;
                
                Assert.AreEqual(expected: expectedMessage, actual: actualMessage);
            }
        }
    }
}