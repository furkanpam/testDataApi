using ConnectionProvider.Abstraction.Attributes;
using ConnectionProvider.Abstraction.Enums;

namespace ConnectionProvider.Abstraction.Settings
{
    [AppSetting("Databases:MainDb")]
    public class DatabaseSettings : ISettingsBase
    {
        public string DbKey { get; set; }
        public DatabaseType DatabaseType { get; set; }
        public string ConnectionString { get; set; }
    }
}
