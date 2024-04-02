using Adapter.Adapters;
using Adapter.Libs;

Console.WriteLine("Enter the media file you want to play");
string? file = Console.ReadLine();

var file_parte = file.Split("."); //file://music.mp3

IPlayer player;

switch (file_parte[1])
{
    case "mp3":
        player = new Mp3PlayerAdapter();
        player.Play(file);
        break;
    case "mp4":
        player = new Mp4PlayerAdapter();
        player.Play(file);
        break;
    default:
        Console.WriteLine("Incompatible media file");
        break;
}
