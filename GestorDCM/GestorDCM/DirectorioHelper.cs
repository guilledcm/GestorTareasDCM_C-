using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDCM
{
    public static class DirectorioHelper
    {
        public static void BorrarArchivoODirectorio(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    File.Delete(ruta);
                }
                else if (Directory.Exists(ruta))
                {
                    Directory.Delete(ruta, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al borrar el archivo/directorio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CrearDirectorio(string rutaDirectorio)
        {
            try
            {
                Directory.CreateDirectory(rutaDirectorio);

                if (Directory.Exists(rutaDirectorio))
                {
                    Console.WriteLine("Directorio creado.");
                }
                else
                {
                    Console.WriteLine("Directorio no creado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el directorio: {ex.Message}");
            }
        }
    }
}
