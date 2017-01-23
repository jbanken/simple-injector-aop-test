using Owin;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using SimpleInjectorAOPTest.DataProviders;
using SimpleInjectorAOPTest.DataProviders.Interfaces;
using SimpleInjectorAOPTest.Services;
using SimpleInjectorAOPTest.Services.Interfaces;

namespace SimpleInjectorAOPTest.App_Start
{
    public static class InjectionConfig
    {
        public static Container SetupInjections(HttpConfiguration config, IAppBuilder app)
        {
            var container = new Container();
            container.Options.AllowOverridingRegistrations = true;
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.Register<IUserDataProvider, UserDataProvider>(Lifestyle.Singleton);
            container.Register<IUserService, UserService>(Lifestyle.Singleton);
            container.RegisterDecorator<IUserService, Services.Decorators.UserService>();

            container.RegisterWebApiControllers(config);
            container.Verify();

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            return container;
        }
    }
}