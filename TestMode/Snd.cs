using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace TestMode
{
    public partial class Snd : Form
    {
        public Snd()
        {
            InitializeComponent();
        }

        private void beepbtnbeepbtn_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void lbeep_Click(object sender, EventArgs e)
        {
            TestMode.Program.Sound soundFile = new TestMode.Program.Sound("null");
            soundFile.PlayLooped();
        }

        private void b2btn_Click(object sender, EventArgs e)
        {
            TestMode.Program.Sound soundFile = new TestMode.Program.Sound("\\Application Data\\Sounds\\Beat.wav");
            soundFile.PlayLooped();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            TestMode.Program.Sound soundFile = new TestMode.Program.Sound("NULL");
            soundFile.Play();
        }

        private void shtsbtn_Click(object sender, EventArgs e)
        {
            TestMode.Program.Sound soundFile = new TestMode.Program.Sound("\\Application Data\\Sounds\\testsnd.wav");
            soundFile.PlayLooped();
        }

        private void shttunb_Click(object sender, EventArgs e)
        {
            TestMode.Program.Sound soundFile = new TestMode.Program.Sound("\\Application Data\\Sounds\\music.wav");
            soundFile.Play();
        }
    }
}