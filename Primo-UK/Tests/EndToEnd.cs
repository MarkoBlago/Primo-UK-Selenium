using NUnit.Framework;
using OpenQA.Selenium;
using Primo_UK.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Primo_UK.Tests
{
    public class EndToEnd : Browser
    {

        [Test]
        public static void LoginAndGoThruCheckout()
        {
            HomePage HP = new HomePage(driver);

            HP.GoToURL();

            HP.CustomerIcon_Click();
            HP.EmailField_Fill();
            HP.PasswordField_Fill();
            HP.SubmitButton_Click();

            Thread.Sleep(5000);

        }


    }
}
