using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SACodeCampExercise
{
    [TestClass]
    public class HomePage_TableTests : BaseTest
    {

        [TestMethod]
        public void Tables_VerifySubtotal()
        {
            //Arrange
            TableModel table = new TableModel(driver.FindElement(By.ClassName("cart")));
            int quantity = 5;
            int row = 0;
            //Act
            table.ChangeQuantity(quantity, row);
            Console.WriteLine(table.body.FindElements(By.TagName("tr"))[row].FindElements(By.TagName("td"))[3].Text);
            // Assert
            Assert.AreEqual(699.90, double.Parse(table.GetTableRow(row).subTotal.Text));
        }

       
        

    }
}
