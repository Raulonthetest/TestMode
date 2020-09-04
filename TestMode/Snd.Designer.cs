namespace TestMode
{
    partial class Snd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu SndMenu;

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
            this.SndMenu = new System.Windows.Forms.MainMenu();
            this.exitbtn = new System.Windows.Forms.MenuItem();
            this.beepbtnbeepbtn = new System.Windows.Forms.Button();
            this.lbeep = new System.Windows.Forms.Button();
            this.beatbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.shtsbtn = new System.Windows.Forms.Button();
            this.shttunb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SndMenu
            // 
            this.SndMenu.MenuItems.Add(this.exitbtn);
            // 
            // exitbtn
            // 
            this.exitbtn.Text = "Exit";
            this.exitbtn.Click += new System.EventHandler(this.exit_Click);
            // 
            // beepbtnbeepbtn
            // 
            this.beepbtnbeepbtn.Location = new System.Drawing.Point(0, 0);
            this.beepbtnbeepbtn.Name = "beepbtnbeepbtn";
            this.beepbtnbeepbtn.Size = new System.Drawing.Size(240, 34);
            this.beepbtnbeepbtn.TabIndex = 0;
            this.beepbtnbeepbtn.Text = "Beep";
            this.beepbtnbeepbtn.Click += new System.EventHandler(this.beepbtnbeepbtn_Click);
            // 
            // lbeep
            // 
            this.lbeep.Location = new System.Drawing.Point(0, 40);
            this.lbeep.Name = "lbeep";
            this.lbeep.Size = new System.Drawing.Size(240, 34);
            this.lbeep.TabIndex = 1;
            this.lbeep.Text = "Looped beep";
            this.lbeep.Click += new System.EventHandler(this.lbeep_Click);
            // 
            // beatbtn
            // 
            this.beatbtn.Location = new System.Drawing.Point(0, 80);
            this.beatbtn.Name = "beatbtn";
            this.beatbtn.Size = new System.Drawing.Size(240, 34);
            this.beatbtn.TabIndex = 3;
            this.beatbtn.Text = "Beat";
            this.beatbtn.Click += new System.EventHandler(this.b2btn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(0, 160);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(240, 34);
            this.stopbtn.TabIndex = 4;
            this.stopbtn.Text = "Stop!";
            this.stopbtn.Click += new System.EventHandler(this.stop_Click);
            // 
            // shtsbtn
            // 
            this.shtsbtn.Location = new System.Drawing.Point(0, 120);
            this.shtsbtn.Name = "shtsbtn";
            this.shtsbtn.Size = new System.Drawing.Size(120, 34);
            this.shtsbtn.TabIndex = 5;
            this.shtsbtn.Text = "Short test sound";
            this.shtsbtn.Click += new System.EventHandler(this.shtsbtn_Click);
            // 
            // shttunb
            // 
            this.shttunb.Location = new System.Drawing.Point(120, 120);
            this.shttunb.Name = "shttunb";
            this.shttunb.Size = new System.Drawing.Size(120, 34);
            this.shttunb.TabIndex = 6;
            this.shttunb.Text = "Short tune";
            this.shttunb.Click += new System.EventHandler(this.shttunb_Click);
            // 
            // Snd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.shttunb);
            this.Controls.Add(this.shtsbtn);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.beatbtn);
            this.Controls.Add(this.lbeep);
            this.Controls.Add(this.beepbtnbeepbtn);
            this.Menu = this.SndMenu;
            this.Name = "Snd";
            this.Text = "Sound";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beepbtnbeepbtn;
        private System.Windows.Forms.Button lbeep;
        private System.Windows.Forms.Button beatbtn;
        private System.Windows.Forms.MenuItem exitbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button shtsbtn;
        private System.Windows.Forms.Button shttunb;
    }
}