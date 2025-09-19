using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al sistema de Áreas\n");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. rectangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Circulo\n");

            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    Console.Write("Ingrese lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("Área del cuadrado: " +lado*lado);
                    break;
                case 2:
                    Console.Write("Ingrese la base: ");
                    int bse = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la alura: ");
                    int alt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Área del rectangulo: " + bse * alt);
                    break;
                case 3:
                    Console.Write("Ingrese la base: ");
                    int bse2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la alura: ");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Área del triangulo: " + (bse2 * alt2)/2);
                    break;
                case 4:
                    Console.Write("Ingrese la radio: ");
                    double ra = double.Parse(Console.ReadLine());
                    Console.WriteLine("Área del circulo: "+Math.Round((Math.PI * Math.Pow(ra,2)),2));
                    break;
                default: break;
            }
        }
    }
}
