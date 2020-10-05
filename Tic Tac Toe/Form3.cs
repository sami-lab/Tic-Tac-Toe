using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form1.count == 1)
            {
                label3.Text = Form2.name1 + " Won";
            }
            else if (Form1.count == 2)
            {
                label3.Text = Form2.name2 + " Won";
            }
            else 
            {
                label3.Text = "Game Draw";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //Form1 f1 = new Form1();
            this.Hide();
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
