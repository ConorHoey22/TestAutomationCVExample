﻿using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCVExample.Core.Interfaces;
using TestAutomationCVExample.Core.Runner;
using WebDriverManager.DriverConfigs.Impl;

namespace TestAutomationCVExample.Core.LocalWebDrivers
{
    public class ChromeWebDriver : IChromeWebDriver
    {
        IGlobalProperties _iglobalProperties;


        public ChromeWebDriver()
        {


            _iglobalProperties = BBD_Runner._iserviceProvider.GetRequiredService<IGlobalProperties>();

        }

        public IWebDriver GetChromeWebdriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver webDriver = new ChromeDriver(GetOptions());
            webDriver.Manage().Window.Maximize();
            return webDriver;

        }

        public IWebDriver GetChromeWebDriver()
        {
            throw new NotImplementedException();
        }

        public ChromeOptions GetOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AcceptInsecureCertificates = true;
            // Enable automation flag (this suppresses the "Chrome is being controlled by automated software" banner)
            options.AddArgument("--enable-automation");

            // Disable info bars (prevents the info bar that says "Chrome is being controlled by automated software")
            options.AddArgument("--disable-infobars");

            // Disable notifications (prevents pop-up notifications in the browser)
            options.AddArgument("--disable-notifications");

            // Disable web security (used for cross-origin resource sharing)
            options.AddArgument("--disable-web-security");

            // Disable side navigation (prevents Chrome's side navigation from showing in certain pages)
            options.AddArgument("--disable-side-navigation");

            // Disable GPU hardware acceleration
            options.AddArgument("--disable-gpu");

            // Always authorize plugins (disables plugin prompts and automatically runs plugins)
            options.AddArgument("--always-authorize-plugins");

            // Disable extensions (prevents Chrome extensions from being loaded)
            options.AddArgument("--disable-extensions");

            // Run in headless mode (no UI) This will be used when using a CI/CD pipeline
            // options.AddArgument("--headless");         

            // Set user profile preference to set default download location
            options.AddUserProfilePreference("download.default_directory", _iglobalProperties.dataSetLocation);
            return options;

        }

            
    }
}
