using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SACodeCampExercise
{
    internal class UnorderedListOperation
    {
        IWebDriver driver;
        public UnorderedListOperation(IWebDriver? driver)
        {
            this.driver = driver;
        }

    
        internal void ClickOnHeart()
        {
            ReadOnlyCollection<IWebElement> Lists = driver.FindElements(By.TagName("ul"));
            IWebElement unorderList = driver.FindElement(By.TagName("ul"));
            unorderList.FindElement(By.ClassName("list-item-button")).Click();      
        }
    }
}