using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
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

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            int valor1, valor2, valorSomado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            valorSomado = valor1 + valor2;

            label4.Text = Convert.ToString(valorSomado);

            MessageBox.Show("Total " + Convert.ToString(valorSomado),"Resultado da soma");
        }

        private void BtnDobro_Click(object sender, EventArgs e)
        {
            int valor1, valorDobrado;

            valor1 = Convert.ToInt32(textBox1.Text);

            valorDobrado = valor1 * 2;

            label4.Text = Convert.ToString(valorDobrado);

            MessageBox.Show("Total " + Convert.ToString(valorDobrado), "Resultado dobrado");
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, valorMultiplicado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            valorMultiplicado = valor1 * valor2;

            label4.Text = Convert.ToString(valorMultiplicado);

            MessageBox.Show("Total " + Convert.ToString(valorMultiplicado), "Resultado multiplicado");
        }
    }
}
