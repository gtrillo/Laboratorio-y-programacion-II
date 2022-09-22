using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase6_Ejercicio3
{
    public partial class Form1 : Form
    {
        Dictionary <string,string> palabras = new Dictionary <string,string> ();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string cadena = rtbPalabras.Text;
            string[] palabras = cadena.Split(" ");
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            foreach(string palabra in palabras)
            {
                if (!diccionario.ContainsKey(palabra))
                {
                    diccionario.Add(palabra,1);
                }
                else
                {
                    diccionario[palabra]++;
                }
            }
        }
    }
}
