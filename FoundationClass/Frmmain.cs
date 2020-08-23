using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoundationClass
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

        }

        private void moveItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmoveit  obj = new Frmmoveit();
            obj.ShowDialog();
            //obj.Show();
        }

        private void doItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdoit  obj = new Frmdoit();
            obj.ShowDialog();
            //obj.Show();
        }

        private void moveItExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmexammoveit obj = new Frmexammoveit();
            obj.Show();
        }


       
    }
}