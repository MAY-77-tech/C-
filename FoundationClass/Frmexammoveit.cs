using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoundationClass
{
    public partial class Frmexammoveit : Form
    {
        public Frmexammoveit()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
           // lab1.Text = e.X.ToString();
        }

        private void lab1_Click(object sender, EventArgs e)
        {

        }

        private void lab2_MouseMove(object sender, MouseEventArgs e)
        {
           // lab2.Text = e.Y.ToString();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            //label1.Text = e.X.ToString()+","+e.Y.ToString();
           
            
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
           // label3.Text = e.Y.ToString();
        }

        private void Frmexammoveit_Load(object sender, EventArgs e)
        {
           
        }

        private void Frmexammoveit_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString() + "," + e.Y.ToString();
        }
    }
}