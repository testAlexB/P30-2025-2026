using System;
using System.Linq;

namespace FirstConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Day end!!!");

            Console.WriteLine("Введите чиселку!");
            string input = Console.ReadLine();
            input = input.Trim();

            bool isNumber = true;

            char[] numberSymbols = new char[11] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ' };
           //bool isG = numberSymbols.Contains('g'); /// определяет, находится ли символ g в массиве numberSymbols

            for (int index = 0; index < input.Length; index++)
            {
                char symbol = input[index];
                    if(numberSymbols.Contains(symbol))
                    {
                        isNumber = true;
                    }
                    else
                    {
                        isNumber = false;
                        index = input.Length;
                    }
            }

            if (!isNumber)
            {
                Console.WriteLine("Введите, пожалуйста, число, и не занимайтесь ерундой");
                return;
            }

            input = input.Replace(" ", "");

            int number = Convert.ToInt32(input);
            Console.WriteLine("Число = " + number);
        }
    }
}
