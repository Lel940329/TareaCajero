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
    public partial class Form4 : Form
    {
        public Form4(double Balance)
        {
            InitializeComponent();
            this.balance = Balance;
            
            
            label3.Text = balance.ToString();
        }
        double balance;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fi = new Form2(balance);
            fi.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
