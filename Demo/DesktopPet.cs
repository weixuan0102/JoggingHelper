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

        Random rnd = new Random();
        int pet_index = 1;
        int dialog_index = 0;
        bool showed = false;
        bool opened = false;
        bool canDrag = false;
        int mouseX, mouseY;
        int autoTalk = 0;
        int time_ctrl = 3;
        bool startCount = false;

        private void DesktopPet_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = SystemColors.Control;
            pet.Image = Image.FromFile(@"../../images/1.gif");
        }

        private void pet_Click(object sender, EventArgs e)
        {
            dialog_index = rnd.Next(0, 10);
            dialog.Image = Image.FromFile(@"../../images/dialog/chatDialog" + dialog_index + ".png");
            dialog.Visible = true;
            showed = false;
            dialogTimer.Enabled = true;
            startCount = false;
        }

        private void pet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                canDrag = true;
                mouseX = e.X; mouseY = e.Y;
            }
        }

        private void pet_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDrag)
            {
                this.Location = new Point(this.Location.X + e.X - mouseX, this.Location.Y + e.Y - mouseY);
            }
        }

        private void pet_MouseUp(object sender, MouseEventArgs e)
        {
            canDrag = false;
        }

        private void petTimer_Tick(object sender, EventArgs e)
        {
            if (startCount)
            {
                if (autoTalk == time_ctrl)
                {
                    // 3~11次interval不點就講話
                    dialog_index = rnd.Next(0, 10);
                    dialog.Image = Image.FromFile(@"../../images/dialog/chatDialog" + dialog_index + ".png");
                    dialog.Visible = true;
                    showed = false;
                    dialogTimer.Enabled = true;
                    autoTalk = 0;
                    int r = rnd.Next(1, 38); // 2~10 分別佔1 3 5 6 8 6 5 3 1份
                    if (r == 1) time_ctrl = 2;
                    else if (r <= 4) time_ctrl = 3;
                    else if (r <= 9) time_ctrl = 4;
                    else if (r <= 15) time_ctrl = 5;
                    else if (r <= 23) time_ctrl = 6;
                    else if (r <= 29) time_ctrl = 7;
                    else if (r <= 34) time_ctrl = 8;
                    else if (r <= 37) time_ctrl = 9;
                    else time_ctrl = 10;
                }
                else autoTalk++;
            }
            else
            {
                autoTalk = 0;
                startCount = true;
            }

            int rndInterval = rnd.Next(5, 7);
            rndInterval *= 1000;
            int new_petIndex = rnd.Next(1, 3);
            if (new_petIndex == pet_index) pet_index = rnd.Next(1, 3);
            pet_index = new_petIndex;
            pet.Image = Image.FromFile(@"../../images/" + pet_index + ".gif");
        }

        private void dialogTimer_Tick(object sender, EventArgs e)
        {
            // 顯示時間 = interval*2
            if (!showed) showed = true;
            else
            {
                autoTalk = 0;
                dialog.Visible = false;
                dialogTimer.Enabled = false;
            }
        }

        private void MenuJoggingHelper_Click(object sender, EventArgs e)
        {
            Form1 joggingHelper = new Form1();
            if (!opened)
            {
                joggingHelper = new Form1();
                joggingHelper.FormClosed += JoggingHelper_FormClosed;
                Form1.soundplayer.SoundLocation = @"../../sound/backroundSound.wav";
                Form1.soundplayer.PlayLooping();
                joggingHelper.Show();
                opened = true;
            }
            //else if (joggingHelper.WindowState == FormWindowState.Minimized)
            //{
            //    joggingHelper.WindowState = FormWindowState.Normal;
            //    Application.OpenForms["form1"].BringToFront();
            //}
            else Application.OpenForms["form1"].BringToFront();
        }

        public void JoggingHelper_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.soundplayer.Stop();
            dialog.Image = Image.FromFile(@"../../images/dialog/chatDialog9.png");
            dialog.Visible = true;
            showed = false;
            dialogTimer.Enabled = true;
            opened = false;
        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pet_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r1 = MessageBox.Show("        你忍心嗎?", " (⋟﹏⋞)", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (r1 == DialogResult.Yes)
            {
                DialogResult r2 = MessageBox.Show("        真的忍心嗎?", " (╥﹏╥)", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (r2 == DialogResult.No) e.Cancel = true;
            }
            else e.Cancel = true;
        }

    }
}
