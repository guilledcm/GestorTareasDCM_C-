using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorDCM
{
    public partial class MainForm : Form
    {
        private static MainForm instance { get; set; }
        private AbrirForm abrirForm; 
        private MainForm()
        {
            InitializeComponent();
            this.Text = "Nuevo Archivo";
            instance = this;
        }
        public static MainForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MainForm();
            }
            return instance;
        }       

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm = new AbrirForm();
            abrirForm.ShowDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }


        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoFile();
        }
        private void nuevoFile()
        {
            this.Text = "Nuevo Archivo";
            this.textBox.Clear();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarElementoSeleccionado();
            nuevoFile();
        }
        private void GuardarArchivo()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                MessageBox.Show("No hay un archivo abierto para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string filePath = Path.Combine(abrirForm.DirectorioActual, this.Text);
            File.WriteAllText(filePath, textBox.Text);
            MessageBox.Show("Archivo guardado exitosamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nuevoFile();
        }
        private void BorrarElementoSeleccionado()
        {
            if (abrirForm != null)
            {
                string elementoSeleccionado = ObtenerElementoSeleccionado(); 
                if (!string.IsNullOrEmpty(elementoSeleccionado))
                {
                    string rutaCompleta = Path.Combine(abrirForm.DirectorioActual, elementoSeleccionado);
                    DirectorioHelper.BorrarArchivoODirectorio(rutaCompleta);
                    abrirForm.CargarCosas(abrirForm.DirectorioActual);
                    MessageBox.Show($"{elementoSeleccionado} ha sido borrado.", "Borrado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún elemento para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string ObtenerElementoSeleccionado()
        {
            if (abrirForm.elementoSeleccionado != null)
            {
                return abrirForm.elementoSeleccionado.Text;
            }
            return string.Empty;
        }

    }
}
