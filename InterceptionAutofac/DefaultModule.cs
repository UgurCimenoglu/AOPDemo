using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptionAutofac
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //var proxyOptions = new ProxyGenerationOptions
            //{
            //    Selector = new AspectInterceptorSelector()
            //};
            //builder.RegisterType<EmployeeManager>().As<IEmployeeService>()
            //    .EnableInterfaceInterceptors(proxyOptions)
            //    .SingleInstance();



            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();

            //Interceptoru assembly seviyesinde entegre ediyoruz.
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
