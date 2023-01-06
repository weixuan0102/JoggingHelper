namespace Demo
{
    partial class DesktopPet
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.joggingHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petTimer = new System.Windows.Forms.Timer(this.components);
            this.dialogTimer = new System.Windows.Forms.Timer(this.components);
            this.dialog = new System.Windows.Forms.PictureBox();
            this.pet = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joggingHelperToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 48);
            // 
            // joggingHelperToolStripMenuItem
            // 
            this.joggingHelperToolStripMenuItem.Name = "joggingHelperToolStripMenuItem";
            this.joggingHelperToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.joggingHelperToolStripMenuItem.Text = "Jogging Helper";
            this.joggingHelperToolStripMenuItem.Click += new System.EventHandler(this.joggingHelperToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // petTimer
            // 
            this.petTimer.Enabled = true;
            this.petTimer.Interval = 5000;
            this.petTimer.Tick += new System.EventHandler(this.petTimer_Tick);
            // 
            // dialogTimer
            // 
            this.dialogTimer.Interval = 500;
            this.dialogTimer.Tick += new System.EventHandler(this.dialogTimer_Tick);
            // 
            // dialog
            // 
            this.dialog.Image = global::Demo.Properties.Resources.chatDialog1;
            this.dialog.Location = new System.Drawing.Point(43, -4);
            this.dialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dialog.Name = "dialog";
            this.dialog.Size = new System.Drawing.Size(178, 186);
            this.dialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dialog.TabIndex = 1;
            this.dialog.TabStop = false;
            this.dialog.Visible = false;
            // 
            // pet
            // 
            this.pet.ContextMenuStrip = this.contextMenuStrip1;
            this.pet.Image = global::Demo.Properties.Resources._3;
            this.pet.Location = new System.Drawing.Point(7, 128);
            this.pet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pet.Name = "pet";
            this.pet.Size = new System.Drawing.Size(79, 83);
            this.pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pet.TabIndex = 0;
            this.pet.TabStop = false;
            this.pet.Click += new System.EventHandler(this.pet_Click);
            this.pet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pet_MouseDown);
            this.pet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pet_MouseMove);
            this.pet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pet_MouseUp);
            // 
            // DesktopPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 212);
            this.Controls.Add(this.pet);
            this.Controls.Add(this.dialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DesktopPet";
            this.Text = "DesktopPet";
            this.Load += new System.EventHandler(this.DesktopPet_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pet;
        private System.Windows.Forms.Timer petTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem joggingHelperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox dialog;
        private System.Windows.Forms.Timer dialogTimer;
    }
}