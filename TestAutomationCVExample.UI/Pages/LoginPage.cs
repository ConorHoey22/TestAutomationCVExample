﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCVExample.Core.Interfaces;
using TestAutomationCVExample.UI.WebAbstraction;

namespace TestAutomationCVExample.UI.Pages
{
    public class LoginPage
    {
        IWebDriver _iwebDriver;

        IAtConfiguration _iatConfiguration;

        IWebElement Username => _iwebDriver.FindElement(By.XPath("//input[@id='user-name']"));
        IWebElement Password => _iwebDriver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement Login => _iwebDriver.FindElement(By.XPath("//input[@id='login-button']"));

        public LoginPage(IAtConfiguration iatConfiguration, IDrivers idriver)
        {

            _iatConfiguration = iatConfiguration;

            _iwebDriver = idriver.GetWebDriver();
            _iwebDriver.Manage().Window.Maximize();

        }


        public void LoginWithValidCredentials(string username, string password)
        {

            string url = _iatConfiguration.GetConfiguration("url");

            _iwebDriver.Navigate().GoToUrl(url);

            Username.SendKeys(username);
            Password.SendKeys(password);
            Login.Click();

        }



        public void LoginWithInvalidCredentials(string username, string password)
        {
            string url = _iatConfiguration.GetConfiguration("url");


            _iwebDriver.Navigate().GoToUrl(url);


            Username.SendKeys(username);
            Password.SendKeys(password);
            Login.Click();

        }
    }
}
