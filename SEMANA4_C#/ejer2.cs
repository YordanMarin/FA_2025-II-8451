using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            int an = int.Parse(Console.ReadLine());

            if((an % 4 ==0 && an % 100 !=0) || an % 400 == 0)
                Console.WriteLine("El año es bisiesto");
            else
                Console.WriteLine("El no año es bisisneto");

            if (an % 2 == 0) Console.WriteLine("El año es par");
            else Console.WriteLine("El año es impar");

            Console.ReadKey();
        }
    }
}
