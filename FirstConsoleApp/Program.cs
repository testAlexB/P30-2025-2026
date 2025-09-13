using System;

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

            for (int index = 0; index < input.Length; index++)
            {
                char symbol = input[index];

                for(int n = 0; n <= 9; ++n)
                {
                    char numberSymbol = Convert.ToChar(n);
                    if(symbol == numberSymbol || symbol == ' ')
                    {
                        isNumber = true;
                    }
                    else
                    {
                        isNumber = false;
                        index = input.Length;
                    }
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
