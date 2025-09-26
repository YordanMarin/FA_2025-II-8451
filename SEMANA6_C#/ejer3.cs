using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int i = 1;
            while (i <= filas)
            {
                int j = 1;
                while (j <= columnas)
                {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}
