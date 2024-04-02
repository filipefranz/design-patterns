namespace TemplateMethod
{
    public class SortByRating : SortTemplate
    {
        public override bool IsFirst(Movie movie1, Movie movie2)
        {
            if (movie1.Rating > movie2.Rating)
                return true;

            return false;
        }
    }
}
