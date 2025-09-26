using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6_C_
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.Write("Genere una contraseña: ");
            string contra = Console.ReadLine();

            int intentos = 3;

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("----   Válida tu contraseña    ---");
            Console.WriteLine("----------------------------------\n");

            while (intentos > 0)
            {
                Console.Write("Ingresa tu contraseña: ");
                string pass = Console.ReadLine();

                if(contra == pass)
                {
                    Console.WriteLine("\nAcceso concedido!");
                    return;
                }
                else
                {
                    Console.WriteLine($"\nContraseña incorrecta! Le restan {intentos-1} intentos");
                    intentos--;
                }
            }
            Console.WriteLine("\nAcceso denegado. Ya culmino todos sus intentos!");
            Console.ReadKey();
        }
        
    }
}
