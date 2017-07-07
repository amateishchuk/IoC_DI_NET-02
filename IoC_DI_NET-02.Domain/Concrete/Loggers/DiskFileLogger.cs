using IoC_DI_NET_02.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.IO;

namespace IoC_DI_NET_02.Domain.Concrete.Loggers
{
    public class DiskFileLogger : ILogger
    {
        public void WriteResult(IPStatus status, string address)
        {
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                output.WriteLine($"{status} | {address} | {DateTime.Now}");
            }                
        }
    }
}
