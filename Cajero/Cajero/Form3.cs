using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    
    public partial class Form3 : Form
    {
        validacion n = new validacion();
        public Form3(double Balance)
        {
            InitializeComponent();
            this.balance = Balance;
        }
        double balance;
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (balance > 0)
            {
                balance = balance - 100;
                if (balance < 0)
                {
                    MessageBox.Show("No cuenta con fondos suficientes");
                    balance = balance - 100;
                }
                else
                {
                    MessageBox.Show("Por favor retire su dinero");
                }
            }
            else
            {
                MessageBox.Show("no cuenta con fondos disponibles");
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (balance > 0)
            {
                balance = balance - 200;
                if (balance < 0)
                {
                    MessageBox.Show("No cuenta con fondos suficientes");
                    balance = balance - 200;
                }
                else
                {
                    MessageBox.Show("Por favor retire su dinero");
                }
            }
            else
            {
                MessageBox.Show("no cuenta con fondos disponibles");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (balance > 0)
            {
                balance = balance - 500;
                if (balance < 0)
                {
                    MessageBox.Show("No cuenta con fondos suficientes");
                    balance = balance - 500;
                }
                else
                {
                    MessageBox.Show("Por favor retire su dinero");
                }
            }
            else
            {
                MessageBox.Show("no cuenta con fondos disponibles");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (balance > 0)
            {

                balance = balance - 1000;
                if (balance < 0)
                {
                    MessageBox.Show("No cuenta con fondos suficientes");
                    balance = balance - 1000;
                }
                else
                {
                    MessageBox.Show("Por favor retire su dinero");
                }
            }
            else
            {
                MessageBox.Show("no cuenta con fondos disponibles");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Form2 fi = new Form2(balance);
            fi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            double b = double.Parse(textBox1.Text);
            double c = b % 1000;
            c = c % 500;
            c = c % 200;
            c = c % 100;
            if (c == 0)
            {
                if (balance > 0)
                {
                    if (textBox1.Text != "")
                    {
                        double a = balance;
                        a = balance - double.Parse(textBox1.Text);
                        if (a < 0)
                        {
                            MessageBox.Show("No cuenta con fondos suficientes");

                        }
                        else
                        {
                            MessageBox.Show("Por favor retire su dinero");
                            balance = balance - double.Parse(textBox1.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite una cantidad");
                    }
                }
                else
                {
                    MessageBox.Show("no cuenta con fondos disponibles");
                }
            }
            else {
                MessageBox.Show("El cajero no tienes monedas o billetes de 50, DIGITE OTRA CANTIDAD");
            }
            textBox1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.leer(e);
        }
    }
}
