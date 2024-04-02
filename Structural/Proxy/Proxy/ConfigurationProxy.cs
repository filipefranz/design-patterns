namespace Proxy
{
    public class ConfigurationProxy : IConfiguration
    {

        Configuration configuration = new();

        public string GetConfig(string key)
        {
            return configuration.GetConfig(key);
        }

        public void SetConfig(string key, string value)
        {
            configuration.SetConfig(key, value);
        }

        public void Start()
        {
            configuration.Start();
        }

        void IConfiguration.Update()
        {
            throw new NotImplementedException();
        }
    }
}
