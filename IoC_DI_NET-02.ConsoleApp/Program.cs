using IoC_DI_NET_02.Domain.Abstract;
using IoC_DI_NET_02.Domain.Concrete.Availabators;
using IoC_DI_NET_02.Domain.Concrete.Loggers;
using IoC_DI_NET_02.Infrastructure;
using Ninject;
using System;

namespace IoC_DI_NET_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKernel kernel = new StandardKernel(new InitializerNinjectModule());
            //var logger = kernel.Get<ILogger>();
            //var availabator = kernel.Get<Availabator>();

            IocNinject.AddBindings();

            var logger = IocNinject.Get<ILogger>();
            var availabator = IocNinject.Get<Availabator>();

            string uri = "dou.ua";
            
            availabator.CheckAvailability(uri);
        }
    }
}
