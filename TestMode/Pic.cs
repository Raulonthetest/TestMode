using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestMode
{
    public partial class Pic : Form
    {
        public Pic()
        {
            InitializeComponent();
        }

        private void Pic_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Red.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Green.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Blue.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RGBBlktoWht.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TestBar.Hide(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}