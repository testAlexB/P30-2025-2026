using System;

namespace FirstClassApp
{
    class Program
    {
        static void Main()
        {
            HomoSapiens dima = new HomoSapiens(); /// первый человек разумный в системе, идентифицируется как dima
            dima.SetName("Дима Новорожденный");
            Console.WriteLine(dima.GetName());
        }
    }
}
