using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Abstraction.Settings
{
    public class HealthCheckDetailSettings
    {
        public string Key { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsHtml { get; set; }
        public string HtmlContentPath { get; set; }
    }
}
