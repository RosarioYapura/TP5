using System;
//Escriba un programa en el cual se ingrese un valor límite positivo, y a continuación
//solicite números al usuario hasta que la suma de los números introducidos supere el
//límite inicial.
namespace tp5ejer2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int limite, num=0;
            Console.WriteLine("Ingrese un limite: ");
            limite = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Ingrese numeros: ");
                num =num+ int.Parse(Console.ReadLine());
            
            } while (num<= limite);
            Console.WriteLine("La suma de numeros ingresados supero al limite " + num);
            Console.ReadKey();
        }

    }
}
