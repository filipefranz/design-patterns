namespace Adapter.Libs
{
    public class Mp3Player
    {
        private string File = "";

        public Mp3Player() { }

        public Mp3Player(string file) => this.File = file;

        public void Run()
        {
            Console.WriteLine($"Running file mp3: {File}");
        }
    }
}
