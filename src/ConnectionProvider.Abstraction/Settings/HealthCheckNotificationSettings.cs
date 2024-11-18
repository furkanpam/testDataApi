using ConnectionProvider.Abstraction.Attributes;

namespace ConnectionProvider.Abstraction.Settings
{
    [AppSetting("HealthCheckNotificationSettings")]
    public class HealthCheckNotificationSettings : ISettingsBase
    {
        public List<HealthCheckDetailSettings> HealthChecksSettings { get; set; }
    }
}
