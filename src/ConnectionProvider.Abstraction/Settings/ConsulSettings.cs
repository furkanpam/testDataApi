using ConnectionProvider.Abstraction.Attributes;

namespace ConnectionProvider.Abstraction.Settings
{
    [AppSetting("ConsulSettings")]
    public class ConsulSettings : ISettingsBase
    {
        public string Url { get; set; }
        public string ApplicationName { get; set; }
    }
}
