namespace QLTTBPhongMay
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.hienbtn = new System.Windows.Forms.Button();
            this.dangkybtn = new System.Windows.Forms.Button();
            this.dangnhapbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHệThốngToolStripMenuItem
            // 
            this.quảnLýHệThốngToolStripMenuItem.Name = "quảnLýHệThốngToolStripMenuItem";
            this.quảnLýHệThốngToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.quảnLýHệThốngToolStripMenuItem.Text = "Quản Lý Hệ Thống";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passwordtxt);
            this.panel1.Controls.Add(this.usernametxt);
            this.panel1.Controls.Add(this.hienbtn);
            this.panel1.Controls.Add(this.dangkybtn);
            this.panel1.Controls.Add(this.dangnhapbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 415);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(315, 149);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(157, 22);
            this.passwordtxt.TabIndex = 6;
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(315, 106);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(157, 22);
            this.usernametxt.TabIndex = 5;
            // 
            // hienbtn
            // 
            this.hienbtn.Location = new System.Drawing.Point(532, 149);
            this.hienbtn.Name = "hienbtn";
            this.hienbtn.Size = new System.Drawing.Size(109, 28);
            this.hienbtn.TabIndex = 4;
            this.hienbtn.Text = "Hiện";
            this.hienbtn.UseVisualStyleBackColor = true;
            // 
            // dangkybtn
            // 
            this.dangkybtn.Location = new System.Drawing.Point(445, 221);
            this.dangkybtn.Name = "dangkybtn";
            this.dangkybtn.Size = new System.Drawing.Size(109, 28);
            this.dangkybtn.TabIndex = 3;
            this.dangkybtn.Text = "Đăng Ký";
            this.dangkybtn.UseVisualStyleBackColor = true;
            // 
            // dangnhapbtn
            // 
            this.dangnhapbtn.Location = new System.Drawing.Point(282, 221);
            this.dangnhapbtn.Name = "dangnhapbtn";
            this.dangnhapbtn.Size = new System.Drawing.Size(109, 28);
            this.dangnhapbtn.TabIndex = 2;
            this.dangnhapbtn.Text = "Đăng Nhập";
            this.dangnhapbtn.UseVisualStyleBackColor = true;
            this.dangnhapbtn.Click += new System.EventHandler(this.dangnhapbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(205, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(205, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Button hienbtn;
        private System.Windows.Forms.Button dangkybtn;
        private System.Windows.Forms.Button dangnhapbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}