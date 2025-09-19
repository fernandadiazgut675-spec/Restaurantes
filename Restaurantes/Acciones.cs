using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes
{
    internal class Acciones
    {
        Restaurantes a = new Restaurantes();
        Restaurantes[] ArreglosRestaurantes;

        public void AgregarRestaurantes()
        {
            Console.WriteLine("¿CUÁNTAS COMPUTADORAS DESEAS INGRESAR?");
            int num = Convert.ToInt32(Console.ReadLine());
            ArreglosRestaurantes = new Restaurantes[num];

            for (int i = 0; i < ArreglosRestaurantes.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre:");
                a.Nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la Direccion:");
                a.Direccion = Console.ReadLine();
                Console.WriteLine("Ingresa el tipo de comida :");
                a.TipoComida = Console.ReadLine();
                Console.WriteLine("Ingresa la calidicacion:");
                a.Calificacion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el precio promedio :");
                a.PrecioPromedio = Convert.ToInt32(Console.ReadLine());

                ArreglosRestaurantes[i] = new Restaurantes(a.Nombre, a.TipoComida , a.Direccion, a.Calificacion, a.PrecioPromedio);
            }
        }
        public void Mostrar()
        {
            int index = 0;
            foreach (var i in ArreglosRestaurantes)
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine($"ID: {index}");
                Console.WriteLine($"Nombre: {i.Nombre}");
                Console.WriteLine($"dieccion: {i.Direccion}");
                Console.WriteLine($"calificacion: {i.Calificacion}");
                Console.WriteLine($"Tipo de comida: {i.TipoComida}");
                Console.WriteLine($"precio promedio : {i.PrecioPromedio}");
                Console.WriteLine("_____________________________________");

            }
        }
        public void Modificar()
        {
            Console.WriteLine("Ingresa el ID de la computadora a modificar:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id >= 0 && id < ArreglosRestaurantes.Length)
            {
                Console.WriteLine("Ingresa el nuevo nombre:");
                ArreglosRestaurantes[id].Nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la nueva Direccion :");
                ArreglosRestaurantes[id].Calificacion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el t`po de comida:");
                ArreglosRestaurantes[id].TipoComida = Console.ReadLine();
                Console.WriteLine("Ingresa la calificacion :");
                ArreglosRestaurantes[id].TipoComida = Console.ReadLine();
                Console.WriteLine("Ingresa el nuevo sistema:");
                ArreglosRestaurantes[id].PrecioPromedio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Se modifica con exito");
            }
            else
            {
                Console.WriteLine(" ID no válido.");
            }
        }
        public void Eliminar()
        {
            Console.WriteLine("Ingresa el ID para eliminar:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id >= 0 && id < ArreglosRestaurantes.Length)
            {

                Restaurantes[] nuevoArreglo = new Restaurantes[ArreglosRestaurantes.Length - 1];
                int j = 0;

                for (int i = 0; i < ArreglosRestaurantes.Length; i++)
                {
                    if (i != id)
                    {
                        nuevoArreglo[j] = ArreglosRestaurantes[i];
                        j++;
                    }
                }

                ArreglosRestaurantes = nuevoArreglo;
                Console.WriteLine(" Restaurante  eliminado con éxito.");
            }
            else
            {
                Console.WriteLine(" ID no válido.");
            }
        }
        

    }
}
