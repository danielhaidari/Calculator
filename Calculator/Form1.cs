using Multiplication;  // Your DLL namespace
using Subtraction;

using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
      
        Class1 multiplier = new Class1();
        Substractor subtractor = new Substractor();


        public Form1()
        {
            InitializeComponent();

   
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (double.TryParse(textBox1.Text, out double val)) sum += val;
            if (double.TryParse(textBox2.Text, out val)) sum += val;
            if (double.TryParse(textBox3.Text, out val)) sum += val;
            if (double.TryParse(textBox4.Text, out val)) sum += val;
            if (double.TryParse(textBox5.Text, out val)) sum += val;
            if (double.TryParse(textBox6.Text, out val)) sum += val;
            if (double.TryParse(textBox7.Text, out val)) sum += val;
            if (double.TryParse(textBox8.Text, out val)) sum += val;
            if (double.TryParse(textBox9.Text, out val)) sum += val;

            if (sum == 0)
                label2.Text = "Please enter at least one number.";
            else
                label2.Text = "Sum: " + sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double product = multiplier.Multiply(num1, num2);
                label2.Text = "Product: " + product.ToString();
            }
            else
            {
                label2.Text = "Please enter valid numbers in TextBox1 and TextBox2.";
            }
        }

        private void button3_Click(object sender, EventArgs e)  
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double difference = subtractor.Subtract(num1, num2);
                label2.Text = "Difference: " + difference.ToString();
            }
            else
            {
                label2.Text = "Enter valid numbers in TextBox1 and TextBox2.";
            }
        }
    }
}
