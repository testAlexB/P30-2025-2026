using System;

namespace LRProject
{
    class Program
    {
        static void Main()
        {
            int n = 0;

            Console.Write("Число элементов массива = ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for(int index = 0; index < array.Length; ++index)
            {
                Console.Write($"Элемент[{index}] = ");
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            double avg = 0.0;
            int sum = 0;
            foreach(int element in array)
            {
                sum += element;
            }
            avg = sum / array.Length;

            int count = 0;

            foreach(int element in array)
            {
                if (element < avg)
                {
                    ++count;
                }
            }

            Console.WriteLine("Число элементов = " + count);
        }
    }
}
