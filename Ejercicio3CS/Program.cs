using System;

namespace Ejercicio3CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a, b;
            a =Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                //Esto es la parte del si
                Console.WriteLine("El primer número es mayor");
            }
            else
            {
                //Esto es la parte del no
                Console.WriteLine("El segundo número es mayor");
            }
            Console.ReadKey();
        }
    }
}
