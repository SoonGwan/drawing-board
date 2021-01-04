
namespace _1.Mouse
{
    partial class MouseDown
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
            this.save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.color = new System.Windows.Forms.Button();
            this.colorpanel = new System.Windows.Forms.Panel();
            this.remove = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.getImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(963, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(148, 124);
            this.save.TabIndex = 1;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.BackgroundImageChanged += new System.EventHandler(this.getImg_Click);
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1099, 357);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(81, 82);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(123, 54);
            this.color.TabIndex = 2;
            this.color.Text = "color";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // colorpanel
            // 
            this.colorpanel.Location = new System.Drawing.Point(12, 82);
            this.colorpanel.Name = "colorpanel";
            this.colorpanel.Size = new System.Drawing.Size(63, 52);
            this.colorpanel.TabIndex = 3;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(12, 12);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(192, 64);
            this.remove.TabIndex = 4;
            this.remove.Text = "remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(210, 12);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // getImg
            // 
            this.getImg.Location = new System.Drawing.Point(811, 12);
            this.getImg.Name = "getImg";
            this.getImg.Size = new System.Drawing.Size(146, 125);
            this.getImg.TabIndex = 6;
            this.getImg.Text = "get IMG";
            this.getImg.UseVisualStyleBackColor = true;
            this.getImg.Click += new System.EventHandler(this.getImg_Click);
            // 
            // MouseDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 512);
            this.Controls.Add(this.getImg);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.colorpanel);
            this.Controls.Add(this.color);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save);
            this.Name = "MouseDown";
            this.Text = "MouseDown1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Panel colorpanel;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button getImg;
    }
}