using IoC_DI_NET_02.Domain.Abstract;
using IoC_DI_NET_02.Domain.Concrete.Availabators;
using IoC_DI_NET_02.Domain.Concrete.Loggers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_DI_NET_02.Infrastructure
{
    public class InitializerNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<CombineLogger>();
            Bind<Availabator>().To<PingAvailabator>();
        }
    }
}
