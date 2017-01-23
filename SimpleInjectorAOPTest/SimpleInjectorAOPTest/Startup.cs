using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using SimpleInjectorAOPTest.App_Start;

[assembly: OwinStartup(typeof(SimpleInjectorAOPTest.Startup))]

namespace SimpleInjectorAOPTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();
            InjectionConfig.SetupInjections(httpConfiguration, app);
            ConfigureAuth(app);
            
        }
    }
}
