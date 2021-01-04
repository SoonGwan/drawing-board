using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Mouse
{
    public partial class MouseDown : Form
    {
        int curLineSize = 5;
        Color curColor = Color.Black;
        Bitmap pictureBoxBmp;
        Point mouseDownPoint;
        int saveCount = Properties.Settings.Default.saveCount;

        enum SELECTED_MODE : int
        {
            LINE = 0,
            SQUARE = 1,
        }

        public MouseDown()
        {
            InitializeComponent();
            pictureBoxBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            colorpanel.BackColor = curColor;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point curPoint = pictureBox1.PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));

                Pen p;
                p = new Pen(curColor);

                p.Width = curLineSize;

                Graphics g = Graphics.FromImage(pictureBoxBmp);
                g.DrawEllipse(p, curPoint.X, curPoint.Y, p.Width, p.Width);

                p.Dispose();
                g.Dispose();
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint = new Point(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Left)
            {
                Point startPoint = new Point(e.X, e.Y);
                Color preColor = pictureBoxBmp.GetPixel(startPoint.X, startPoint.Y);
                pictureBox1.Image = pictureBoxBmp;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen p = new Pen(curColor);
                p.Width = curLineSize;

                Point mouseUpPoint = new Point(e.X, e.Y);

                Graphics g = Graphics.FromImage(pictureBoxBmp);
                g.DrawRectangle(p, new Rectangle(mouseDownPoint.X, mouseDownPoint.Y, Math.Abs(mouseUpPoint.X - mouseDownPoint.X), Math.Abs(mouseUpPoint.Y - mouseDownPoint.Y)));
                pictureBox1.Image = pictureBoxBmp;

                p.Dispose();
                g.Dispose();
            }
        }

        public void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = ($"img{saveCount}.png");
            saveFileDialog.Filter = "PNG File|*.png|Bitmap File|*.bmp|JPEG File|*.jpg";
            if (pictureBox1.Image == null)
            {

                return;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs, ImageFormat.Png);
                        break;
                    case 2:
                        this.pictureBox1.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.pictureBox1.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                }
                fs.Dispose();
                fs.Close();
            }
            Properties.Settings.Default.saveCount++;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                curColor = colorDialog.Color;
                colorpanel.BackColor = curColor;
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if(curColor != Color.White)
            {
                curColor = Color.White;
                colorpanel.BackColor = Color.White;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            curLineSize = trackBar1.Value;
        }

        private void getImg_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image_file = dialog.FileName;
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(image_file);
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if(MessageBox.Show("저장하지 않고 종료하시겠습니까?", "네", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    save_Click(sender, e);
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
