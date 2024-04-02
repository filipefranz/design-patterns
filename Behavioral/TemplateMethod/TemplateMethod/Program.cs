using TemplateMethod;

Movie movie1 = new(1, "Titanic", 1997, 4.9);
Movie movie2 = new(2, "Click", 2006, 4.7);
Movie movie3 = new(3, "Cast Away", 2000, 4.8);
Movie movie4 = new(4, "Unbroken", 2014, 5);
Movie movie5 = new(5, "Bloodsport", 1988, 4.6);

List<Movie> lista = new()
{
    movie1,
    movie2,
    movie3,
    movie4,
    movie5
};

SortTemplate sort;

sort = new SortByRating();
var list = sort.SortMovie(lista);

foreach (var item in list)
{
    Console.WriteLine(item.Id + " - " + item.Title + " (" + item.Year + ") => " + item.Rating);
}