using System;
//- Escriba un programa que valide si una nota está entre 0 y 10, sino está entre 0 y 10 la nota se pedirá de
//nuevo hasta que la nota sea correcta.

namespace tp5ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0;

            do
            {
                Console.WriteLine("Ingrese un numero entre 0 y 10: ");
                num = int.Parse(Console.ReadLine());

            } while ((num>10)&&(num>=0));

            Console.WriteLine("CORRECTO!"); 
            Console.ReadKey();
        }

    }
}
