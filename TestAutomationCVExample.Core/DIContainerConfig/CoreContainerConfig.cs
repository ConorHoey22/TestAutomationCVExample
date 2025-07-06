using Microsoft.Extensions.DependencyInjection;
using Reqnroll.BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCVExample.Core.DriverContext;
using TestAutomationCVExample.Core.Interfaces;
using TestAutomationCVExample.Core.LocalWebDrivers;
using TestAutomationCVExample.Core.Params;
using TestAutomationCVExample.Core.Reports;

namespace TestAutomationCVExample.Core.DIContainerConfig
{
        public class CoreContainerConfig
        {

            public static IServiceProvider ContainerServices()
            {

                //declare object service collection 
                IServiceCollection services = new ServiceCollection();


                //creating a service to request the object  <interface , Class  >
                services.AddSingleton<IDefaultVariables, DefaultVariables>();
                services.AddSingleton<ILogging, Logging>();
                services.AddSingleton<IExtentFeatureReport, ExtentFeatureReport>();
                services.AddTransient<IExtentReport, ExtentReport>(); // allows Unique reports per feature / multiple
                services.AddSingleton<IGlobalProperties, GlobalProperties>();



                // Build container
                return services.BuildServiceProvider();
            }


            public static IObjectContainer SetContainer(IObjectContainer iobjectContainer)
            {
                iobjectContainer.RegisterTypeAs<ChromeWebDriver, IChromeWebDriver>();
                iobjectContainer.RegisterTypeAs<FirefoxWebDriver, IFirefoxWebDriver>();
                iobjectContainer.RegisterTypeAs<Drivers, IDrivers>();
                return iobjectContainer;
            }

        }
    }
