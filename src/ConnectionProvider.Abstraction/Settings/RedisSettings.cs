using ConnectionProvider.Abstraction.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Abstraction.Settings
{
    [AppSetting("RedisCache")]
    public class RedisSettings : ISettingsBase
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Timeout { get; set; }
    }
}
