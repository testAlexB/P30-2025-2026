using System;

namespace StructProject
{
    class Program
    {
        static void Main()
        {
            Point beginVector = new Point();
            beginVector.X = 0;
            beginVector.Y = 0;
            beginVector.Name = "Начало вектора";

            Point endVector = new Point();
            endVector.X = 0;
            endVector.Y = 55;
            endVector.Name = "Конец вектора";

            Console.WriteLine($"{beginVector.Name}:({beginVector.X}, {beginVector.Y})" +
                              $" | {endVector.Name}:({endVector.X}, {endVector.Y})");

            Console.WriteLine("Длина вектора = " + Point.CalcLenVector(beginVector, endVector));
        }
    }
}
