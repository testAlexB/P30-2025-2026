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

                if(symbol == '0' || symbol == '1'
                     || symbol == '2'
                      || symbol == '3'
                       || symbol == '4'
                        || symbol == '5'
                         || symbol == '6'
                          || symbol == '7'
                           || symbol == '8'
                            || symbol == '9'   
                            || symbol == ' '
                            )
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
