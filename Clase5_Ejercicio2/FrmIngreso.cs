using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase5_Entidades;
namespace Clase5_Ejercicio2
{
    public partial class FrmIngreso : Form
    {
        Ingresante? ingresante1 = Form1.ingresante1;
        public FrmIngreso()
        {
            InitializeComponent();
        }

        public FrmIngreso(Ingresante ingresante):this()
        {
           // this.ingresante1 = ingresante;
        }
        private void FrmIngreso_Load(object sender, EventArgs e)
        {
           Form1 form = new Form1();
           lblInformacion.Text = ingresante1.Mostrar();
        }
        private void lblInformacion_Click(object sender, EventArgs e)
        {
           
        }
    }
}
