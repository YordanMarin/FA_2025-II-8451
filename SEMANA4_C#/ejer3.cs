using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese monto en soles: ");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Dolares");
            Console.WriteLine("2. Euros\n");

            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.WriteLine("Dolares: " + Math.Round((monto / 3.75),2));
                    break;
                case 2: Console.WriteLine($"Euros: {(monto / 4.05):0F}");
                    break;
                default: Console.WriteLine("Opción incorrecta");
                    break;
            }
        }
    }
}
