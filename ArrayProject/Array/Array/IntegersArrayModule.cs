using System;

namespace Array
{
    public class IntegersArrayModule
    {
        static public void PrintIntegersArray(int[] array)
        {
            Console.Write("[");
            for (int index = 0; index < array.Length - 1; ++index)
            {
                Console.Write(array[index] + ", ");
            }
            Console.Write(array[array.Length - 1] + "]");
        }

        static public int? FindMaxElement(int[] initData)
        {
            if (initData.Length == 0)
            {
                return null;
            }

            int max = initData[0];
            for (int index = 1; index < initData.Length; ++index)
            {
                int element = initData[index];
                if (element > max)
                {
                    max = element;
                }
            }

            return max; /// вернуть итоговый результат
        }
    }
}
