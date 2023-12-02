using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDCM
{
    public partial class CreadorFicheroDirectorioForm : Form
    {
        private AbrirForm abrirForm;
        public string rutaFichero { get; set; }
        private Action<string> callbackDeCreacion;
        public CreadorFicheroDirectorioForm(AbrirForm abrirForm,Action<string> callbackDeCreacion)
        {
            InitializeComponent();
            this.abrirForm = abrirForm;
            this.callbackDeCreacion = callbackDeCreacion;
        }

        public void cambiarTitle(string nombre)
        {
            this.lblTittle.Text = nombre;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string nombre = textBox.Text;
            string rutaFichero = Path.Combine(abrirForm.DirectorioActual, nombre + ".txt");

            if (lblTittle.Text.Equals("Create Fichero"))
            {
                ArchivoHelper.CrearArchivo(rutaFichero);
            }
            else if (lblTittle.Text.Equals("Create Directory"))
            {
                DirectorioHelper.CrearDirectorio(Path.Combine(abrirForm.DirectorioActual, nombre));
            }

            callbackDeCreacion?.Invoke(rutaFichero);
            Close();
        }


        private void CrearArchivo(string rutaArchivo)
        {
            try
            {
                FileStream fs = File.Create(rutaArchivo);
                fs.Close();

                if (File.Exists(rutaArchivo))
                {
                    Console.WriteLine("File is created.");
                }
                else
                {
                    Console.WriteLine("File is not created.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating file: {ex.Message}");
            }
        }

        private void CrearDirectorio(string rutaDirectorio)
        {
            try
            {
                Directory.CreateDirectory(rutaDirectorio);

                if (Directory.Exists(rutaDirectorio))
                {
                    Console.WriteLine("Directory is created.");
                }
                else
                {
                    Console.WriteLine("Directory is not created.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating directory: {ex.Message}");
            }
        }
    }
}
