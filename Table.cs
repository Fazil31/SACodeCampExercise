using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SACodeCampExercise
{
    class Table
    {
       IWebElement thisElement;
       public  Raw raw;   
        public Table(IWebElement thisElement)
        {
            this.thisElement = thisElement;
        }
    }
}
