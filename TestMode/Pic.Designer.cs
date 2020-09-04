namespace TestMode
{
    partial class Pic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pic));
            this.ColorPattern = new System.Windows.Forms.PictureBox();
            this.TestBar = new System.Windows.Forms.PictureBox();
            this.RGBBlktoWht = new System.Windows.Forms.PictureBox();
            this.Blue = new System.Windows.Forms.PictureBox();
            this.Green = new System.Windows.Forms.PictureBox();
            this.Red = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // ColorPattern
            // 
            this.ColorPattern.Image = ((System.Drawing.Image)(resources.GetObject("ColorPattern.Image")));
            this.ColorPattern.Location = new System.Drawing.Point(0, 0);
            this.ColorPattern.Name = "ColorPattern";
            this.ColorPattern.Size = new System.Drawing.Size(240, 320);
            this.ColorPattern.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TestBar
            // 
            this.TestBar.Image = ((System.Drawing.Image)(resources.GetObject("TestBar.Image")));
            this.TestBar.Location = new System.Drawing.Point(0, 0);
            this.TestBar.Name = "TestBar";
            this.TestBar.Size = new System.Drawing.Size(240, 320);
            this.TestBar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RGBBlktoWht
            // 
            this.RGBBlktoWht.Image = ((System.Drawing.Image)(resources.GetObject("RGBBlktoWht.Image")));
            this.RGBBlktoWht.Location = new System.Drawing.Point(0, 0);
            this.RGBBlktoWht.Name = "RGBBlktoWht";
            this.RGBBlktoWht.Size = new System.Drawing.Size(240, 320);
            this.RGBBlktoWht.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Blue
            // 
            this.Blue.Image = ((System.Drawing.Image)(resources.GetObject("Blue.Image")));
            this.Blue.Location = new System.Drawing.Point(0, 0);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(240, 320);
            this.Blue.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Green
            // 
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.Location = new System.Drawing.Point(0, 0);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(240, 320);
            this.Green.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Red
            // 
            this.Red.Image = ((System.Drawing.Image)(resources.GetObject("Red.Image")));
            this.Red.Location = new System.Drawing.Point(0, 0);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(240, 320);
            this.Red.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.RGBBlktoWht);
            this.Controls.Add(this.TestBar);
            this.Controls.Add(this.ColorPattern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "Pic";
            this.Text = "Pic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pic_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorPattern;
        private System.Windows.Forms.PictureBox TestBar;
        private System.Windows.Forms.PictureBox RGBBlktoWht;
        private System.Windows.Forms.PictureBox Blue;
        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.PictureBox Red;

    }
}