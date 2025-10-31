using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11
{
    internal class ejer8
    {
        static void Main(string[] args)
        {
            string[] nom = { "jose", "oscar", "carmen", "alexa" };
            
            Console.WriteLine("Lista de nombres: ");
            foreach (string i in nom)
                Console.WriteLine(i);

            Console.Write("\nIngrese el nombre a modificar: ");
            string ingreso = Console.ReadLine();

            int indice = -1;

            for (int i = 0; i < nom.Length; i++)
            {
                if (nom[i] == ingreso)
                    indice = i;
            }

            if (indice != -1)
            {
                Console.Write("\nIngrese su nuevo nombre: ");
                nom[indice] = Console.ReadLine();

                Console.WriteLine("\nLista de nombres modificado: ");
                foreach (string i in nom)
                    Console.WriteLine(i);

            }
            else Console.WriteLine("\nNo se puede modificar porque no existe");

            Console.ReadKey();
        }
    }
}
