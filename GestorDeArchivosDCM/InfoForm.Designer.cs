namespace GestorDeArchivosDCM
{
    partial class InfoForm
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
            panelBajo = new Panel();
            panelArriba = new Panel();
            pictureBox = new PictureBox();
            textInfo = new Label();
            panelBajo.SuspendLayout();
            panelArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelBajo
            // 
            panelBajo.BackColor = SystemColors.ActiveCaption;
            panelBajo.Controls.Add(textInfo);
            panelBajo.Dock = DockStyle.Bottom;
            panelBajo.Location = new Point(0, 358);
            panelBajo.Name = "panelBajo";
            panelBajo.Size = new Size(606, 100);
            panelBajo.TabIndex = 0;
            // 
            // panelArriba
            // 
            panelArriba.BackColor = SystemColors.ActiveCaption;
            panelArriba.Controls.Add(pictureBox);
            panelArriba.Dock = DockStyle.Fill;
            panelArriba.Location = new Point(0, 0);
            panelArriba.Name = "panelArriba";
            panelArriba.Size = new Size(606, 358);
            panelArriba.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Enabled = false;
            pictureBox.Image = Properties.Resources.imagenAbout;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(606, 358);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // textInfo
            // 
            textInfo.Dock = DockStyle.Fill;
            textInfo.Location = new Point(0, 0);
            textInfo.Name = "textInfo";
            textInfo.Size = new Size(606, 100);
            textInfo.TabIndex = 0;
            textInfo.Text = "Esta aplicación ha sido diseñada por Guillermo de Carlos Muñoz.\r\nMASTER OF C#.\r\nGestor de archivos DCM >>>> Gestor de archivos de Windows.\r\n";
            textInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 458);
            Controls.Add(panelArriba);
            Controls.Add(panelBajo);
            Name = "InfoForm";
            Text = "About";
            panelBajo.ResumeLayout(false);
            panelArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBajo;
        private Panel panelArriba;
        private PictureBox pictureBox;
        private Label textInfo;
    }
}