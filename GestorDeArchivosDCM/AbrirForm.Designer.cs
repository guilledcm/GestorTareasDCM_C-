namespace GestorDeArchivosDCM
{
    partial class AbrirForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel = new FlowLayoutPanel();
            menuClickDerecho = new ContextMenuStrip(components);
            cREARFICHEROToolStripMenuItem = new ToolStripMenuItem();
            cREARCARPETAToolStripMenuItem = new ToolStripMenuItem();
            menuClickDerecho.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(800, 450);
            flowLayoutPanel.TabIndex = 0;
            flowLayoutPanel.Click += rightClick;
            // 
            // menuClickDerecho
            // 
            menuClickDerecho.Items.AddRange(new ToolStripItem[] { cREARFICHEROToolStripMenuItem, cREARCARPETAToolStripMenuItem });
            menuClickDerecho.Name = "menuClickDerecho";
            menuClickDerecho.Size = new Size(181, 70);
            // 
            // cREARFICHEROToolStripMenuItem
            // 
            cREARFICHEROToolStripMenuItem.Name = "cREARFICHEROToolStripMenuItem";
            cREARFICHEROToolStripMenuItem.Size = new Size(180, 22);
            cREARFICHEROToolStripMenuItem.Text = "CREAR FICHERO";
            cREARFICHEROToolStripMenuItem.Click += cREARFICHEROToolStripMenuItem_Click;
            // 
            // cREARCARPETAToolStripMenuItem
            // 
            cREARCARPETAToolStripMenuItem.Name = "cREARCARPETAToolStripMenuItem";
            cREARCARPETAToolStripMenuItem.Size = new Size(180, 22);
            cREARCARPETAToolStripMenuItem.Text = "CREAR CARPETA";
            cREARCARPETAToolStripMenuItem.Click += cREARCARPETAToolStripMenuItem_Click;
            // 
            // AbrirForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel);
            Name = "AbrirForm";
            Text = "AbrirForm";
            Load += AbrirForm_Load;
            menuClickDerecho.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private ContextMenuStrip menuClickDerecho;
        private ToolStripMenuItem cREARFICHEROToolStripMenuItem;
        private ToolStripMenuItem cREARCARPETAToolStripMenuItem;
    }
}