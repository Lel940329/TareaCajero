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
    public partial class Form2 : Form
    {
        public Form2(double Balance)
        {
            InitializeComponent();
            this.balance = Balance;
        }
        double balance;
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fo = new Form4(balance);
            fo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fi = new Form3(balance);
            fi.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
