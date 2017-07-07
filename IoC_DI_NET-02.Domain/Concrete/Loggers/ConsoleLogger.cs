using IoC_DI_NET_02.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace IoC_DI_NET_02.Domain.Concrete.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void WriteResult(IPStatus status, string address)
        {
            Console.WriteLine($"{status} | {address} | {DateTime.Now}");
        }
    }
}
