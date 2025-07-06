using Microsoft.Azure.WebJobs.Description;
using Reqnroll;
using Reqnroll.BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCVExample.Core.DIContainerConfig;
using TestAutomationCVExample.UI.Configuration;
using TestAutomationCVExample.UI.WebAbstraction;

namespace TestAutomationCVExample.UI.Container
{
    [Microsoft.Azure.WebJobs.Description.Binding]
    public class ContainerConfig
    {
        [BeforeScenario(Order = 1)]
        public void BeforeScenario(IObjectContainer iobjectContainer)
        {
            iobjectContainer.RegisterTypeAs<AtConfiguration, IAtConfiguration>();
            iobjectContainer = CoreContainerConfig.SetContainer(iobjectContainer);
        }
    }
}
