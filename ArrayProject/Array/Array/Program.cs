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
            array[0] = -4;

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

            int max = array[0];
            for(int index = 1; index < array.Length; index++)
            {
                int elementValue = array[index];

                if(elementValue > max)
                {
                    max = elementValue;
                }
            }
            Console.WriteLine("Максимальный элемент массива = " + max);

            /// перебор элементов массива, используя конструкцию foreach
            foreach(int elementValue in array)
            {
                Console.WriteLine(elementValue);
            }
        }
    }
}
