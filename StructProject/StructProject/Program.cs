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

            int diffX = (int)Math.Pow(endVector.X - beginVector.X, 2);
            int diffY = (int)Math.Pow(endVector.Y - beginVector.Y, 2);

            int diff = diffX + diffY;

            double lenVector = Math.Sqrt(diff);
            Console.WriteLine("Длина вектора = " + lenVector);
        }
    }
}
