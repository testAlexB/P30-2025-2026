using System;
using System.Linq.Expressions;

namespace Array
{
    public class Program
    {
        static void Main()
        {
            /// создание челочисленного массива с 5 элементами
            int[] array = new int[5]; /// все элементы по умолчанию будут = 0

            /// вывод элементов массива
            Console.WriteLine(array[0]);
            Console.WriteLine(array[4]);

            Console.WriteLine("Размер массива = " + array.Length);

            /// перебор всех элементов массива
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"Element{index} = {array[index]}");
            }
        }
    }
}
