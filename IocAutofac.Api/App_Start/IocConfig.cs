namespace IocAutofac.Api.App_Start
{
    using Autofac;
    using Autofac.Integration.WebApi;
    using IocAutofac.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Web;
    using System.Web.Http;

    public class IocConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<TestService>().AsSelf().InstancePerRequest();
            builder.RegisterType<IocAutofac.Models.Class1>().As<IocAutofac.Models.IClass1>();
            var container = builder.Build();
            var resover = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resover;
        }
    }
}