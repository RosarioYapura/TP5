using System;
//- Escribir un programa que calcule cuántos dígitos tiene un número entero positivo.
//(pista: se puede hacer dividiendo varias veces entre 10).

namespace tp5ejer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i=0;
            Console.WriteLine("ingresar un numero: ");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                i++;
                num = (num / 10);
            }
            Console.WriteLine("El numero ingresado tiene " + i + " digitos");
            Console.ReadKey();
        }
    }
}
