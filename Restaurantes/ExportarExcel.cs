using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Restaurantes
{
    internal class ExportarExcel
    {
        Restaurantes a = new Restaurantes();
        Restaurantes[] ArreglosRestaurantes;
        public void Exportar()
        {
            if (ArreglosRestaurantes == null || ArreglosRestaurantes.Length == 0)
            {
                Console.WriteLine("No hay computadoras para exportar.");
                return;
            }

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\computadoras.xlsx";

            using (var wb = new XLWorkbook())
            {
                var ws = wb.AddWorksheet("Computadoras");

                // Encabezados
                ws.Cell(1, 1).Value = "ID";
                ws.Cell(1, 2).Value = "Nombre";
                ws.Cell(1, 3).Value = "Marca";
                ws.Cell(1, 4).Value = "Almacenamiento (GB)";
                ws.Cell(1, 5).Value = "Memoria RAM";
                ws.Cell(1, 6).Value = "Sistema";

                // Datos
                for (int i = 0; i < ArreglosRestaurantes.Length; i++)
                {
                    var c = ArreglosRestaurantes[i];
                    ws.Cell(i + 2, 1).Value = i;  // ID
                    ws.Cell(i + 2, 2).Value = c.Nombre;
                    ws.Cell(i + 2, 3).Value = c.Direccion;
                    ws.Cell(i + 2, 4).Value = c.TipoComida;
                    ws.Cell(i + 2, 5).Value = c.Calificacion;
                    ws.Cell(i + 2, 6).Value = c.PrecioPromedio;
                }

                // Estilos
                ws.Row(1).Style.Font.Bold = true;
                ws.Row(1).Style.Fill.BackgroundColor = XLColor.LightGray;
                ws.Column(4).Style.NumberFormat.Format = "0 GB";  // Almacenamiento
                ws.Column(6).Style.NumberFormat.Format = "0";    // Sistema
                ws.Columns().AdjustToContents();
                ws.RangeUsed().SetAutoFilter();

                // Guardar archivo
                wb.SaveAs(ruta);
            }

            Console.WriteLine($"Archivo exportado correctamente en: {ruta}");
        }


    }
}
