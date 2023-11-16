namespace GestorDeArchivosDCM
{
    partial class CreadorFicheroDirectorio
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
            panel1 = new Panel();
            lblTittle = new Label();
            panel2 = new Panel();
            lblNombre = new Label();
            textBox = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(lblTittle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 37);
            panel1.TabIndex = 0;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Dock = DockStyle.Fill;
            lblTittle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittle.Location = new Point(0, 0);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(109, 37);
            lblTittle.TabIndex = 0;
            lblTittle.Text = "blabla";
            lblTittle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(textBox);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 381);
            panel2.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(142, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 25);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "NOMBRE:";
            // 
            // textBox
            // 
            textBox.Location = new Point(88, 133);
            textBox.Name = "textBox";
            textBox.Size = new Size(211, 23);
            textBox.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.PowderBlue;
            btnCreate.Location = new Point(283, 257);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(87, 37);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(22, 257);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 37);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreadorFicheroDirectorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(401, 418);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CreadorFicheroDirectorio";
            Text = "CreadorFicheroDirectorio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblNombre;
        private TextBox textBox;
        private Button btnCreate;
        private Button btnCancel;
        private Label lblTittle;
    }
}