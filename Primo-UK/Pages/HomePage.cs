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


        #region Elements

        public IWebElement CustomerIcon()
        {
            return driver.FindElement(By.XPath("//header/div[2]/div[1]/ul[1]/li[1]/a[1]"));
        }

        private IWebElement EmailField()
        {
            return driver.FindElement(By.Id("ajaxlogin-email"));
        }

        private IWebElement PasswordField()
        {
            return driver.FindElement(By.Id("ajaxlogin-pass"));
        }

        private IWebElement SubmitButton()
        {
            return driver.FindElement(By.Id("ajaxlogin-send"));
        }

        #endregion

        #region Actions


        public void CustomerIcon_Click()
        {
            CustomerIcon().Click();
        }

        public void EmailField_Fill()
        {
            EmailField().SendKeys("mareberko@gmail.com");
        }


        public void PasswordField_Fill()
        {
            PasswordField().SendKeys("123qwe!@#QWE");
        }


        public void SubmitButton_Click()
        {
            SubmitButton().Click();
        }

        public void GoToURL()
        {
            driver.Navigate().GoToUrl("https://water-coolers.ru/");
        }

        #endregion





    }
}
