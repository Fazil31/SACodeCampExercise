using System;
using OpenQA.Selenium;

namespace SACodeCampExercise.models
{
	internal class TablePage : WebPage
	{
		public TablePage(IWebDriver driver)
		{
			this.driver = driver;
		}

		public TablePage(IWebDriver driver, string url)
		{
			this.driver = driver;
			this.driver.Url = url;
		}
	}
}