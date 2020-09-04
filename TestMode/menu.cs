using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TestMode
{
    public partial class selector : Form
    {
        public selector()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }

        private void sndbutn_Click(object sender, EventArgs e)
        {
            Snd stest = new Snd(); // This is bad
            stest.Show();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbutn_Click(object sender, EventArgs e)
        {
            Pic itest = new Pic(); // This is bad
            itest.Show();
        }

        private void tchbutn_Click(object sender, EventArgs e)
        {
            TouchMenu ttest = new TouchMenu(); // This is bad
            ttest.Show();
        }

        private void osvbtn_Click(object sender, EventArgs e)
        {
            //1 - get os ver
            OperatingSystem os = Environment.OSVersion;
            PlatformID osplat = os.Platform;
            string OSversion = Environment.OSVersion.Version.ToString();
            string Platf = "";
            string osp = "";
            string OSVer = "";
            osp = "Microsoft Windows CE"; //Pocket PC and Windows Mobile is based on Windows CE


            if (OSversion == "3.0.9348")
            {
                Platf = "Pocket PC 2000";
            }
            else if (OSversion == "3.0.11171")
            {
                Platf = "Pocket PC 2002";
            }
            else if (OSversion == "4.20.1081")
            {
                Platf = "Pocket PC 2003";
            }
            else if (OSversion == "4.21.1088")
            {
                Platf = "Pocket PC 2003 SE";
            }
            else if (OSversion == "5.1.1700")
            {
                Platf = "Windows Mobile 5.0";
            }
            else if (OSversion == "5.2.1235")
            {
                Platf = "Windows Mobile 6.0";
            }
            else if (OSversion == "5.2.19202")
            {
                Platf = "Windows Mobile 6.1";
            }
            else if (OSversion == "5.2.20757")
            {
                Platf = "Windows Mobile 6.1.4";
            }
            else if (OSversion == "5.2.21234")
            {
                Platf = "Windows Mobile 6.5";
            }
            else if (OSversion == "5.2.23090")
            {
                Platf = "Windows Mobile 6.5.3";
            }

            if (OSversion == "3.0.9348")
            {
                OSVer = " 3.0 build 9348";
            }
            else if (OSversion == "3.0.11171")
            {
                OSVer = " 3.0 build 11171";
            }
            else if (OSversion == "4.20.1081")
            {
                OSVer = " 4.20 build 1081";
            }
            else if (OSversion == "4.21.1088")
            {
                OSVer = " 4.21 build 1088";
            }
            else if (OSversion == "5.1.1700")
            {
                OSVer = " 5.1 build 1700";
            }
            else if (OSversion == "5.2.1235")
            {
                OSVer = " 5.2 build 1235";
            }
            else if (OSversion == "5.2.19202")
            {
                OSVer = " 5.2 build 19202";
            }
            else if (OSversion == "5.2.20757")
            {
                OSVer = " 5.2 build 20757";
            }
            else if (OSversion == "5.2.21234")
            {
                OSVer = " 5.2 build 21234";
            }
            else if (OSversion == "5.2.23090")
            {
                OSVer = " 5.2 build 23090";
            }

            //registry
            string devicemodl = "";
            string devcodename = "";
            string buildsw = "";
            string builddate = "";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\FirmwareInfo"))
            {
                if (key != null)
                {
                    Object o = key.GetValue("SoftwareBuild");
                    if (o != null)
                    {
                        buildsw = o as String;  //"as" because it's REG_SZ...otherwise ToString() might be safe(r)
                        //do what you like with version
                    }
                }
            }

            using (RegistryKey key2 = Registry.LocalMachine.OpenSubKey("Software\\FirmwareInfo"))
            {
                if (key2 != null)
                {
                    Object p = key2.GetValue("DeviceModel");
                    if (p != null)
                    {
                        devicemodl = p as String;  //"as" because it's REG_SZ...otherwise ToString() might be safe(r)
                        //do what you like with version
                    }
                }
            }
            using (RegistryKey key3 = Registry.LocalMachine.OpenSubKey("Software\\FirmwareInfo"))
            {
                if (key3 != null)
                {
                    Object q = key3.GetValue("DeviceCodename");
                    if (q != null)
                    {
                        devcodename = q as String;  //"as" because it's REG_SZ...otherwise ToString() might be safe(r)
                        //do what you like with version
                    }
                }
            }

            using (RegistryKey key4 = Registry.LocalMachine.OpenSubKey("Software\\FirmwareInfo"))
            {
                if (key4 != null)
                {
                    Object r = key4.GetValue("BuildDate");
                    if (r != null)
                    {
                        builddate = r as String;  //"as" because it's REG_SZ...otherwise ToString() might be safe(r)
                        //do what you like with version
                    }
                }
            }

            string os1 = "";
            string os2 = "";
            string os3 = "";

            DialogResult dialogresult = MessageBox.Show("OS: " + Platf + " (" + osp + " " + OSversion.ToString() + ")\nModel: " + devicemodl + " (codename " + devcodename + ")\nBuild: " + buildsw + " at " + builddate, "FWInfo");
        }
    }
}