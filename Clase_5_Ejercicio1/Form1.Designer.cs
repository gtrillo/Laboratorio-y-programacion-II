namespace Clase_5_Ejercicio1
{
    partial class Frm_Ejercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_saludar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(479, 285);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(110, 34);
            this.btn_saludar.TabIndex = 1;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(117, 98);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(78, 25);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            this.lbl_nombre.Click += new System.EventHandler(this.lbl_nombre_Click);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(352, 98);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(78, 25);
            this.lbl_apellido.TabIndex = 3;
            this.lbl_apellido.Text = "Apellido";
            this.lbl_apellido.Click += new System.EventHandler(this.lbl_apellido_Click);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(352, 137);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(150, 31);
            this.txt_apellido.TabIndex = 4;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(117, 137);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 31);
            this.txt_nombre.TabIndex = 5;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "Programación I",
            "Laboratorio de Computación I",
            "Sistema de procesamiento de datos",
            "Inglés I",
            "Matemática",
            "Programación II",
            "Laboratorio de Computación II",
            "Inglés II",
            "Metodología de la investigación",
            "Arquitectura y sistemas operativos",
            "Estadística"});
            this.cmbMateria.Location = new System.Drawing.Point(13, 213);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(329, 33);
            this.cmbMateria.TabIndex = 6;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Frm_Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 331);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_saludar);
            this.Name = "Frm_Ejercicio1";
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Frm_Ejercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmbMateria;
    }
}
