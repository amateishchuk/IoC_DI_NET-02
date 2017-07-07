using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IoC_DI_NET_02.Domain.Abstract
{
    public abstract class Availabator
    {
        protected ILogger logger;
        public Availabator(ILogger logger)
        {
            this.logger = logger;
        }
        public abstract void CheckAvailability(string address);
    }
}
