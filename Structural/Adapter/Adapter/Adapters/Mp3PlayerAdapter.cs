using Adapter.Libs;

namespace Adapter.Adapters
{
    public class Mp3PlayerAdapter : IPlayer
    {
        public void Play(string file)
        {
            Mp3Player mp3Player = new();
            mp3Player.Run();
        }
    }
}
