using System;


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

            /// изменения значений в элементах массива
            array[1] = 5;
            array[4] = 25;
            array[0] = -5;

            /// перебор всех элементов массива
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"Element{index} = {array[index]}");
            }


            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                int elementValue = array[index];
                sum += elementValue;
            }
            Console.WriteLine("Сумма элементов массива = " + sum);
        }
    }
}
