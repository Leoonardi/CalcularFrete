using CalcularFrete.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete.View
{
    public partial class TelaFrente : Form
    {
        Frete frete = new Frete();
        public TelaFrente()
        {
            InitializeComponent();
        }

        private void  btnCalcular_Click(object sender, EventArgs e)
        {

            if (cBUF.Text == string.Empty && txtvalor.Text == string.Empty || txtcliente.Text == string.Empty) 
            {
                MessageBox.Show("Alguns campos não foram preenchidos");

            }
            else

            {


                string uf = cBUF.Text;
                decimal v = Convert.ToDecimal(txtvalor.Text);
                decimal vfrete = frete.calcular(uf, v);
                decimal total = vfrete + v;
                txtfrete.Text = vfrete.ToString();


                decimal uffrete = (vfrete / total);
                txtfrete.Text = uffrete.ToString("P1");

                lblResultado.Text = "estado: R$ " + uf +
                    "\nValor do produto: R$ " + vfrete +
                    "\nValor do frete: R$ " + vfrete +
                    "\nValor do total: R$ " + total.ToString("n2");
            }
        }
    }
}
