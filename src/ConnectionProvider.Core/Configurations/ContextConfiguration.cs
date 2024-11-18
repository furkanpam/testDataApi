using ConnectionProvider.Abstraction.Enums;

namespace ConnectionProvider.Core.Configurations
{
    public class ContextConfiguration
    {
        public DatabaseType DatabaseType { get; set; }
        public string ConnectionString { get; set; }
    }
}
