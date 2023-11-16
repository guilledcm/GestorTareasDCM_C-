using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeArchivosDCM
{
    public partial class CreadorFicheroDirectorio : Form
    {
        public CreadorFicheroDirectorio()
        {
            InitializeComponent();
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
            if (this.lblTittle.Text.Equals("Create Fichero"))
            {
                string rutaArchivo = Path.Combine("F:\\DAMGS2GuillermoDeCarlosMunoz\\DesInterfaces\\GestorDeArchivosDCM\\GestorDeArchivosDCM\\bin\\Debug\\net6.0-windows\\Resources\\FILES", this.textBox.Text + ".txt");
                FileStream fs = File.Create(rutaArchivo);
                if (File.Exists(rutaArchivo))
                {
                    Console.WriteLine("File is created.");
                }
                else
                {
                    Console.WriteLine("File is not created.");
                }

                this.Close();
                AbrirForm abrirForm = new AbrirForm();
                abrirForm.CargarCosas();

            }
            else if (this.lblTittle.Text.Equals("Create Directory"))
            {
                string rutaDirectorio = Path.Combine("F:\\DAMGS2GuillermoDeCarlosMunoz\\DesInterfaces\\GestorDeArchivosDCM\\GestorDeArchivosDCM\\bin\\Debug\\net6.0-windows\\Resources\\FILES", this.textBox.Text);
                Directory.CreateDirectory(rutaDirectorio);
                this.Close();
                AbrirForm abrirForm = new AbrirForm();
                abrirForm.CargarCosas();
            }
        }



    }
}
