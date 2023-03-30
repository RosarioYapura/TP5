using System;
//- Escriba un programa que solicite dos números enteros (mínimo y máximo). A
//continuación, se debe pedir al usuario que ingrese números enteros situados entre el
//máximo y mínimo. Cada vez que un número se encuentre entre ese intervalo, se sumara
//uno a una variable. El programa terminará cuando se escriba un número que no
//pertenezca a ese intervalo, y al finalizar se debe mostrar por pantalla la cantidad de
//números ingresados dentro del intervalo.
namespace tp5ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo, maximo, num, suma=0, i=0;
            Console.Write("Ingresar un numero minimo: ");
            minimo = int.Parse(Console.ReadLine());
            Console.Write("Ingresar un numero maximo: ");
            maximo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa numeros dentro del parametros: ");
            num = int.Parse(Console.ReadLine());
            while ((num >= minimo) && (num <= maximo))
            {
                Console.WriteLine("Ingresa numeros dentro del parametro: ");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
                i++;

            }
            Console.WriteLine("La cantidad de numeros ingresados dentro del intervalo fue de: "+(i));
            Console.ReadKey();
        }
    }
}
