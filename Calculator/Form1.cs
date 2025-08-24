using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;

            if (textBox1.Text != "")
                sum += Convert.ToDouble(textBox1.Text);
            if (textBox2.Text != "")
                sum += Convert.ToDouble(textBox2.Text);
            if (textBox3.Text != "")
                sum += Convert.ToDouble(textBox3.Text);
            if (textBox4.Text != "")
                sum += Convert.ToDouble(textBox4.Text);
            if (textBox5.Text != "")
                sum += Convert.ToDouble(textBox5.Text);
            if (textBox6.Text != "")
                sum += Convert.ToDouble(textBox6.Text);
            if (textBox7.Text != "")
                sum += Convert.ToDouble(textBox7.Text);
            if (textBox8.Text != "")
                sum += Convert.ToDouble(textBox8.Text);
            if (textBox9.Text != "")
                sum += Convert.ToDouble(textBox9.Text);
          

            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" &&
                textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" &&
                textBox9.Text == "")
            {
                label1.Text = "Please enter at least one number.";
            }
            else
            {
                label1.Text = "Sum: " + sum.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
