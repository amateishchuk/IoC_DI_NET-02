using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IoC_DI_NET_02.Domain.Abstract
{
    public interface ILogger
    {
        void WriteResult(IPStatus status, string address);
    }
}
