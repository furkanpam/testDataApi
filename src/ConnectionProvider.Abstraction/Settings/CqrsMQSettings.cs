using ConnectionProvider.Abstraction.Attributes;

namespace ConnectionProvider.Abstraction.Settings
{
    [AppSetting("CqrsMQSettings")]
    public class CqrsMQSettings : ISettingsBase
    {
        public string HostName { get; set; }
        public int QPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string QueueName { get; set; }
        public bool Durable { get; set; }
        public bool Exclusive { get; set; }
        public bool AutoDelete { get; set; }
    }
}
