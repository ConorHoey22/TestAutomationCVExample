using Reqnroll;
using Microsoft.Azure.WebJobs.Description;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCVExample.Core.Interfaces;
using TestAutomationCVExample.Core.Runner;
using Reqnroll.BoDi;

namespace TestAutomationCVExample.Core.Hooks
{
    [Microsoft.Azure.WebJobs.Description.Binding]
    public class BBD_Base
    {
        IGlobalProperties _iglobalProperties;
        IChromeWebDriver _ichromeWebDriver;
        IFirefoxWebDriver _ifirefoxWebDriver;
        IDrivers _idrivers;
        ScenarioContext _scenarioContext;





        public BBD_Base(IChromeWebDriver _chromeWebDriver, IFirefoxWebDriver _firefoxWebDriver)
        {

            _ichromeWebDriver = _chromeWebDriver;
            _ifirefoxWebDriver = _firefoxWebDriver;


        }



        [BeforeScenario(Order = 2)]
        public void BeforeScenario(IObjectContainer iobjectcontainer, ScenarioContext scenarioContext, FeatureContext fc)
        {

            _idrivers = iobjectcontainer.Resolve<IDrivers>();
            _scenarioContext = scenarioContext;
            IExtentReport extentReport = (IExtentReport)fc["iextentreport"];
            extentReport.CreateScenario(scenarioContext.ScenarioInfo.Title);



        }


        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext, FeatureContext fc)
        {
            IExtentReport extentReport = (IExtentReport)fc["iextentreport"];

            if (scenarioContext.TestError != null)
            {
                string base64 = null;
                base64 = _idrivers.GetScreenshot();

                extentReport.Fail(scenarioContext.StepContext.StepInfo.Text, base64);
            }
            else
            {
                IGlobalProperties iglobalProperties = BBD_Runner._iserviceProvider.GetRequiredService<IGlobalProperties>();
                string base64 = null;
                if (iglobalProperties.stepscreenshot)
                {
                    base64 = _idrivers.GetScreenshot();
                }

                extentReport.Pass(scenarioContext.StepContext.StepInfo.Text, base64);

            }
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext sc, FeatureContext fc)
        {
            IExtentFeatureReport extentReport = BBD_Runner._iserviceProvider.GetRequiredService<IExtentFeatureReport>();
            extentReport.FlushExtent();
            Thread.Sleep(1000);
            _idrivers.CloseBrowser();
        }

    }

}
