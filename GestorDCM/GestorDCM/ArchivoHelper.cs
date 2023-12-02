using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDCM
{
    public static class ArchivoHelper
    {
        public static void GuardarContenidoEnArchivo(string rutaFichero, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFichero))
                {
                    sw.WriteLine(contenido);
                }
                MessageBox.Show("Fichero guardado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}");
            }
        }
        public static void CrearArchivo(string rutaArchivo)
        {
            try
            {
                FileStream fs = File.Create(rutaArchivo);
                fs.Close();

                if (File.Exists(rutaArchivo))
                {
                    Console.WriteLine("Archivo creado.");
                }
                else
                {
                    Console.WriteLine("Archivo no creado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el archivo: {ex.Message}");
            }
        }
    }
}
