using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5_Ejercicio1
{
    public partial class frm_ejercicio1 : Form
    {
        public frm_ejercicio1()
        {
            InitializeComponent();
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            MessageBox.Show($"Hola mi nombre es {nombre} {apellido}");
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
