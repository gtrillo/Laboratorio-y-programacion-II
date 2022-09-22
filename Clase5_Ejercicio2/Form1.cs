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
    public partial class Form1 : Form
    {
        public static Ingresante? ingresante1;

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        { 
           
        }
        public static Ingresante? GetIngresante
        {
            get { return ingresante1; }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresante1 = new Ingresante(gbxCursos.Text, txtDireccion.Text, (int)nmrEdad.Value, gbxGenero.Text, txtNombre.Text, listBox1.Text);
            //FrmIngreso frIngreso = new FrmIngreso(ingresante1);
            FrmIngreso frIngreso = new FrmIngreso();
            frIngreso.Show();
        }
    }
}
