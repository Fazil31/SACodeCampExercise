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
        public IWebElement CartTable => 
            driver.FindElement(By.ClassName("cart"));

        public IWebElement TableHead => 
            CartTable.FindElement(By.TagName("thead"));

        public IWebElement TableBody => 
            CartTable.FindElement(By.TagName("tbody"));

        public ReadOnlyCollection<IWebElement> BodyRows => 
            TableBody.FindElements(By.TagName("tr"));

        public ReadOnlyCollection<IWebElement> Cells;

        public IWebElement Quantity;
        public IWebElement SinglePrice;
        public IWebElement Subtotal;

        public string QuantityAmount = "";
        public int PriceColIndx = -1;
        public int SubtotalColIndx = -1;

        internal IEnumerable<IWebElement> GetNextRow()
        {
            foreach(IWebElement row in BodyRows)
            {
                yield return row;
            }
        }

        internal void DetermineCells()
        {
            Cells = TableHead.FindElements(By.TagName("th"));
            int i = 0;

            foreach(var cell in Cells)
            {
                if(cell.Text == "Price")
                {
                    PriceColIndx = i; 
                }
                if(cell.Text == "Subtotal")
                {
                    SubtotalColIndx = i;
                }

                i++;
            }
        }

        internal float GetPriceData(string defQuantity)
        {
            DetermineCells();

            foreach(IWebElement row in GetNextRow())
            {
                SetQuantity(row, defQuantity);
                SetSinglePrice(row);
                SetSubtotal(row);
                //Console.WriteLine($"Pre-Santize:: Quantity: {QuantityAmount}\nSinglePrice: {SinglePrice.Text}\nSubtotal: {Subtotal.Text}\n=============");

                return GetExpectedSubtotal();
            }
            throw new NotFoundException("No more rows.");
        }

        internal void SetQuantity(IWebElement row, string definedQuantity)
        {
            Quantity = row.FindElement(By.ClassName("qty"));
            Quantity.SendKeys(Keys.Backspace+definedQuantity);
            QuantityAmount = Quantity.GetAttribute("value");
        }

        internal void SetSinglePrice(IWebElement row)
        {
            Cells = row.FindElements(By.TagName("td"));
            SinglePrice = Cells[PriceColIndx];
        }

        internal void SetSubtotal(IWebElement row)
        {
            Cells = row.FindElements(By.TagName("td"));
            Subtotal = Cells[SubtotalColIndx];
        }

        public float GetExpectedSubtotal()
        {
            int numQuantity = int.Parse(QuantityAmount.Trim());
            float numSinglePrice = float.Parse(SinglePrice.Text.Trim().Remove(0,1));
            float numSubtotal = numQuantity * numSinglePrice;

            //Console.WriteLine($"Santized:: Quantity: {numQuantity}\nSinglePrice: {numSinglePrice}\nSubtotal: {numSubtotal}\n=============");

            return numSubtotal;
        }

        public float GetActualSubtotal()
        {
            return float.Parse(Subtotal.Text.Trim());
        }

    }
}