using IoC_DI_NET_02.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace IoC_DI_NET_02.Domain.Concrete.Loggers
{
    public class CombineLogger : ILogger
    {        
        public void WriteResult(IPStatus status, string address)
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger diskFileLogger = new DiskFileLogger();
            ILogger jsonLogger = new JsonLogger();

            consoleLogger.WriteResult(status, address);
            diskFileLogger.WriteResult(status, address);
            jsonLogger.WriteResult(status, address);
        }
    }
}
