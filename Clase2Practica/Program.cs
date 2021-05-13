using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Practica.Clase2Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean aux = true;
            do
            {
                Console.WriteLine("¡Bienvenido!, que desea hacer: ");
                Console.WriteLine("1.Ingresar un nuevo Producto.\n2.Leer la lista de productos sin entregar.\n0.Salir");
                int opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        EjercicioEscribirJson.Ejecutar();
                        break;
                    case 2:
                        EjercicioLeerJson.Ejecutar();
                        break;
                    case 0:
                        Console.WriteLine("Gracias Por Utilizarnos.");
                        aux = false;
                        break;
                    default:
                        Console.WriteLine("Ups! Opcion incorrecta, intente de nuevo\n");
                        break;
                }
            } while (aux);
        }
    }
}
