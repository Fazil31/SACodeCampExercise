using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACodeCampExercise
{
    class BaseTestClass
    {
        public IWebDriver ConfigDriver(IWebDriver driver)
        {
            IWebDriver configDriver = driver;
            configDriver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/";
            configDriver.Manage().Window.Maximize();
            configDriver.Manage().Cookies.DeleteAllCookies();

            return configDriver;
        }

        public void Cleanup(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
