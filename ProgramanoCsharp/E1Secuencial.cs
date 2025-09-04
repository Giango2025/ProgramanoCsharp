using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramanoCsharp
{
    public class E1Secuencial
    {
        public void areatriangulo()
        {
            //variables
            //1
            double s; //semiperimetro
            //2
            double area = 0;

            Console.WriteLine("algoritmo del triangulo");
            Console.WriteLine("ingrese el lado a: ");
            var a=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el lado b: ");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el lado c: ");
            var test = int.TryParse(Console.ReadLine(),out int c) ;

            //proceso
            s = (a + b + b)/2;

            area= Math.Sqrt(s* (s - a)*(s  -b)*(s - c));

            //imprimir datos

            Console.WriteLine($"EL AREA DEL tRIANGULO SEGUN LOS LADOS {a}, {b}, {c} es {area}");

        }
    }
}
