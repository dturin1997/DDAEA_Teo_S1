using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDAEA_Teo_S1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string edad = "";
            if (checkBox1.Checked)
            {
                edad = "Es mayor de edad";
            }else
            {
                edad = "No es mayor de edad";
            }
            MessageBox.Show("Bienvenido a Tecsup "+txtNombre.Text+" "+edad);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {

        }
    }
}
