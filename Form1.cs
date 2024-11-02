using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Lec1
{
    public partial class Form1 : Form
    {

        private double firstOperand = 0;
        private double secondOperand = 0;
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnClick_Click(object sender, EventArgs e)
        {
            //string msg = txtmsg.Text;
            //MessageBox.Show(msg);

            //MessageBox.Show("Button Texting");
            //label2.Text = msg;
            //txtmsg.Text = label2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            txtmsg.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtmsg.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtmsg.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtmsg.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtmsg.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtmsg.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtmsg.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtmsg.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtmsg.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtmsg.Text = "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            txtmsg.Text = ".";
        }

        private void btn_isEqual_Click(object sender, EventArgs e)
        {


            if (double.TryParse(txtmsg.Text, out secondOperand))
            {
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = firstOperand + secondOperand;
                        break;
                    case "-":
                        result = firstOperand - secondOperand;
                        break;
                    case "*":
                        result = firstOperand * secondOperand;
                        break;
                    case "/":
                        if (secondOperand != 0)
                        {
                            result = firstOperand / secondOperand;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        break;
                    case "%":
                        result = firstOperand % secondOperand;
                        break;
                }
                txtmsg.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Input string was not in a correct format.");
            }

           

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            
            firstOperand =double.Parse(txtmsg.Text);
            operation = "-";
            txtmsg.Clear();

        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            
            firstOperand = double.Parse(txtmsg.Text);
            operation = "*";
            txtmsg.Clear();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(txtmsg.Text);
            operation = "+";

            txtmsg.Clear();
        }

        private void btn_bck_space_Click(object sender, EventArgs e)
        {
            if (txtmsg.Text.Length > 0)  
            {
                txtmsg.Text = txtmsg.Text.Substring(0, txtmsg.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(txtmsg.Text);
            operation = "/";
            txtmsg.Clear();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(txtmsg.Text);
            operation = "%";
            txtmsg.Clear();

        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            txtmsg.Text = "";
        }
    }
}
