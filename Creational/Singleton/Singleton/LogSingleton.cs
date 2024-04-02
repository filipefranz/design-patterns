namespace Singleton
{
    public class LogSingleton
    {
        private static LogSingleton? Instance;
        private LogSingleton()
        {
            
        }

        public static LogSingleton GetInstance
        {
            get 
            {
                if (Instance == null)
                    Instance = new();

                return Instance; 
            }
        }

        public void Write(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
