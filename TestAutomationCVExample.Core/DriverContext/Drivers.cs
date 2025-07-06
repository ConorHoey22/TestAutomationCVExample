using Microsoft.Azure.WebJobs.Description;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCVExample.Core.Interfaces;
using TestAutomationCVExample.Core.Runner;

namespace TestAutomationCVExample.Core.DriverContext
{

    [Binding]
    public class Drivers : IDrivers
    {
   
            IGlobalProperties _iglobalProperties;
            IChromeWebDriver _ichromeWebDriver;
            IFirefoxWebDriver _ifirefoxWebDriver;
            IWebDriver _iwebDriver;


            public Drivers(IChromeWebDriver ichromeWebDriver, IFirefoxWebDriver ifirefoxWebDriver)
            {
                _ichromeWebDriver = ichromeWebDriver;
                _ifirefoxWebDriver = ifirefoxWebDriver;
            }

            public IWebDriver GetWebDriver()
            {
                if (_iwebDriver == null)
                {
                    GetNewWebDriver();
                }
                return _iwebDriver;

            }

            public void GetNewWebDriver()
            {

                _iglobalProperties = BBD_Runner._iserviceProvider.GetRequiredService<IGlobalProperties>();

                switch (_iglobalProperties.browsertype.ToLower())
                {
                    case "chrome":
                        _iwebDriver = _ichromeWebDriver.GetChromeWebDriver();
                        break;
                    case "firefox":
                        _iwebDriver = _ifirefoxWebDriver.GetFirefoxWebDriver();
                        break;
                    default:
                        _iwebDriver = _ichromeWebDriver.GetChromeWebDriver();
                        break;

                }


            }

            public void CloseBrowser()
            {
                _iwebDriver.Quit();
            }

            public string GetScreenshot()
            {
                return ((ITakesScreenshot)GetWebDriver()).GetScreenshot().AsBase64EncodedString;
            }
    }
    
    
}
