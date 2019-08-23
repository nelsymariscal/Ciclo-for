using System;
namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Dame los números del X hasta Y");
            Console.WriteLine("Ingresa el valor de x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto va a ir la secuencia");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                for (int i = x; i < y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}
