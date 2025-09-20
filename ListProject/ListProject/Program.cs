using System;
using System.Collections.Generic;
using System.Linq;

namespace ListProject
{
    public class Program
    {
        static void Main()
        {
            List<double> list = new List<double>(); /// пустой список без элементов
            Console.WriteLine("Исходный размер списка = " + list.Count);

            /// добавление элементов в список
            list.Add(1.0);
            list.Add(1.22);
            list.Add(22.33);
            list.Add(0.0);
            list.Add(-1.0);
            list.Add(0.0);

            Console.WriteLine("Размер списка после добавления элементов = " + list.Count);

            Console.WriteLine("Элементы списка поиндексным перебором:");
            for (int index = 0; index < list.Count; index++)
            {
                Console.Write($"[{list[index]}] ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Элементы списка с помощью foreach:");
            foreach (double element in list)
            {
                Console.Write($"[{element}] ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Вывод элемента первого [0]: " + list[0]);
            Console.WriteLine("Вывод элемента первого .First: " + list.First());
            Console.WriteLine("Вывод последнего элемента .Last: " + list.Last());
            Console.WriteLine("Вывод последнего элемента []: " + list[list.Count - 1]);


            Console.WriteLine();
            Console.WriteLine();
            /// удаление элементов
            list.RemoveAt(0); /// удаляем первый элемент
            Console.WriteLine("Элементы списка после удаления первого элемента:");
            foreach (double element in list)
            {
                Console.Write($"[{element}] ");
            }
            Console.WriteLine();
            Console.WriteLine();

            /// удаление первого нуля
            list.Remove(0.0);
            Console.WriteLine("Элементы списка после удаления первого нуля:");
            foreach (double element in list)
            {
                Console.Write($"[{element}] ");
            }
            Console.WriteLine();
            Console.WriteLine();

            /// удаление всех нулей
            list.RemoveAll(element => element == 0.0);
            Console.WriteLine("Элементы списка после удаления всех нулей:");
            foreach (double element in list)
            {
                Console.Write($"[{element}] ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Элемент 7.8 находится в списке? " + list.Contains(7.8));
            Console.WriteLine("Элемент 1.0 находится в списке? " + list.Contains(1.0));
            Console.WriteLine("Элемент 22.33 находится в списке? " + list.Contains(22.33));
        }
    }
}
