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
            pet.Image = Image.FromFile(@"../../images/1.gif");
        }
        Random rnd = new Random();
        int pet_index = 1;
        int dialog_index = 0;
        bool showed = false;
        private void petTimer_Tick(object sender, EventArgs e)
        {
            pet_index = rnd.Next(1, 3);
            pet.Image = Image.FromFile(@"../../images/" + pet_index + ".gif");
        }

        private void pet_Click(object sender, EventArgs e)
        {
            dialog_index = rnd.Next(0, 10);
            dialog.Image = Image.FromFile(@"../../images/dialog/chatDialog" + dialog_index + ".png");
            dialog.Visible = true;
            showed = false;
            dialogTimer.Enabled = true;
        }

        
        bool drag = false;   // 記錄是否可拖曳，預設為不可
        int sX, sY;

        private void pet_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pet_MouseMove(object sender, MouseEventArgs e)
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

        private void dialogTimer_Tick(object sender, EventArgs e)
        {
            if (!showed) showed = true;
            else
            {
                dialog.Visible = false;
                dialogTimer.Enabled = false;
            }
        }

        private void pet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)    // 若按左鍵時
            {
                drag = true;                 // 設為可拖曳
                sX = e.X; sY = e.Y;          // 記錄滑鼠指標的座標値
            }
        }
    }
}
