using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            string opc;
            int num;
            do
            {
                Console.Clear();
                int suma = 0;
                Console.Write("Ingrese número: ");
                num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    suma += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n\nSuma: " + suma);

                Console.Write("\n¿Desea continuar? (Presione N para salir):");
                opc = Console.ReadLine();

            } while (opc != "N");
        }
    }
}
