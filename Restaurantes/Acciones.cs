using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes
{
    using System;
    using System.Collections.Generic;

    internal class Acciones
    {
        List<Restaurantes> listaRestaurantes = new List<Restaurantes>();

        public void AgregarRestaurantes()
        {
            Console.WriteLine("¿CUÁNTOS restaurantes deseas ingresar?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Restaurantes a = new Restaurantes();

                Console.WriteLine("Ingresa el nombre:");
                a.Nombre = Console.ReadLine();

                Console.WriteLine("Ingresa la dirección:");
                a.Direccion = Console.ReadLine();

                Console.WriteLine("Ingresa el tipo de comida:");
                a.TipoComida = Console.ReadLine();

                Console.WriteLine("Ingresa la calificación:");
                a.Calificacion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el precio promedio:");
                a.PrecioPromedio = Convert.ToInt32(Console.ReadLine());

                listaRestaurantes.Add(a); // Se agrega directamente a la lista
            }
        }

        public void Mostrar()
        {
            int index = 0;
            foreach (var i in listaRestaurantes)
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine($"ID: {index}");
                Console.WriteLine($"Nombre: {i.Nombre}");
                Console.WriteLine($"Dirección: {i.Direccion}");
                Console.WriteLine($"Calificación: {i.Calificacion}");
                Console.WriteLine($"Tipo de comida: {i.TipoComida}");
                Console.WriteLine($"Precio promedio: {i.PrecioPromedio}");
                Console.WriteLine("_____________________________________");
                index++;
            }
        }

        public void Modificar()
        {
            Console.WriteLine("Ingresa el ID del restaurante a modificar:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id >= 0 && id < listaRestaurantes.Count)
            {
                Console.WriteLine("Ingresa el nuevo nombre:");
                listaRestaurantes[id].Nombre = Console.ReadLine();

                Console.WriteLine("Ingresa la nueva dirección:");
                listaRestaurantes[id].Direccion = Console.ReadLine();

                Console.WriteLine("Ingresa el tipo de comida:");
                listaRestaurantes[id].TipoComida = Console.ReadLine();

                Console.WriteLine("Ingresa la nueva calificación:");
                listaRestaurantes[id].Calificacion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nuevo precio promedio:");
                listaRestaurantes[id].PrecioPromedio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Restaurante modificado con éxito.");
            }
            else
            {
                Console.WriteLine("ID no válido.");
            }
        }

        public void Eliminar()
        {
            Console.WriteLine("Ingresa el ID para eliminar:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id >= 0 && id < listaRestaurantes.Count)
            {
                listaRestaurantes.RemoveAt(id); // Elimina directo por índice
                Console.WriteLine("Restaurante eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("ID no válido.");
            }
        }
    }

}
