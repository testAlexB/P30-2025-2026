using System;
using System.Collections.Generic;

namespace SortingList
{
    class Program
    {

        /// <summary>
        ///  a
        ///  b
        ///  temp = a;
        ///  a = b;
        ///  b = temp;
        /// </summary>
        /// <param name="data"></param>
        static private void BubbleSortList(List<int> data, bool isAscending)
        {
            for(int i = 0; i < data.Count; ++i)
            {
                for(int j = 0; j < data.Count - 1; ++j)
                {
                    bool condition = isAscending ? data[j + 1] < data[j]
                                                 : data[j + 1] > data[j];

                    /*
bool condition = false;
if(isAscending)
{
    condition = data[j + 1] < data[j];
}
else
{
    condition = data[j + 1] > data[j];
}
*/

                    if (condition)
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }

        static string Print(List<int> d)
        {
            return ("[" + string.Join(", ", d) + "]");
        }

        static void Main()
        {
            List<int> data = new List<int>() { 5, 2, -10, 100, 6 };
            Console.WriteLine("init data: " + Print(data));
            /// если по возрастанию, ожидаем:
            /// [-10, 2, 5, 6, 100]
            BubbleSortList(data, true);
            Console.WriteLine("after sort ASC: " + Print(data));

            BubbleSortList(data, false);
            Console.WriteLine("after sort DESC: " + Print(data));
        }
    }
}
