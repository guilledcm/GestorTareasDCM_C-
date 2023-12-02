using GestorDCM.Properties;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AbrirForm : Form
    {
        private MainForm mainForm;
        private List<Button> buttonList = new List<Button>();
        private string directorioActual;
        private string directorioRaiz;
        public Button elementoSeleccionado;
        public string DirectorioActual
        {
            get { return directorioActual; }
            set { directorioActual = value; }
        }
        public AbrirForm()
        {
            InitializeComponent();
            this.directorioRaiz = Path.Combine(Application.StartupPath, "Resources", "FILES");
            this.directorioActual = directorioRaiz;
            this.mainForm = MainForm.GetInstance();
            CargarCosas(this.directorioActual);
            this.Text = $"Directorio actual: {Path.GetFileName(this.directorioActual)}";
            this.Activated += AbrirForm_Activated;
        }
        private void AbrirForm_Activated(object sender, EventArgs e)
        {
            CargarCosas(DirectorioActual);
        }

        public void CargarCosas(string directoryPath)
        {
            LimpiarBotones();
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            if (directoryInfo.Exists)
            {
                foreach (var elemento in directoryInfo.GetFileSystemInfos())
                {
                    if (elemento is DirectoryInfo)
                    {
                        addDirectoryButton(elemento.FullName);  
                    }
                    else if (elemento is FileInfo)
                    {
                        addFileButton(elemento.FullName); 
                    }
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe: " + directoryPath);
            }
        }


        private void addFileButton(string name)
        {
            AddButton(Path.GetFileName(name), "File.png");
        }

        private void addDirectoryButton(string name)
        {
            AddButton(Path.GetFileName(name), "Folder.png");
        }

        private void AddButton(string name, string imageName)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Resources", imageName);

            Button btn = new Button();
            btn.Width = 120;
            btn.Height = 120;
            btn.Text = name;
            btn.ImageAlign = ContentAlignment.TopCenter;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.Image = Image.FromFile(imagePath);

            ConfigureButton(btn);

            flowLayoutPanel.Controls.Add(btn);
            buttonList.Add(btn);
            btn.MouseDown += (s, e) => Btn_Click(s, e);
        }

        private void Btn_Click(object? sender, MouseEventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (e.Button == MouseButtons.Left)
                {
                    elementoSeleccionado = clickedButton;
                    string fileName = clickedButton.Text;
                    string filePath = Path.Combine(Application.StartupPath, "Resources", "FILES", directorioActual, fileName);

                    if (Directory.Exists(filePath))
                    {
                        string[] files = Directory.GetFiles(filePath);
                        string[] directories = Directory.GetDirectories(filePath);

                        LimpiarBotones();
                        LoadFilesInDirectory(files, directories);
                        this.directorioActual = filePath;
                        this.Text = $"Directorio actual: {fileName}";
                    }
                    else if (File.Exists(filePath))
                    {
                        string fileContent = File.ReadAllText(filePath);

                        if (mainForm != null)
                        {
                            mainForm.textBox.Text = fileContent;
                            mainForm.Text = fileName;
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El archivo o directorio no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    ShowContextMenu(clickedButton, e.Location);
                }

            }
        }
        private void ShowContextMenu(Button clickedButton, Point location)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Borrar");
            deleteMenuItem.Click += (s, e) => BorrarArchivo(clickedButton.Text);
            contextMenu.Items.Add(deleteMenuItem);
            contextMenu.Show(flowLayoutPanel, location);
        }
        public void LoadFilesInDirectory(string[] files, string[] directories)
        {
            LimpiarBotones();

            foreach (var directory in directories)
            {
                addDirectoryButton(directory);  
            }

            foreach (var file in files)
            {
                addFileButton(file); 
            }
        }
        private void BorrarArchivo(string fileName)
        {
            string filePath = Path.Combine(directorioActual, fileName);
            DirectorioHelper.BorrarArchivoODirectorio(filePath);
            CargarCosas(directorioActual);
            MessageBox.Show($"{fileName} ha sido borrado.", "Borrado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LimpiarBotones()
        {
            foreach (var button in buttonList)
            {
                flowLayoutPanel.Controls.Remove(button);
                button.Dispose(); 
            }
            buttonList.Clear();
        }
        private void ConfigureButton(Button btn)
        {
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.TextImageRelation = TextImageRelation.ImageAboveText;
        }

        private void CrearFicheroDirectorio(string title, Action<string> callbackDeCreacion)
        {
            CreadorFicheroDirectorioForm creadorFicheroDirectorio = new CreadorFicheroDirectorioForm(this, callbackDeCreacion);
            creadorFicheroDirectorio.cambiarTitle(title);
            creadorFicheroDirectorio.ShowDialog();
        }

        private void cREARFICHEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFicheroDirectorio("Crear Fichero", ActualizarAbrirForm);
        }
        private void ActualizarAbrirForm(string nuevaRuta)
        {
            CargarCosas(nuevaRuta);
        }
        private void cREARCARPETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFicheroDirectorio("Create Directory", ActualizarAbrirForm);
        }

        private void flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                menuClickDerecho.Show(this, (e as MouseEventArgs).Location);
            }
        }

        private void createFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFicheroDirectorio("Create Fichero",null);
        }

        private void createDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFicheroDirectorio("Create Directory",null);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (directorioActual != directorioRaiz)
            {
                string directorioPadre = Path.GetDirectoryName(directorioActual);

                if (Directory.Exists(directorioPadre))
                {
                    directorioActual = directorioPadre;
                    CargarCosas(directorioActual);
                    this.Text = $"Directorio actual: {Path.GetFileName(directorioActual)}";
                }
                else
                {
                    MessageBox.Show("Ya estás en el directorio raíz.");
                }
            }
            else
            {
                MessageBox.Show("Ya estás en el directorio raíz.");
            }
        }
    }
 }



