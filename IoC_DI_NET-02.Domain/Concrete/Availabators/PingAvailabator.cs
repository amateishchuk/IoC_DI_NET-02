using IoC_DI_NET_02.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IoC_DI_NET_02.Domain.Concrete.Availabators
{
    public class PingAvailabator : Availabator
    {
        public PingAvailabator(ILogger logger) : base(logger)
        {
        }

        public override void CheckAvailability(string address)
        {
            try
            {
                Ping pinger = new Ping();
                IPStatus result = pinger.Send(address).Status;
                logger.WriteResult(result, address);
            }
            catch (PingException)
            {
                logger.WriteResult(IPStatus.DestinationUnreachable, address);
            }
        }
    }
}
