using System;
using System.Collections.Generic;

namespace LRProject
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[3000];

            Random rnd = new Random();
            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(10, 10000);
            }
        }
    }
}
