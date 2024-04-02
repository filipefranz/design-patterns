namespace Proxy
{
    public class Configuration : IConfiguration
    {
        public string GetConfig(string key)
        {
            Random rnd = new();
            return $"value of configuration {key} is : {rnd.NextInt64()}";
        }

        public void SetConfig(string key, string value)
        {
            Console.WriteLine($"configurations registered => {key}:{value}");
        }

        public void Start()
        {
            Console.WriteLine("configurations started!");
        }

        public void Update()
        {
            Console.WriteLine("configurations up to date!");
        }
    }
}
