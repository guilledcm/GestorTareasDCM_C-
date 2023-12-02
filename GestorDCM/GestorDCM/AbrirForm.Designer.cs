namespace GestorDCM
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
            createFicheroToolStripMenuItem = new ToolStripMenuItem();
            createDirectoryToolStripMenuItem = new ToolStripMenuItem();
            pictureBox = new PictureBox();
            flowLayoutPanel.SuspendLayout();
            menuClickDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(pictureBox);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(800, 450);
            flowLayoutPanel.TabIndex = 0;
            flowLayoutPanel.Click += flowLayoutPanel_Click;
            // 
            // menuClickDerecho
            // 
            menuClickDerecho.Items.AddRange(new ToolStripItem[] { createFicheroToolStripMenuItem, createDirectoryToolStripMenuItem });
            menuClickDerecho.Name = "menuClickDerechi";
            menuClickDerecho.Size = new Size(160, 48);
            // 
            // createFicheroToolStripMenuItem
            // 
            createFicheroToolStripMenuItem.Name = "createFicheroToolStripMenuItem";
            createFicheroToolStripMenuItem.Size = new Size(159, 22);
            createFicheroToolStripMenuItem.Text = "Create Fichero";
            createFicheroToolStripMenuItem.Click += createFicheroToolStripMenuItem_Click;
            // 
            // createDirectoryToolStripMenuItem
            // 
            createDirectoryToolStripMenuItem.Name = "createDirectoryToolStripMenuItem";
            createDirectoryToolStripMenuItem.Size = new Size(159, 22);
            createDirectoryToolStripMenuItem.Text = "Create Directory";
            createDirectoryToolStripMenuItem.Click += createDirectoryToolStripMenuItem_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Image = Properties.Resources.atras;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(60, 60);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // AbrirForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel);
            Name = "AbrirForm";
            flowLayoutPanel.ResumeLayout(false);
            menuClickDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private ContextMenuStrip menuClickDerecho;
        private ToolStripMenuItem createFicheroToolStripMenuItem;
        private ToolStripMenuItem createDirectoryToolStripMenuItem;
        private PictureBox pictureBox;
    }
}