using Facade;

ScoreClientFacade score = new();

var Score = score.Score("07078585285", "4654645655");

Console.WriteLine("The Score of client is: " + Score);