using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Print(List<string> books)
        {
            Console.WriteLine(String.Join(", ", books));
        }

        static void Main()
        {
            string[] genres = new string[] { "Драма", "Трагедия", "Комедия" };
            var (books, counts) = InputModule.InputBooksByCenre();

            string userQuery = InputModule.InputUserQuery();

            int indexGenre = SearchingModule.FindIndexGenre(userQuery, genres);
            if(indexGenre < 0)
            {
                Console.WriteLine("Указан несуществующий жанр");
                return;
            }

            var (booksUserGenre, countsUserGenre) = SearchingModule.FindAllBooksByCenre(indexGenre, books, counts);

            AnalysisDataModule.SortBooks(booksUserGenre, countsUserGenre);
            Print(booksUserGenre);
        }
    }
}
