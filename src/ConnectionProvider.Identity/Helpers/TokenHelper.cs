using ConnectionProvider.Identity.Model;
using ConnectionProvider.Identity.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Identity.Helpers
{
    public static class TokenHelper
    {
        public static AsisTokenOptions TokenOptions { get; set; }
        public static void TokenHelperConfigure(AsisTokenOptions tokenOptions)
        {
            TokenOptions = tokenOptions;
        }
    }
}
