using System;
using System.Collections.Generic;

namespace LRProject
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[1990];
            int a = 10;
            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = a;
                ++a;
            }

            List<int> result = new List<int>();
            foreach(int element in array)
            {
                int countD = 0;
                for(int d = 2; d < element; ++d)
                {
                    /// делится ли число нацело на d
                    if(element % d == 0)
                    {
                        ++countD;
                        break;
                    }
                }

                /// если делителей нет
                if(countD == 0)
                {
                    /// то число простое
                    result.Add(element);
                }
            }
        }
    }
}
