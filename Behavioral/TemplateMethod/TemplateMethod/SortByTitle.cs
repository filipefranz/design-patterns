namespace TemplateMethod
{
    public class SortByTitle : SortTemplate
    {
        public override bool IsFirst(Movie movie1, Movie movie2)
        {
            if (movie1.Title.CompareTo(movie2.Title) <= 0)
                return true;

            return false;
        }
    }
}
