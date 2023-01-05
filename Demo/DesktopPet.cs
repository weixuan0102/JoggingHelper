using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class DesktopPet : Form
    {
        public DesktopPet()
        {
            InitializeComponent();
            
        }

        private void DesktopPet_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.TransparencyKey = this.BackColor;
        }

        int i = 1;
        //int j = 4;
        int j = 6;
        int k = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"../../image/" + i + ".gif");
            i++;
            if (i == 4) i = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = Image.FromFile(@"../../image/" + j + ".jpg");
            //pictureBox2.Visible = true;
            //j++;
            //if (j == 6) j = 4;
            //timer2.Enabled = true;
        }

        
        bool drag = false;   // 記錄是否可拖曳，預設為不可
        int sX, sY;

        private void MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Location = new Point(this.Location.X + e.X - sX, this.Location.Y + e.Y - sY);
            }
        }

        private void joggingHelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.FormClosed += F1_FormClosed;
            f.Show();
        }
        public void F1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 跳一句話 (去運動)
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("你忍心嗎", "", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (r == DialogResult.Yes)
            {
                DialogResult rr = MessageBox.Show("你真的忍心嗎", "", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (rr == DialogResult.Yes) Application.Exit();
            }
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)    // 若按左鍵時
            {
                drag = true;                 // 設為可拖曳
                sX = e.X; sY = e.Y;          // 記錄滑鼠指標的座標値
            }
        }
    }
}
