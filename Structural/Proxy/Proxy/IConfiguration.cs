namespace Proxy
{
    public interface IConfiguration
    {
        void Start();
        void Update();
        void SetConfig(string key, string value);
        string GetConfig(string key);
    }
}
