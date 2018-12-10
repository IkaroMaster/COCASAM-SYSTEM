using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.XtraEditors;
using System.Security.Cryptography;
using DevExpress.XtraPrinting;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraReports.UI;

namespace CapaPresentacion.Funciones
{
    class Funciones
    {
        public static int idUsuario = 0;
        public static String nombreParroquia = "";
        public static void ExportarExcel(DevExpress.XtraGrid.GridControl grid, String nombre)
        {
            SaveFileDialog archivo = new SaveFileDialog();
            try
            {
                archivo.Filter = "xls|*.xls";
                archivo.FileName = nombre;
                archivo.ShowDialog();

                if (archivo.FileName.Length > 0)
                {
                    grid.ExportToXls(archivo.FileName);
                    Process.Start(archivo.FileName);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al generar el archivo", ex);
            }
        }
        public static void ExportarPDF(DevExpress.XtraGrid.GridControl grid, String nombre)
        {
            SaveFileDialog archivo = new SaveFileDialog();
            try
            {
                archivo.Filter = "pdf|*.pdf";
                archivo.FileName = nombre;
                archivo.ShowDialog();

                if (archivo.FileName.Length > 0)
                {
                    grid.ExportToPdf(archivo.FileName);
                    Process.Start(archivo.FileName);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al generar el archivo", ex);
            }
        }

        public static void MostrarReportes(String titulo, XtraReport reporte, Form MDIParent, Boolean ocultarMenu)
        {
            //Reportes.FrmModeloReportes vistaPrevia = new Reportes.FrmModeloReportes();
            //vistaPrevia.HideToolBars = ocultarMenu;
            //vistaPrevia.Text = titulo;
            //vistaPrevia.MdiParent = MDIParent;
            //vistaPrevia.setReporte(reporte);
            //vistaPrevia.Show();
            //vistaPrevia.Focus();
        }
        public static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

               
                return sb.ToString();
            }
        }
    }
}
