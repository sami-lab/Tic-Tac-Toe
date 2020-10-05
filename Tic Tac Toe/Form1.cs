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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int count =0;
       public bool x = true;
       public int[,] arr = new int[3, 3];
       int t = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[0, 0] = 1;
            }
            else 
            {
                arr[0,0] = -1;
            }
            changing(pictureBox1, label1);
            if (t > 4)
            {
                check();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[0, 1] = 1;
            }
            else
            {
                arr[0, 1] = -1;
            }
            changing(pictureBox2, label1);
            if (t > 4)
            {
                check();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[0, 2] = 1;
            }
            else
            {
                arr[0, 2] = -1;
            }
            changing(pictureBox3, label1);
            if (t > 4)
            {
                check();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[1, 2] = 1;
            }
            else
            {
                arr[1, 2] = -1;
            }
            changing(pictureBox6, label1);
            if (t > 4)
            {
                check();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[1, 1] = 1;
            }
            else
            {
                arr[1, 1] = -1;
            }
            changing(pictureBox5, label1);
            if (t > 4)
            {
                check();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[1, 0] = 1;
            }
            else
            {
                arr[1, 0] = -1;
            }
            changing(pictureBox4, label1);
            if (t > 4)
            {
                check();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[2, 2] = 1;
            }
            else
            {
                arr[2, 2] = -1;
            }
            changing(pictureBox9, label1);
            if (t > 4)
            {
                check();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[2, 1] = 1;
            }
            else
            {
                arr[2, 1] = -1;
            }
            changing(pictureBox8, label1);
            if (t > 4)
            {
                check();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            t++;
            if (x == true)
            {
                arr[2, 0] = 1;
            }
            else
            {
                arr[2, 0] = -1;
            }
            changing(pictureBox7, label1);
            if (t > 4)
            {
                check();
            }
        }
        public void changing(PictureBox p,Label l1)
        {
            if (x == true)
            {
                p.Image = Image.FromFile(@"tick-green-512.png");
                x = false;
                l1.Text = "Player : "+Form2.name2;
            }
            else 
            {
                p.Image = Image.FromFile(@"x-wrong-cross-no-md.png");
                x = true;
                l1.Text = "Player : "+Form2.name1;
            }
            p.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Player : "+Form2.name1;
        }
        private void check()
        {
             int[] row = new int[3];
             int[] col = new int[3];
             int d1 = 0, d2 = 0;
            for (int i = 0; i < 3; i++)
            {
                row[i] = 0;
                col[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    row[i] = row[i] + arr[i, j];
                    col[i] = col[i] + arr[j, i];
                    if (i == j)
                    {
                        d1 = d1 + arr[i, j];
                    }
                    if(i+j==2)
                    {
                        d2 = d2 + arr[i, j];
                    }
                }
                
            }
            if (d1 == 3 || d2 == 3)
            {
                count = 1;
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();
                //MessageBox.Show("Player "+Form2.name1+" Won");
                //return;
            }
            else if (d1 == -3 || d2 == -3)
            {
                count = 2;
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();
                //MessageBox.Show("Player 2 won");
                //return;
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (row[i] == 3 || col[i] == 3)
                    {
                        count =1;
                        Form3 f3 = new Form3();
                        this.Hide();
                        f3.Show();
                        return;
                    }
                    else if (row[i] == -3 || col[i] == -3)
                    {
                        count = 2;
                        Form3 f3 = new Form3();
                        this.Hide();
                        f3.Show();
                        //MessageBox.Show("Player 1 won");
                        return;
                    }
                }
            }
            if (t == 9)
            {
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();

            }
        }
    }
}
