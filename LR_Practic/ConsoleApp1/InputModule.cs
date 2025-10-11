using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class InputModule
    {
     static public (List<string>[] , List<int>[] ) InputBooksByCenre()
     {
            List<string>[] booksByGenre = new List<string>[3] { new List<string>(),
                                                                new List<string>(),
                                                                new List<string>()
            };
            
            List<int>[] counts = new List<int>[3]{ new List<int>(),
                                                   new List<int>(),
                                                   new List<int>()
            };

            /// Заполняем книжки Драм (нулевой индекс)
            booksByGenre[0].Add("Муму");
            counts[0].Add(10);
            booksByGenre[0].Add("Мама");
            counts[0].Add(5);
            booksByGenre[0].Add("Мими");
            counts[0].Add(1);

            /// Заполняем книжки Трагедия (первый индекс)
            booksByGenre[1].Add("Печаль жизни");
            counts[1].Add(2);
            booksByGenre[1].Add("Желтая осень");
            counts[1].Add(25);

            /// Заполняем книжки Комедия (второй индекс)
            booksByGenre[2].Add("Не ломай комедию");
            counts[2].Add(30);

            return (booksByGenre, counts);
     }

     static public string InputUserQuery()
     {
         Console.Write("Введите, пожалуйста, жанр (трагедия/комедия/драма): ");
         return Console.ReadLine();
     }

    }
}
