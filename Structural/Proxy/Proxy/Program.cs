using Proxy;

ConfigurationProxy configurationProxy = new();

configurationProxy.Start();
configurationProxy.SetConfig("key001", "teste");
Console.WriteLine(configurationProxy.GetConfig("key001"));
