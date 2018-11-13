using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc_1._0.Controle;

namespace Calc_1._0
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        Operacao operacao;
        double num1, num2;

        public string AddNumber(string visor, double num)
        {
            if (visor != "0")
            {
                visor += Convert.ToString(num);
                return visor;
            }
            else
            {
                return Convert.ToString(num);
            }
        }


        private void visor_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 3);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            visor.Text = AddNumber(visor.Text, 0);
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            visor.Text += ",";
            btnPoint.Enabled = false;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operacao = new Plus();
            num1 = Convert.ToDouble(visor.Text);
            visor.Text = "0";
            btnResult.Enabled = true;
            btnPoint.Enabled = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operacao = new Minus();
            num1 = Convert.ToDouble(visor.Text);
            visor.Text = "0";
            btnResult.Enabled = true;
            btnPoint.Enabled = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operacao = new Multiply();
            num1 = Convert.ToDouble(visor.Text);
            visor.Text = "0";
            btnResult.Enabled = true;
            btnPoint.Enabled = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operacao = new Divide();
            num1 = Convert.ToDouble(visor.Text);
            visor.Text = "0";
            btnResult.Enabled = true;
            btnPoint.Enabled = true;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(visor.Text);
            operacao = new Square();
            visor.Text = Convert.ToString(operacao.Resultado(num1, 0));
        }

        private void visor_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(visor.Text);
            visor.Text = Convert.ToString(operacao.Resultado(num1, num2));
            btnResult.Enabled = false;
            btnPoint.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btnPoint.Enabled = true;
            visor.Text = "0";
            num1 = 0;
            num2 = 0;
        }
    }
}
