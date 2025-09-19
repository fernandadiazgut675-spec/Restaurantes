using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurantes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Acciones acciones = new Acciones();
            ExportarExcel exportar = new ExportarExcel();
            while (true)
                {
                    switch (Menu())
                    {
                        case 1:
                            acciones.AgregarRestaurantes();

                            break;

                        case 2:
                            acciones.Mostrar();
                            break;
                        case 3:
                            acciones.Modificar();
                            break;
                        case 4:
                            acciones.Eliminar();
                            break;
                        case 5:
                            exportar.Exportar(); 
                        break;
                        default:
                            break;
                    }
                }

            }
            static int Menu()
            {
                Console.WriteLine("1)Agregar");
                Console.WriteLine("2)mostrar");
                Console.WriteLine("3)Modificar");
                Console.WriteLine("4)Eliminar");
                Console.WriteLine("5)Exportar");
                int opc = Convert.ToInt32(Console.ReadLine());
                return opc;

            }
        
    }
}

