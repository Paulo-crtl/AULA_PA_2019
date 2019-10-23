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
        double V1, V2, R;
        char op;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void B0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Mais_Click(object sender, EventArgs e)
        {
            V1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            op = '+';
        
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            V1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            op = '-';
        }

        private void Vezes_Click(object sender, EventArgs e)
        {
            V1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            op = 'X';
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            V1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            op = ':';
        }

        private void Igual_Click(object sender, EventArgs e)
        {
                V2 = double.Parse(textBox1.Text);
            switch(op)
            {
                case'+':
                R =+ V1 + V2;
                break;
                case '-':
                R = V1 - V2;
                break;
                case 'X':
                R = V1 * V2;
                break;
                case':':
                    if(V2 == 0)
                    {
                        MessageBox.Show("ERRO 00000045400");
                    }
                    else
                    {
                        R = V1 / V2;
                    }
                    break;
            }
            textBox1.Clear();
            textBox1.Text = R.ToString();
         }

    }
}
