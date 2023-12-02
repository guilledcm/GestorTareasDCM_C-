namespace GestorDCM
{
    partial class AboutForm
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
            panelTop = new Panel();
            pictureBox = new PictureBox();
            panelBot = new Panel();
            lblTextInfo = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBox);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(800, 450);
            panelTop.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Image = Properties.Resources.imagenMeme;
            pictureBox.Location = new Point(-67, -68);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(922, 518);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(lblTextInfo);
            panelBot.Dock = DockStyle.Bottom;
            panelBot.Location = new Point(0, 350);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(800, 100);
            panelBot.TabIndex = 1;
            // 
            // lblTextInfo
            // 
            lblTextInfo.Anchor = AnchorStyles.None;
            lblTextInfo.AutoSize = true;
            lblTextInfo.Location = new Point(268, 33);
            lblTextInfo.Name = "lblTextInfo";
            lblTextInfo.Size = new Size(269, 30);
            lblTextInfo.TabIndex = 0;
            lblTextInfo.Text = "progama hecho por GUILLERMO de carlos muñoz\r\nesta es la segunda parte\r\n";
            lblTextInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBot);
            Controls.Add(panelTop);
            Name = "AboutForm";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private PictureBox pictureBox;
        private Panel panelBot;
        private Label lblTextInfo;
    }
}