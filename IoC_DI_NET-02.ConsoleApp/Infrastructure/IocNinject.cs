using IoC_DI_NET_02.Domain.Abstract;
using IoC_DI_NET_02.Domain.Concrete.Availabators;
using IoC_DI_NET_02.Domain.Concrete.Loggers;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_DI_NET_02.Infrastructure
{
    class IocNinject
    {
        private static Lazy<IKernel> _kernel = new Lazy<IKernel>(() => new StandardKernel());

        private static IKernel Kernel
        {
            get { return _kernel.Value; }
        }

        public static object Get(Type objectType)
        {
            return Kernel.Get(objectType);
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
        public static void AddBindings()
        {
            Kernel.Bind<ILogger>().To<CombineLogger>();
            Kernel.Bind<Availabator>().To<PingAvailabator>();
        }
    }
}
