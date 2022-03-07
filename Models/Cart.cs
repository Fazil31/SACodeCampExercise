using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SACodeCampExercise
{
    internal class Cart
    {
        private readonly IWebDriver driver;

        public Cart(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement CartTable => driver.FindElement(By.ClassName("cart"));
        public ReadOnlyCollection<IWebElement> Rows => 
            CartTable.FindElements(By.TagName("tr"));

        public IWebElement Quantity;
        public IWebElement SinglePrice;
        public IWebElement Subtotal;
        public ReadOnlyCollection<IWebElement> RowCells;
        public IWebElement TopRow;

        internal IEnumerable<IWebElement> GetNextRow()
        {
            foreach(IWebElement row in Rows)
            {
                yield return row;
            }
        }

        internal void DetermineCells(IWebElement row)
        {
            RowCells = row.FindElements(By.TagName("td"));
            int i = 0;

            foreach(var cell in RowCells)
            {
                if(cell.Text == "Price")
                {
                    PriceCellLocator = i;
                    break;
                }

                i++;
            }
        }

        internal void SetTopRow(IWebElement row)
        {
            
        }


        internal void GetPriceData()
        {
            foreach(IWebElement row in GetNextRow())
            {
                SetQuantity(row);

            }
        }

        internal void SetQuantity(IWebElement row)
        {
            Quantity = row.FindElement(By.ClassName("qty"));
        }

        internal void SetSinglePrice(IWebElement row)
        {
            RowCells = row.FindElements(By.TagName("td"));
            int i = 0;

            foreach (var cell in RowCells)
            {
                if(cell.Text )

                i++;
            }

            SinglePrice = row.FindElement(By.)
        }

        internal Cart GetSubtotal(IWebElement row)
        {
            throw new NotImplementedException();
        }
    }
}