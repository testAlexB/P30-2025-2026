using System;

namespace StructProject
{
    class Program
    {
        static void Main()
        {
            Point beginVector = new Point();
            beginVector.X = -10;
            beginVector.Y = 5;
            beginVector.Name = "Начало вектора";

            Point endVector = new Point();
            endVector.X = 10;
            endVector.Y = -5;
            endVector.Name = "Конец вектора";

            Console.WriteLine($"{beginVector.Name}:({beginVector.X}, {beginVector.Y})" +
                              $" | {endVector.Name}:({endVector.X}, {endVector.Y})");
        }
    }
}
