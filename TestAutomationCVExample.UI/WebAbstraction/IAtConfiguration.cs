using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationCVExample.UI.WebAbstraction
{
    public interface IAtConfiguration
    {
        string GetConfiguration(string key);
    }
}
