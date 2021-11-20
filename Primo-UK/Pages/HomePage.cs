using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo_UK.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToURL()
        {
            driver.Navigate().GoToUrl("https://water-coolers.ru/");
        }

        public static void GoToURLMethod()
        {

        }

    }
}
