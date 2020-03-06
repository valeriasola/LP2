using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRaio_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, altura;
            if ((double.TryParse(txtRaio.Text, out raio) &&
                double.TryParse(txtAltura.Text, out altura)))
            {

                double volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtVolume.Text = volume.ToString("N2");


            }
            else
                MessageBox.Show("Dados Inválidos!");
        }
         
    }
}
