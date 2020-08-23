using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoundationClass
{
    public partial class Frmdoit : Form
    {
        public Frmdoit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdoAdd.Checked==true){

                int num1 = Convert.ToInt16(txtNum1.Text);
                int num2 = Convert.ToInt16(txtNum2.Text);

                int result = num1 + num2;

                txtNum3.Text = result.ToString();
            }

            else if (rdoSub.Checked == true)
            {
                int num1 = Convert.ToInt16(txtNum1.Text);
                int num2 = Convert.ToInt16(txtNum2.Text);

                int result = num1 - num2;

                txtNum3.Text = result.ToString();
            }

            else if(rdoMul.Checked==true)
            {
                int num1 = Convert.ToInt16(txtNum1.Text);
                int num2 = Convert.ToInt16(txtNum2.Text);

                int result = num1 * num2;

                txtNum3.Text = result.ToString();
            }

            else if(rdoDiv.Checked)
            {
                int num1 = Convert.ToInt16(txtNum1.Text);
                int num2 = Convert.ToInt16(txtNum2.Text);

                int result = num1 / num2;

                txtNum3.Text = result.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}