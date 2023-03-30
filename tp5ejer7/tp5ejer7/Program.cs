using System;
using System.Globalization;
//Calcular las calificaciones de un grupo de alumnos. La nota final de cada alumno se
//calcula según el siguiente criterio: se promediarán las notas obtenidas en la parte
//práctica; la parte de problemas y la parte teórica. El programa leerá el nombre del
//alumno, las tres notas obtenidas, mostrará el resultado por pantalla, y a continuación
//volverá a pedir los datos del siguiente alumno hasta que el nombre sea una cadena
//vacía. Las notas deben estar comprendidas entre 0 y 10, y si no están dentro de ese
//rango no se imprimirá el promedio y se mostrará un mensaje de error.
namespace tp5ejer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre="a";
            float nota1=0 , nota2=0, nota3=0, nottfinal;
           
            while (nombre != string.Empty)
            {
                Console.Write("Nombre del alumno:");
                nombre = Console.ReadLine();
                while( (nota1>=0 && nota1<=10)&&(nota2 >= 0 && nota2 <= 10)&&(nota3 >= 0 && nota3 <= 10))
                {
                    Console.Write("Nota de Practica:");
                    nota1 = int.Parse(Console.ReadLine());
                    Console.Write("Nota de Problemas:");
                    nota2 = int.Parse(Console.ReadLine());
                    Console.Write("Nota Teorica:");
                    nota3 = int.Parse(Console.ReadLine());
                    break;
                } 
                if ((nota1 >= 0 && nota1 <= 10) && (nota2 >= 0 && nota2 <= 10) && (nota3 >= 0 && nota3 <= 10))
                {
                    Console.WriteLine("CORRECTO!");
                    nottfinal = (nota1 + nota2 + nota3) / 3;
                    Console.WriteLine("Su promedio es: " + nottfinal);
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }
            }
           

            Console.ReadKey();
        }
    }
}
