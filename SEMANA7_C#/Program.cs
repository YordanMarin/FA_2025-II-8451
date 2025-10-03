using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secreto = rnd.Next(1,21);
            int intentos = 3;

            Console.WriteLine("*************************************************");
            Console.WriteLine("*        BIENVENIDOS AL JUEGO ADIVINADOR        *");
            Console.WriteLine("*                                               *");
            Console.WriteLine("* 1. Ud. debera adivinar el número entre 1 y 20 *");
            Console.WriteLine("* 2. Ud. tiene 3 intentos                       *");
            Console.WriteLine("* 3. Por cada falla se otorgora una pista       *");
            Console.WriteLine("*************************************************");

            do
            {
                Console.Write($"\nIngrese número (intento {intentos}): ");
                int num = int.Parse(Console.ReadLine());

                if(num == secreto)
                {
                    Console.WriteLine("\nFelicidades. adivinaste!");
                    return;
                }
                else
                {
                    intentos--;
                    if (num < secreto)
                        Console.WriteLine("El número es mayor");
                    else
                        Console.WriteLine("El número es menor");
                }

            } while (intentos > 0);
            Console.WriteLine("\nNo lograste adivinar el número " + secreto);
        }
    }
}
