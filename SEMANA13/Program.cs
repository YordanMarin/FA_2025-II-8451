using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conti;
            Estudiantes e = new Estudiantes();
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENDIOS AL SISTEMA DE REGISTRO DE ESTUDIANTES\n");
                Console.WriteLine("*** Menú de opciones ***");
                Console.WriteLine("* 0. Salir             *");
                Console.WriteLine("* 1. Registrar         *");
                Console.WriteLine("* 2. Mostrar           *");
                Console.WriteLine("* 3. Buscar            *");
                Console.WriteLine("* 4. Modificar         *");
                Console.WriteLine("* 5. Eliminar          *");
                Console.WriteLine("* 6. Ordenar           *");
                Console.WriteLine("************************\n");

                int opc;
                while (true)
                {
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opc) & opc >= 0 & opc <= 6)
                        break;
                    else Console.WriteLine("Ingrese una opción valida!\n");
                }
                switch (opc)
                {
                    case 0: return;
                    case 1: e.insertar(); break;
                    case 2: e.mostrar(); break;
                    case 3:
                        Console.Write("\nIngrese el nombre a buscar: ");
                        string nom = Console.ReadLine();
                        int indice = e.buscar(nom);
                        if (indice != -1) Console.WriteLine("\nExiste");
                        else Console.WriteLine("\nNo Existe");
                        break;
                    case 4:
                        e.mostrar();
                        e.modificar();
                        e.mostrar();
                        break;
                    case 5:
                        e.mostrar();
                        e.eliminar();
                        e.mostrar();
                        break;
                    case 6: 
                        e.ordenar();
                        e.mostrar();
                        break;

                }
                while (true)
                {
                    Console.Write("\n¿Desea continuar?(s/n): ");
                    conti = Console.ReadLine();
                    if (conti == "s" || conti == "n") break;
                    else Console.WriteLine("Ingrese solo 's' o 'n'!\n");
                }
            } while (conti == "s");
        }
    }
}
