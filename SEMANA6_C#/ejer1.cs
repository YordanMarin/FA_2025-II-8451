using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6_C_
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número entero: ");
            int num = int.Parse(Console.ReadLine());

            while(num <= 0)
            {
                Console.Write("Error. Ingrese número entero: ");
                num = int.Parse(Console.ReadLine());
            }

            int i = 1;
            Console.WriteLine();
            while(i<=12){
                Console.WriteLine($"{num} x {i} = {num*i}");
                i++;
            }
        }
    }
}
