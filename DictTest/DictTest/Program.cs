using DictTest;
using System;
using System.Collections.Generic;

namespace DictTest
{
    enum Genre
    {
        Drama,
        Tragic,
        Comedy,
        Unknown
    }

    class Program
    {

    static private void RemoveBook(Dictionary<Genre, List<string>> allBooks,
                                   string bookName)
    {

    }

    static private Genre MakeGenreByText(string text)
    {
        if (text == "драма")
        {
            return Genre.Drama;
        }

        if (text == "комедия")
        {
            return Genre.Comedy;
        }

        if (text == "трагедия")
        {
            return Genre.Tragic;
        }

        return Genre.Unknown;
    }

        static void Main()
        {
            /// создали пустой словарь,
            /// где ключом выступает тип перечисления Genre,
            /// а значение список строковых значений (список названий книг)
            Dictionary<Genre, List<string>> catalogBooks =
                new Dictionary<Genre, List<string>>();

            /// заполнили книги жанра комедии
            catalogBooks.Add(Genre.Comedy,
                             new List<string>() { "Горе от ума",
                                                  "Вечера на хуторе близ Диканьки",
                                                  "Ревизор",
                                                  "Ум от горя"});

            /// заполнили книги жанра трагедии
            catalogBooks.Add(Genre.Tragic,
                 new List<string>() { "Сегодня суббота",
                                      "Трагедия понедельника"});

            Console.Write("Какой жанр литературы Вам интересен? ");
            string text = Console.ReadLine();
            Genre genre = MakeGenreByText(text);

            if(genre == Genre.Unknown)
            {
                Console.WriteLine("Ай я-яй, нужна либо драма, либо трагедия, либо комедия");
                return;
            }

            if(catalogBooks.ContainsKey(genre))
            {
                List<string> books = catalogBooks[genre];
                Console.WriteLine(String.Join("\n", books));
            }
            else
            {
                Console.WriteLine("Книг данного жанра мы еще не завезли");
            }

        }
    }
}
