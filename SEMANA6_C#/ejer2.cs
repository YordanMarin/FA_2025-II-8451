using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6_C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            int si = 0, sp = 0;
            while (true)
            {
                Console.Write("Ingrese un número positivo: ");
                int num = int.Parse(Console.ReadLine());

                if (num == 0) break;
                if (num < 0)
                {
                    Console.WriteLine("Error. Ingrese solo positivos!");
                    Console.WriteLine();
                    continue;
                }

                if (num % 2 == 0) sp += num; //sp = sp + num;
                else si += num;
            }
            Console.WriteLine("\nSuma de pares: " + sp);
            Console.WriteLine("Suma de impares: " + si);
            Console.ReadKey();
        }
    }
}
