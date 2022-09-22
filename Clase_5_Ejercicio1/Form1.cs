using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_5_Ejercicio1
{
    public partial class Frm_Ejercicio1 : Form
    {
        public Frm_Ejercicio1()
        {
            InitializeComponent();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {

            if (Validador())
            {
                FrmSaludar frmSaludar = new FrmSaludar(txt_nombre.Text, txt_apellido.Text, cmbMateria.Text);
                frmSaludar.Show();
            }
        }

        private void Frm_Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_apellido_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbMateria.Items.Add("Programación I");
            cmbMateria.Items.Add("Laboratorio de Computación I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Inglés I");
            cmbMateria.Items.Add("Matemática");
            cmbMateria.Items.Add("Programación II");
            cmbMateria.Items.Add("Laboratorio de Computación II");
            cmbMateria.Items.Add("Inglés II");
            cmbMateria.Items.Add("Metodología de la investigación");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estadística");
        }


        private bool Validador ()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("Se deben completar los siguientes campos:");
            if (String.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                sb.AppendLine("Nombre");
                esValido=false;
            }


            if (String.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                sb.AppendLine("Apellido");
                esValido = false;
            }


            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;

        }
    }
}
