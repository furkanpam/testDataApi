using ConnectionProvider.Abstraction.Enums;
using Hangfire.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Abstraction.Attributes
{
    public class WorkerAttribute : Attribute
    {
        public Workers Worker { get; set; }
        public WorkerAttribute(Workers worker)
        {
            Worker = worker;
        }
    }
}
