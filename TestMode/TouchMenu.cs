using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestMode
{
    public partial class TouchMenu : Form
    {
        public TouchMenu()
        {
            InitializeComponent();
        }

        private void calbbtn_Click(object sender, EventArgs e)
        {
             // using System.Diagnostics.Process & full path
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"\Windows\calib.exe";
            processStartInfo.UseShellExecute = false;
            Process.Start(processStartInfo);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}