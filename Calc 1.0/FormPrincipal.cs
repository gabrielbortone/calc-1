using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_1._0
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        string visor_aux;
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

        private void button13_Click(object sender, EventArgs e)
        {
            btnPoint.Enabled = true;
            visor.Text = "0";
            visor_aux = "";
            num1 = 0;
            num2 = 0;
        }
    }
}
