using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11
{
    internal class ejer7
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            Random rnd = new Random();

            Console.Write("Valores aleatorios: ");
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(1, 51);
                Console.Write(num[i]+" ");
            }

            Console.Write("\n\nIngrese el número a buscar: ");
            int buscar = int.Parse(Console.ReadLine());

            int indice = -1;

            for(int i = 0;i < num.Length; i++)
            {
                if (num[i] == buscar)
                    indice = i;
            }

            if (indice != -1)
                Console.WriteLine("\nExiste y su indice es " + indice);
            else Console.WriteLine("\nNo existe");

            Console.ReadKey();
        }
    }
}
