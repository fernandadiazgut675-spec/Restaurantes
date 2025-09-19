using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes
{
    internal class Restaurantes
    {
     
        public Restaurantes() { }

        public Restaurantes(string nombre, string direccion, string tipoComida, int calificacion, double precioPromedio)
        {
            Nombre = nombre;
            Direccion = direccion;
            TipoComida = tipoComida;
            Calificacion = calificacion;
            PrecioPromedio = precioPromedio;
        }

        public string Nombre { get; set; }
        public string Direccion{ get; set; }

        public string TipoComida { get; set; }

        public int Calificacion { get; set; }

        public double PrecioPromedio{ get; set; }
    }
}
