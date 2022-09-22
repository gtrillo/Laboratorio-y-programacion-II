namespace Clase5_Ejercicio2
{
    partial class Form1
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
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.nmrEdad = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.cbxMasculino = new System.Windows.Forms.CheckBox();
            this.cbxFemenino = new System.Windows.Forms.CheckBox();
            this.cbxNoBinario = new System.Windows.Forms.CheckBox();
            this.gbxCursos = new System.Windows.Forms.GroupBox();
            this.cbxJavaScrip = new System.Windows.Forms.CheckBox();
            this.cbxCPlusPlus = new System.Windows.Forms.CheckBox();
            this.cbxCSharp = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.gbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEdad)).BeginInit();
            this.gbxGenero.SuspendLayout();
            this.gbxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Controls.Add(this.nmrEdad);
            this.gbxDetalles.Controls.Add(this.txtNombre);
            this.gbxDetalles.Controls.Add(this.txtDireccion);
            this.gbxDetalles.Controls.Add(this.label3);
            this.gbxDetalles.Controls.Add(this.label2);
            this.gbxDetalles.Controls.Add(this.lblNombre);
            this.gbxDetalles.Location = new System.Drawing.Point(46, 39);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Size = new System.Drawing.Size(336, 239);
            this.gbxDetalles.TabIndex = 0;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles del usuario";
            // 
            // nmrEdad
            // 
            this.nmrEdad.Location = new System.Drawing.Point(145, 189);
            this.nmrEdad.Name = "nmrEdad";
            this.nmrEdad.Size = new System.Drawing.Size(180, 31);
            this.nmrEdad.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(175, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 31);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(175, 126);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(150, 31);
            this.txtDireccion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.cbxMasculino);
            this.gbxGenero.Controls.Add(this.cbxFemenino);
            this.gbxGenero.Controls.Add(this.cbxNoBinario);
            this.gbxGenero.Location = new System.Drawing.Point(488, 46);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Size = new System.Drawing.Size(231, 172);
            this.gbxGenero.TabIndex = 6;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Text = "Genero";
            // 
            // cbxMasculino
            // 
            this.cbxMasculino.AutoSize = true;
            this.cbxMasculino.Location = new System.Drawing.Point(53, 42);
            this.cbxMasculino.Name = "cbxMasculino";
            this.cbxMasculino.Size = new System.Drawing.Size(118, 29);
            this.cbxMasculino.TabIndex = 0;
            this.cbxMasculino.Text = "Masculino";
            this.cbxMasculino.UseVisualStyleBackColor = true;
            // 
            // cbxFemenino
            // 
            this.cbxFemenino.AutoSize = true;
            this.cbxFemenino.Location = new System.Drawing.Point(53, 77);
            this.cbxFemenino.Name = "cbxFemenino";
            this.cbxFemenino.Size = new System.Drawing.Size(116, 29);
            this.cbxFemenino.TabIndex = 1;
            this.cbxFemenino.Text = "Femenino";
            this.cbxFemenino.UseVisualStyleBackColor = true;
            // 
            // cbxNoBinario
            // 
            this.cbxNoBinario.AutoSize = true;
            this.cbxNoBinario.Location = new System.Drawing.Point(53, 112);
            this.cbxNoBinario.Name = "cbxNoBinario";
            this.cbxNoBinario.Size = new System.Drawing.Size(122, 29);
            this.cbxNoBinario.TabIndex = 2;
            this.cbxNoBinario.Text = "No binario";
            this.cbxNoBinario.UseVisualStyleBackColor = true;
            // 
            // gbxCursos
            // 
            this.gbxCursos.Controls.Add(this.cbxJavaScrip);
            this.gbxCursos.Controls.Add(this.cbxCPlusPlus);
            this.gbxCursos.Controls.Add(this.cbxCSharp);
            this.gbxCursos.Location = new System.Drawing.Point(488, 239);
            this.gbxCursos.Name = "gbxCursos";
            this.gbxCursos.Size = new System.Drawing.Size(231, 135);
            this.gbxCursos.TabIndex = 0;
            this.gbxCursos.TabStop = false;
            this.gbxCursos.Text = "Cursos";
            // 
            // cbxJavaScrip
            // 
            this.cbxJavaScrip.AutoSize = true;
            this.cbxJavaScrip.Location = new System.Drawing.Point(63, 95);
            this.cbxJavaScrip.Name = "cbxJavaScrip";
            this.cbxJavaScrip.Size = new System.Drawing.Size(110, 29);
            this.cbxJavaScrip.TabIndex = 2;
            this.cbxJavaScrip.Text = "JavaScrip";
            this.cbxJavaScrip.UseVisualStyleBackColor = true;
            // 
            // cbxCPlusPlus
            // 
            this.cbxCPlusPlus.AutoSize = true;
            this.cbxCPlusPlus.Location = new System.Drawing.Point(63, 60);
            this.cbxCPlusPlus.Name = "cbxCPlusPlus";
            this.cbxCPlusPlus.Size = new System.Drawing.Size(73, 29);
            this.cbxCPlusPlus.TabIndex = 1;
            this.cbxCPlusPlus.Text = "C++";
            this.cbxCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // cbxCSharp
            // 
            this.cbxCSharp.AutoSize = true;
            this.cbxCSharp.Location = new System.Drawing.Point(63, 25);
            this.cbxCSharp.Name = "cbxCSharp";
            this.cbxCSharp.Size = new System.Drawing.Size(60, 29);
            this.cbxCSharp.TabIndex = 0;
            this.cbxCSharp.Text = "C#";
            this.cbxCSharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(607, 404);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(112, 34);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Paraguay"});
            this.listBox1.Location = new System.Drawing.Point(46, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 129);
            this.listBox1.TabIndex = 8;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(46, 281);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(42, 25);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "País";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.gbxCursos);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.gbxDetalles);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxDetalles.ResumeLayout(false);
            this.gbxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEdad)).EndInit();
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            this.gbxCursos.ResumeLayout(false);
            this.gbxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.NumericUpDown nmrEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.CheckBox cbxMasculino;
        private System.Windows.Forms.CheckBox cbxFemenino;
        private System.Windows.Forms.CheckBox cbxNoBinario;
        private System.Windows.Forms.GroupBox gbxCursos;
        private System.Windows.Forms.CheckBox cbxJavaScrip;
        private System.Windows.Forms.CheckBox cbxCPlusPlus;
        private System.Windows.Forms.CheckBox cbxCSharp;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPais;
    }
}
