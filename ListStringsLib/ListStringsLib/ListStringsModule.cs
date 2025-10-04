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

        static public List<int> FindIndexesWithContainsText(string text,
                                                            List<string> sourceData)
        {
            List<int> result = new List<int>();

            for(int index = 0; index < sourceData.Count; ++index)
            {
                string elementValue = sourceData[index];

                if(elementValue.Contains(text))
                {
                    result.Add(index + 1);
                }
            }

            return result;
        }
    }
}
