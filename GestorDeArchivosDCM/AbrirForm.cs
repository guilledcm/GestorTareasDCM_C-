using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeArchivosDCM
{
    public partial class AbrirForm : Form
    {
        public AbrirForm()
        {
            InitializeComponent();
        }

        public void AbrirForm_Load(object sender, EventArgs e)
        {
            CargarCosas();

        }

        public void CargarCosas()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("F:\\DAMGS2GuillermoDeCarlosMunoz\\DesInterfaces\\GestorDeArchivosDCM\\GestorDeArchivosDCM\\bin\\Debug\\net6.0-windows\\Resources\\FILES");
            if (directoryInfo.Exists)
            {
                foreach (var elemento in directoryInfo.GetFileSystemInfos())
                {
                    if (elemento is DirectoryInfo)
                    {
                        string name = elemento.Name;
                        addDirecotry(name);
                    }
                    else if (elemento is FileInfo)
                    {
                        string name = elemento.Name;
                        addFile(name);
                    }
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
            }
        }

        private void addFile(string name)
        {
            Button btnFile = new Button();
            btnFile.Width = 120;
            btnFile.Height = 120;
            btnFile.Text = name;
            btnFile.ImageAlign = ContentAlignment.TopCenter;
            btnFile.TextAlign = ContentAlignment.BottomCenter;
            btnFile.Image = System.Drawing.Image.FromFile("F:\\DAMGS2GuillermoDeCarlosMunoz\\DesInterfaces\\GestorDeArchivosDCM\\GestorDeArchivosDCM\\bin\\Debug\\net6.0-windows\\Resources\\imagenes\\File.png");
            btnFile.BackgroundImageLayout = ImageLayout.Stretch;
            btnFile.FlatAppearance.BorderSize = 0;
            btnFile.FlatStyle = FlatStyle.Flat;
            btnFile.TextImageRelation = TextImageRelation.ImageAboveText;
            flowLayoutPanel.Controls.Add(btnFile);

        }

        private void addDirecotry(string name)
        {
            Button btnDirectory = new Button();
            btnDirectory.Width = 120;
            btnDirectory.Height = 120;
            btnDirectory.Text = name;
            btnDirectory.ImageAlign = ContentAlignment.TopCenter;
            btnDirectory.TextAlign = ContentAlignment.BottomCenter;
            btnDirectory.Image = System.Drawing.Image.FromFile("F:\\DAMGS2GuillermoDeCarlosMunoz\\DesInterfaces\\GestorDeArchivosDCM\\GestorDeArchivosDCM\\bin\\Debug\\net6.0-windows\\Resources\\imagenes\\Folder.png");
            btnDirectory.BackgroundImageLayout = ImageLayout.Stretch;
            btnDirectory.FlatAppearance.BorderSize = 0;
            btnDirectory.FlatStyle = FlatStyle.Flat;
            btnDirectory.TextImageRelation = TextImageRelation.ImageAboveText;
            flowLayoutPanel.Controls.Add(btnDirectory);
        }

        private void rightClick(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                menuClickDerecho.Show(this, (e as MouseEventArgs).Location);
            }
        }

        private void cREARFICHEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreadorFicheroDirectorio creadorFicheroDirectorio = new CreadorFicheroDirectorio();
            creadorFicheroDirectorio.cambiarTitle("Create Fichero");
            creadorFicheroDirectorio.ShowDialog();
            
        }

        private void cREARCARPETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreadorFicheroDirectorio creadorFicheroDirectorio = new CreadorFicheroDirectorio();
            creadorFicheroDirectorio.cambiarTitle("Create Directory");
            creadorFicheroDirectorio.ShowDialog();
            
        }
    }
}
