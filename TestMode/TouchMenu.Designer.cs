﻿namespace TestMode
{
    partial class TouchMenu
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
            this.calbbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mbar
            // 
            this.mbar.MenuItems.Add(this.exitbtn);
            // 
            // exitbtn
            // 
            this.exitbtn.Text = "Exit";
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // calbbtn
            // 
            this.calbbtn.Location = new System.Drawing.Point(0, 3);
            this.calbbtn.Name = "calbbtn";
            this.calbbtn.Size = new System.Drawing.Size(240, 47);
            this.calbbtn.TabIndex = 0;
            this.calbbtn.Text = "Calibrate";
            this.calbbtn.Click += new System.EventHandler(this.calbbtn_Click);
            // 
            // TouchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.calbbtn);
            this.Menu = this.mbar;
            this.Name = "TouchMenu";
            this.Text = "Touch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calbbtn;
        private System.Windows.Forms.MenuItem exitbtn;
    }
}