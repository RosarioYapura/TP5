using System;
//Escriba un programa en el cual se ingrese un número y mientras ese número sea mayor
//de 10, se pedirá el número de nuevo.

namespace tp5ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=10;
            while (num >= 10)
            {
                Console.WriteLine("Ingrese numeros mayores a 10: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El numero es menor a 10");
            Console.ReadKey();
        }

    }
}
