using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace FutureMoneyValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate(double cc)
        {

            try //tests all of the input to make sure there are only numbers inputed
            {
                //Convert all text entries from strings to double
                double iv = double.Parse(IVBox1.Text);
                double ir = double.Parse(IRBox2.Text);
                double ny = double.Parse(NYBox3.Text);
                double pyc = cc;


                //Calculation for future value
                double p = (1 + (0.01 * ir));
                double c = ny * pyc;
                double pw = Math.Pow(p, c); //function used to raise to a power
                double fv = iv * pw;

                //Convert answer back to string
                string Answer = fv.ToString();
                FIVBox5.Text = Answer;
            }
            catch (System.FormatException)
            {
                //Clears all of the boxes
                IVBox1.Text = "";
                IRBox2.Text = "";
                NYBox3.Text = "";

                //Opens Error Window (Form2)
                var error = new Form2();
                error.Show(this);
            }

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //pass Calculate the double 365 representing compounded daily
        private void dailyButton_Click(object sender, EventArgs e)

        {
           
            double cc = 365;
            Calculate(cc);
          
        }

        //pass Calculate the double 52 representing compounded weekly
        private void weekButton_Click(object sender, EventArgs e)
        {
            double cc = 52;
            Calculate(cc);
        }

        //pass Calculate the double 12 representing compounded monthly
        private void monthButton_Click(object sender, EventArgs e)
        {
            double cc = 12;
            Calculate(cc);
        }

        //pass Calculate the double 4 representing compounded quarterly
        private void quarterButton_Click(object sender, EventArgs e)
        {
            double cc = 4;
            Calculate(cc);
        }

        //pass Calculate the double 2 representing compounded biannually
        private void biannualButton_Click(object sender, EventArgs e)
        {
            double cc = 2;
            Calculate(cc);
        }

        //pass Calculate the double 1 representing compounded yearly
        private void yearButton_Click(object sender, EventArgs e)
        {
            double cc = 1;
            Calculate(cc);
        }


    }
}
