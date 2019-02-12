using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FutureMoneyValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Convert all text entries from strings to double
            double iv = Double.Parse(IVBox1.Text);
            double ir = double.Parse(IRBox2.Text);
            double ny = double.Parse(NYBox3.Text);
            double pyc = double.Parse(PYCBox4.Text);

            //Calculation for future value
            double p = (1 + (0.01 * ir));
            double c = ny * pyc;
            double pw = Math.Pow(p, c);
            double fv = iv * pw;
            
            //Convert answer back to string
            string Answer = fv.ToString();
            FIVBox5.Text = Answer;

            //MessageBox.Show("All Done!");
        }

        private void FutureMoneyValueLable_OnClick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitialInvestmentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
