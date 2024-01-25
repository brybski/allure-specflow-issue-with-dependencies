using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Examples.Allure.SpecFlow.Test
{
    [Binding]
    internal class DependenciesHooks
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateServices()
        {
            return new ServiceCollection();
        }
    }
}
