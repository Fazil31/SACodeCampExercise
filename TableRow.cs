using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SACodeCampExercise
{
    class TableRow
    {
        private IWebElement row;

        public TableRow(IWebElement ele)
        {
            row = ele;
        }

        public IWebElement quantity => GetRowCell(0);

        public IWebElement item => GetRowCell(1);

        public IWebElement price => GetRowCell(2);

        public IWebElement subTotal => GetRowCell(3);

        private IWebElement GetRowCell(int index)
        {
            return row.FindElements(By.TagName("td"))[index];
        }

       
        
    }
}
