using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5();
            Console.ReadKey(); //realizando detenimiento de consola
        }

        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso FA de {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Yordan\"");
        }

        static void ejer3()
        {
            Console.Write("Ingrese x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            double divi = (double)x / (double)y;

            Console.WriteLine("\nSuma: "+sum);
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicación: " + (x * y));
            Console.WriteLine("División: " + divi);
        }

        static void ejer4()
        {
            Console.Write("Ingrese un número decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num,0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1/3d);

            Console.WriteLine("raiz2: " + raiz2);
            Console.WriteLine("redondeado: " + redo);
            Console.WriteLine("Al cubo: " + cubo);
            Console.WriteLine("Raiz3: " + raiz3);
        }

        static void ejer5()
        {
            Console.Write("Ingrese un número: ");
            string num = Console.ReadLine();

            double deci = double.Parse(num);
            int entero = (int)Math.Round(deci);

            Console.WriteLine("resto: " + entero % 2);
            Console.WriteLine("divi 3: " + deci / 3);
        }
    }
}


