using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeCounter
{
    public partial class Form1 : Form
    {

        const decimal FIVE_CENTS_VALUE = 0.05M;
        const decimal TEN_CENTS_VALUE = 0.10M;
        const decimal TWENTY_CENTS_VALUE = 0.25M;
        const decimal FIFTY_CENTS_VALUE = 0.50M;

        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS_VALUE;
            label3.Text = total.ToString("c");
          

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;
            label3.Text = total.ToString("c");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            total += TWENTY_CENTS_VALUE;
            label3.Text = total.ToString("c");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            total += FIFTY_CENTS_VALUE;
            label3.Text = total.ToString("c");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
