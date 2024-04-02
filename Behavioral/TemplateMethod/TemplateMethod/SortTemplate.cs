namespace TemplateMethod
{
    public abstract class SortTemplate
    {
        public abstract bool IsFirst(Movie movie1, Movie movie2);

        //Method Bubble Sort => O(N^2)
        public List<Movie> SortMovie(List<Movie> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (!IsFirst(list[i], list[j]))
                    {
                        Movie temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }

            return list;
        }
    }
}
