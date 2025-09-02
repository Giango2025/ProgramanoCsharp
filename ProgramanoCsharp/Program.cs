using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramanoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MOstrar mensaje
            Console.WriteLine("Bienvenido a C#");
            //Definir variables
            int a, b, suma;
            //Entraada de datos
            //pido datos a la persona solicitando datos
            Console.WriteLine("Ingrese el primer numero");
            //llamado o guardando datos
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            //llamado o guardando datos
            b = Convert.ToInt32(Console.ReadLine());
            //proceso de datos
            suma = a + b;
            //salida de datos
            Console.WriteLine("La suma es: " +suma);
            Console.WriteLine($"La suma de {a} + {b} = {suma}");
            //llamado o guardando datos
            

            //PAUSAR PARA MOSTRAR RESULTADOS
            Console.ReadKey();
        }
    }
}
