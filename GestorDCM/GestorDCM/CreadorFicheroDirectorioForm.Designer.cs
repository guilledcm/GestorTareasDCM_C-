namespace GestorDCM
{
    partial class CreadorFicheroDirectorioForm
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
            lblTittle = new Label();
            panelBot = new Panel();
            btnCancel = new Button();
            btnCreate = new Button();
            textBox = new TextBox();
            lblNombre = new Label();
            panelTop.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Firebrick;
            panelTop.Controls.Add(lblTittle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(487, 59);
            panelTop.TabIndex = 0;
            // 
            // lblTittle
            // 
            lblTittle.Dock = DockStyle.Fill;
            lblTittle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittle.Location = new Point(0, 0);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(487, 59);
            lblTittle.TabIndex = 0;
            lblTittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(btnCancel);
            panelBot.Controls.Add(btnCreate);
            panelBot.Controls.Add(textBox);
            panelBot.Controls.Add(lblNombre);
            panelBot.Dock = DockStyle.Fill;
            panelBot.Location = new Point(0, 59);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(487, 241);
            panelBot.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(62, 174);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 44);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ActiveCaption;
            btnCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(314, 174);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 44);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(139, 111);
            textBox.Name = "textBox";
            textBox.Size = new Size(195, 23);
            textBox.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(190, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
            // 
            // CreadorFicheroDirectorioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 300);
            Controls.Add(panelBot);
            Controls.Add(panelTop);
            MaximizeBox = false;
            Name = "CreadorFicheroDirectorioForm";
            panelTop.ResumeLayout(false);
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        public Label lblTittle;
        private Panel panelBot;
        private Button btnCreate;
        public TextBox textBox;
        private Label lblNombre;
        private Button btnCancel;
    }
}