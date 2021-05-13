using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clase2Practica.Clase2Practica
{
    class EjercicioEscribirJson
    {
        public static void Ejecutar()
        {
            //TODO: Tarea armar ejemplo escribiendo json en un archivo
            string jsonText = File.ReadAllText(@"..\.\..\..\ordenes.json");

            JsonRoot jsonObj = JsonConvert.DeserializeObject<JsonRoot>(jsonText);

            List<Orden> ordenes = jsonObj.ordenes.ToList();

            int nroOrden = ordenes.Last().nroOrden + 1;

            Orden orden = new Orden();
            orden.nroOrden = nroOrden;

            Console.WriteLine("Ingrese descripcion:");
            orden.descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese cantidad:");
            string cantidadString = Console.ReadLine();
            orden.cantidad = Int32.Parse(cantidadString);

            Console.WriteLine("Ingrese precio:");
            string precioString = Console.ReadLine();
            orden.precio = Int32.Parse(precioString);

            ordenes.Add(orden);

            JsonRoot jsonroot = new JsonRoot();
            jsonroot.ordenes = ordenes;
            var jsonConvertido = JsonConvert.SerializeObject(jsonroot, Formatting.Indented);
            File.WriteAllText(@"..\.\..\..\ordenes.json", jsonConvertido);
        }
    }
}
