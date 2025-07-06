using Microsoft.Extensions.DependencyInjection;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCVExample.Core.DIContainerConfig;
using TestAutomationCVExample.Core.Interfaces;

namespace TestAutomationCVExample.Core.Runner
{
    [Binding]
    public class BBD_Runner
    { 

            //declare method
            public static IServiceProvider _iserviceProvider;


            [BeforeTestRun]
            public static void BeforeTestRun()
            {

                //Call the Container Config 
                _iserviceProvider = CoreContainerConfig.ContainerServices();
                _iserviceProvider.GetRequiredService<IGlobalProperties>();
            }

            [BeforeFeature]
            public static void BeforeFeature(FeatureContext fc)
            {
                IExtentReport iextentReport = _iserviceProvider.GetRequiredService<IExtentReport>();
                iextentReport.CreateFeature(fc.FeatureInfo.Title);
                fc["iextentreport"] = iextentReport;
            }


        
    }
}
