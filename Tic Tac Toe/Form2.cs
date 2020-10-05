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
    public partial class Form2 : Form
    {
        public static string name1;
        public static string name2;
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            name1 = textBox1.Text;
            name2 = textBox2.Text;
            if(String.IsNullOrEmpty(name1) || string.IsNullOrEmpty(name2))
            {
                MessageBox.Show("Name Field Cannot be empty");
            }
            else if (!(name1.All(char.IsLetter) && name2.All(char.IsLetter)) && !(name1.Any(char.IsWhiteSpace) || name2.Any(char.IsWhiteSpace)))
            {
                MessageBox.Show("Name Only Contains Letters");
            }
            else
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
        }
    }
}
