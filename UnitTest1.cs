using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SACodeCampExercise.model;

namespace SACodeCampExercise
{
    [TestClass]
    public class UnitTest1 : BaseTestSuite
    {
        
        [TestMethod]
        public void TestUnorderedListFavouriteButtons()
        {
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

        [TestMethod]
        public void TestTables()
        {
            Table table = new Table(driver);

            ReadOnlyCollection<IWebElement> rows = table.GetRows();

            foreach (IWebElement row in rows)
            {
                int qty = int.Parse(row.FindElement(By.CssSelector("[type='number']")).GetAttribute("value"));
                //double price = double.Parse(row.FindElements(By.CssSelector("td"))[2].Text.Replace("$",""));
                //double subtotal = double.Parse(row.FindElements(By.CssSelector("td"))[3].Text);

                double price = double.Parse(row.FindElements(By.CssSelector("td"))[table.GetColumnIndex("Price")].Text.Replace("$",""));
                double subtotal = double.Parse(row.FindElements(By.CssSelector("td"))[table.GetColumnIndex("Subtotal")].Text);

                Assert.AreEqual(subtotal, qty * price);
            }
        }
    }
}