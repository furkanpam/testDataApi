namespace ConnectionProvider.Abstraction.Settings
{
    public class CPHttpClientSettings
    {
        public string? Name { get; set; }
        public string? BaseUrl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SecurityKey { get; set; }
        public int InstitutionId { get; set; }
        public List<CPEndPoint> EndPoints { get; set; }
    }
}
