using AngleSharp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationCVExample.Core.Interfaces;
using TestAutomationCVExample.Core.Runner;
using TestAutomationCVExample.UI.WebAbstraction;

namespace TestAutomationCVExample.UI.Configuration
{ 

        public class AtConfiguration : IAtConfiguration
        {

            Microsoft.Extensions.Configuration.IConfiguration _builder;
            public AtConfiguration()
            {

                IDefaultVariables idefaultVariables = BBD_Runner._iserviceProvider.GetRequiredService<IDefaultVariables>();

                _builder = new ConfigurationBuilder().AddJsonFile(idefaultVariables.getApplicationSettings).Build();

            }

            public string GetConfiguration(string key)
            {
                return _builder[key];
            }


        }

    
}
