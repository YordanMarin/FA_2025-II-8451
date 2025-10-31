using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11
{
    internal class ejer6
    {
        static void Main(string[] args)
        {
            string[] nom = new string[5];
            int reg = 0;

            for(int i = 0; reg < nom.Length; i++)
            {
                Console.Write($"Ingrese el producto {reg+1}: ");
                string pro = Console.ReadLine();
                bool buscar = false;

                for(int j = 0; j < reg; j++)
                {
                    if(nom[j] == pro)
                    {
                        Console.WriteLine("Producto existente.\n");
                        buscar = true;
                        break;
                    }
                }

                if (buscar == false)
                {
                    nom[reg] = pro;
                    reg++;
                }
            }
            Console.WriteLine("\n\nLista de productos: ");
            for (int i = 0; i < nom.Length; i++)
                Console.WriteLine(nom[i]);
            Console.ReadKey();
        }
    }
}
