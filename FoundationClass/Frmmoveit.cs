using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoundationClass
{
    public partial class Frmmoveit : Form
    {
        public Frmmoveit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frmmoveit_MouseMove(object sender, MouseEventArgs e)
        {
            //txtx.Text = "5";
            //txty.Text = "10";
            txtx.Text = e.X.ToString();
            txty.Text = e.Y.ToString();
        }

        private void butHide_Click(object sender, EventArgs e)
        {
            butHover.Hide();
            txtx.Hide();
            txty.Hide();
            label1.Hide();
            label2.Hide();
            textBox1.Visible = false;
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            butHover.Show();
            txtx.Show();
            txty.Show();
            label1.Show();
            label2.Show();
            textBox1.Visible = true;
        }

        private void butHover_MouseHover(object sender, EventArgs e)
        {
            butHover.BackColor = SystemColors.ControlDarkDark;
            butHover.ForeColor = SystemColors.ControlLightLight;
        }

        private void butHover_MouseLeave(object sender, EventArgs e)
        {
            butHover.BackColor = Color.AntiqueWhite;
            butHover.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Enter(object sender, EventArgs e)
        {
            label3.Text = "Top Left has the focus";
            
        }

        private void label6_Enter(object sender, EventArgs e)
        {
            label4.Text = "Top Right the focus";
        }

        private void label3_Enter(object sender, EventArgs e)
        {
            label5.Text = "Bottom Left the Focus";
        }

        private void label4_Enter(object sender, EventArgs e)
        {
            label6.Text = "Bottom Right the focus";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Has the focus";
        }

        private void label3_MouseCaptureChanged(object sender, EventArgs e)
        {
           // label3.Text = "Has the focus";
        }

        private void label3_CursorChanged(object sender, EventArgs e)
        {
            //label3.Text = "Has the focus";
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            //label3.Text = "Has the focus";
        }

        private void label3_DragEnter(object sender, DragEventArgs e)
        {
           // label3.Text = "Has the focus";
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            //label3.Text = "Has the focus";
        }

        private void label3_TabIndexChanged(object sender, EventArgs e)
        {
           // label3.Text = "Has the focus";
        }

        private void label3_RightToLeftChanged(object sender, EventArgs e)
        {
            //label3.Text = "Has the focus";
        }

        private void label3_RegionChanged(object sender, EventArgs e)
        {
           // label3.Text = "Has the focus";
        }

        private void label3_BindingContextChanged(object sender, EventArgs e)
        {
            //label3.Text = "Has the focus";
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            label3.Text = "Top Left has the focus";
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            label4.Text = "Top Right has the focus";
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            label5.Text = "Bottom Left has the focus";
        }

        private void button4_Enter(object sender, EventArgs e)
        {
            label6.Text = "Bottom Right has the focus";
        }
    }
}