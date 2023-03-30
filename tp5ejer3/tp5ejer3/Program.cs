using System;
//Dada una secuencia de números ingresados por teclado que finaliza con la entrada de
//un número negativo, por ejemplo: 5,3,0,2,4,4,0,0,2,3,6,0,......,-1; realizar un
//programa que calcule el promedio de los números ingresados.

namespace tp5ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0, i=1;
            float prom=0;
            
            while(num >=0)
            {
               
                    
                    Console.WriteLine("ingresa numeros: ");
                    num =int.Parse(Console.ReadLine());
                prom = prom + num;
                    i++;
              

            }
            prom = prom / (i-1);
            Console.WriteLine("Se ha ingresado un numero negativo ");
            Console.WriteLine("El promedio de numeros ingresados es: "+prom);
            Console.ReadKey();
        }
    }
}
