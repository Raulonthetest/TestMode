namespace TestMode
{
    partial class selector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mbar;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mbar = new System.Windows.Forms.MainMenu();
            this.exitbtn = new System.Windows.Forms.MenuItem();
            this.picbutn = new System.Windows.Forms.Button();
            this.sndbutn = new System.Windows.Forms.Button();
            this.tchbutn = new System.Windows.Forms.Button();
            this.osvbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mbar
            // 
            this.mbar.MenuItems.Add(this.exitbtn);
            // 
            // exitbtn
            // 
            this.exitbtn.Text = "Exit";
            this.exitbtn.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // picbutn
            // 
            this.picbutn.Location = new System.Drawing.Point(0, 3);
            this.picbutn.Name = "picbutn";
            this.picbutn.Size = new System.Drawing.Size(240, 39);
            this.picbutn.TabIndex = 0;
            this.picbutn.Text = "Picture";
            this.picbutn.Click += new System.EventHandler(this.picbutn_Click);
            // 
            // sndbutn
            // 
            this.sndbutn.Location = new System.Drawing.Point(0, 48);
            this.sndbutn.Name = "sndbutn";
            this.sndbutn.Size = new System.Drawing.Size(240, 39);
            this.sndbutn.TabIndex = 1;
            this.sndbutn.Text = "Sound";
            this.sndbutn.Click += new System.EventHandler(this.sndbutn_Click);
            // 
            // tchbutn
            // 
            this.tchbutn.Location = new System.Drawing.Point(0, 93);
            this.tchbutn.Name = "tchbutn";
            this.tchbutn.Size = new System.Drawing.Size(240, 42);
            this.tchbutn.TabIndex = 2;
            this.tchbutn.Text = "Touch";
            this.tchbutn.Click += new System.EventHandler(this.tchbutn_Click);
            // 
            // osvbtn
            // 
            this.osvbtn.Location = new System.Drawing.Point(0, 141);
            this.osvbtn.Name = "osvbtn";
            this.osvbtn.Size = new System.Drawing.Size(240, 42);
            this.osvbtn.TabIndex = 3;
            this.osvbtn.Text = "OS Version";
            this.osvbtn.Click += new System.EventHandler(this.osvbtn_Click);
            // 
            // selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.osvbtn);
            this.Controls.Add(this.tchbutn);
            this.Controls.Add(this.sndbutn);
            this.Controls.Add(this.picbutn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mbar;
            this.Name = "selector";
            this.Text = "Test Mode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button picbutn;
        private System.Windows.Forms.Button sndbutn;
        private System.Windows.Forms.MenuItem exitbtn;
        private System.Windows.Forms.Button tchbutn;
        private System.Windows.Forms.Button osvbtn;
    }
}

