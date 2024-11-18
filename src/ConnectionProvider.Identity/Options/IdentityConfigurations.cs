using ConnectionProvider.Abstraction.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Identity.Options
{
    public class IdentityConfigurations
    {
        public DatabaseType DatabaseType { get; set; }
        public string ConnectionString { get; set; }
        public AsisTokenOptions TokenOptions { get; set; }
    }
}
