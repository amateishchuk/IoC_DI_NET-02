using IoC_DI_NET_02.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace IoC_DI_NET_02.Domain.Concrete.Loggers
{
    public class JsonLogger : ILogger
    {
        public void WriteResult(IPStatus status, string address)
        {
            using (StreamWriter output = new StreamWriter("output.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                var info = new
                {
                    Status = status,
                    Address = address,
                    DateTime = DateTime.Now
                };
                serializer.Serialize(output, info);
            }
        }
    }
}
