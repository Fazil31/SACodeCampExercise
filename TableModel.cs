using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SACodeCampExercise
{
    class TableModel
    {
        private IWebElement tableElement;
       
        public TableModel(IWebElement tElement)
        {
            tableElement = tElement;
        }

        public IWebElement body => tableElement.FindElement(By.TagName("tbody"));
        private IWebElement footer => tableElement.FindElement(By.TagName("tfoot"));
       
        public double GetTotal()
        {
            return TableUtil.ParseToDoubleValue(footer.FindElement(By.ClassName("cart-total")).Text);
        }

        public void ChangeQuantity(int qty,int rowNumber)
        {
            TableRow row = GetTableRow(rowNumber);
            row.quantity.FindElement(By.TagName("input")).SendKeys(qty.ToString());
           

        }

        public TableRow GetTableRow(int i)
        {
            return new TableRow(body.FindElements(By.TagName("tr"))[i]);
        }

        
       
    }
}
