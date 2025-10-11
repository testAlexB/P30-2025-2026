using System.Collections.Generic;

namespace ConsoleApp1
{
    public class SearchingModule
    {
        static public int FindIndexGenre(string userQuery, string[] genres)
        {
            for(int index = 0; index < genres.Length; ++index)
            {
                string valueGenre = genres[index].ToLower();
                if(valueGenre == userQuery.ToLower())
                {
                    return index;
                }
            }

            return -1;
        }

        static public (List<string>, List<int>) FindAllBooksByCenre(int indexGenre, 
                                                             List<string>[] allBooks,
                                                             List<int>[] counts)
        {
            List<string> booksByGenre = new List<string>();
            List<int> countsByGenre = new List<int>();

            booksByGenre = allBooks[indexGenre];
            countsByGenre = counts[indexGenre];

            return (booksByGenre, countsByGenre);
        }
    }
}
