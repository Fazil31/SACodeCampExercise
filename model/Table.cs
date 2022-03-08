using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SACodeCampExercise.model
{
    public class Table
    {
        private IWebElement table;

        public Table(IWebDriver driver)
        {
            table = driver.FindElement(By.CssSelector("table"));
        }

        public ReadOnlyCollection<IWebElement> GetRows()
        {
            return table.FindElements(By.CssSelector("tbody tr"));
        }

        public int GetColumnIndex(string columnName)
        {
            IWebElement headerRow = table.FindElement(By.CssSelector("thead tr"));

            int ctr = 0;
            foreach (IWebElement headerCell in headerRow.FindElements(By.CssSelector("th")))
            {
                if (headerCell.Text==columnName)
                {
                    return ctr;
                }
                ctr++;
            }
            throw new NotFoundException("Did not find column.");
        }
    }
}
