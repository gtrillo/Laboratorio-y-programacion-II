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
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        public FrmSaludar(string nombre, string apellido, string materiaFav):this()
        {
            lblSaludar.Text = "Soy " + nombre + " " + apellido + " mi materia preferida es " + materiaFav + ".";
        }

        private void FrmSaludar_Load(object sender, EventArgs e)
        {
        }

        private void lblSaludar_Click(object sender, EventArgs e)
        {

        }
    }
}
