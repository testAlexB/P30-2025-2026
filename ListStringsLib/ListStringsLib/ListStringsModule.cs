using System;
using System.Collections.Generic;

namespace ListStringsLib
{
    public class ListStringsModule
    {
        static public List<string> InputListStrings()
        {
            List<string> result = new List<string>();

            Console.WriteLine("Введите число строк: ");
            int countStrings = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < countStrings; ++i)
            {
                Console.Write($"Строка {i} = ");
                result.Add(Console.ReadLine());
            }

            return result;
        }
    }
}
