using System;
using System.Collections.Generic;

namespace FirstClassApp
{
    class Program
    {
        static void Main()
        {
            HomoSapiens dima = new HomoSapiens(); /// первый человек разумный в системе, идентифицируется как dima
            dima.SetName("Дима Новорожденный");
            dima.SetAge(1);
            PrintPeople(dima);

            HomoSapiens zhanna = new HomoSapiens();
            zhanna.SetName("Жанна Д'Арк");
            zhanna.SetAge(225);
            PrintPeople(zhanna);

            BirthDay(dima);
            PrintPeople(dima);

            List<HomoSapiens> TorzhokPeoples = new List<HomoSapiens>();
            TorzhokPeoples.Add(dima);
            TorzhokPeoples.Add(zhanna);

            List<HomoSapiens> TverPeoples = new List<HomoSapiens>();
            TverPeoples.Add(new HomoSapiens());

            List<HomoSapiens> TverskiePeoples = new List<HomoSapiens>();
            TverskiePeoples.AddRange(TorzhokPeoples);
            TverskiePeoples.AddRange(TverPeoples);

            Console.WriteLine("Население Тверской области составляет: " + TverskiePeoples.Count + " .чел. разумных");
            Console.WriteLine($"Плотность населения Торжка: {(double)TorzhokPeoples.Count / (double)TverskiePeoples.Count * 100.0}%");
        }

        static void BirthDay(HomoSapiens people)
        {
            int currentAge = people.GetAge();
            people.SetAge(currentAge + 1);
        }

        static void PrintPeople(HomoSapiens people)
        {
            Console.WriteLine(people.GetName() + " " + people.GetAge() + " лет");
        }
    }
}
