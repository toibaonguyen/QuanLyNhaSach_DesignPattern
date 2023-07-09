namespace CNPM
{
    partial class MainForm
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
            this.mstp = new System.Windows.Forms.MenuStrip();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuNhậpSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnBánSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuThuTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổChứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiQuyĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtNốiCSDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoCôngNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstp
            // 
            this.mstp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nghiệpVụToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.tổChứcToolStripMenuItem});
            this.mstp.Location = new System.Drawing.Point(0, 0);
            this.mstp.Name = "mstp";
            this.mstp.Size = new System.Drawing.Size(383, 24);
            this.mstp.TabIndex = 0;
            this.mstp.Text = "menuStrip1";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuNhậpSáchToolStripMenuItem,
            this.lậpHóaĐơnBánSáchToolStripMenuItem,
            this.lậpPhiếuThuTiềnToolStripMenuItem,
            this.báoCáoTồnToolStripMenuItem,
            this.báoCáoCôngNợToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp Vụ";
            // 
            // lậpPhiếuNhậpSáchToolStripMenuItem
            // 
            this.lậpPhiếuNhậpSáchToolStripMenuItem.Name = "lậpPhiếuNhậpSáchToolStripMenuItem";
            this.lậpPhiếuNhậpSáchToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lậpPhiếuNhậpSáchToolStripMenuItem.Text = "Lập phiếu nhập sách";
            this.lậpPhiếuNhậpSáchToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuNhậpSáchToolStripMenuItem_Click);
            // 
            // lậpHóaĐơnBánSáchToolStripMenuItem
            // 
            this.lậpHóaĐơnBánSáchToolStripMenuItem.Name = "lậpHóaĐơnBánSáchToolStripMenuItem";
            this.lậpHóaĐơnBánSáchToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lậpHóaĐơnBánSáchToolStripMenuItem.Text = "Lập hóa đơn bán sách";
            this.lậpHóaĐơnBánSáchToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnBánSáchToolStripMenuItem_Click);
            // 
            // lậpPhiếuThuTiềnToolStripMenuItem
            // 
            this.lậpPhiếuThuTiềnToolStripMenuItem.Name = "lậpPhiếuThuTiềnToolStripMenuItem";
            this.lậpPhiếuThuTiềnToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lậpPhiếuThuTiềnToolStripMenuItem.Text = "Lập phiếu thu tiền";
            this.lậpPhiếuThuTiềnToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuThuTiềnToolStripMenuItem_Click);
            // 
            // báoCáoTồnToolStripMenuItem
            // 
            this.báoCáoTồnToolStripMenuItem.Name = "báoCáoTồnToolStripMenuItem";
            this.báoCáoTồnToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.báoCáoTồnToolStripMenuItem.Text = "Báo cáo tồn";
            this.báoCáoTồnToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTồnToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // tổChứcToolStripMenuItem
            // 
            this.tổChứcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiQuyĐịnhToolStripMenuItem,
            this.kếtNốiCSDLToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tổChứcToolStripMenuItem.Name = "tổChứcToolStripMenuItem";
            this.tổChứcToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.tổChứcToolStripMenuItem.Text = "Tổ chức";
            // 
            // thayĐổiQuyĐịnhToolStripMenuItem
            // 
            this.thayĐổiQuyĐịnhToolStripMenuItem.Name = "thayĐổiQuyĐịnhToolStripMenuItem";
            this.thayĐổiQuyĐịnhToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thayĐổiQuyĐịnhToolStripMenuItem.Text = "Thay đổi quy định";
            this.thayĐổiQuyĐịnhToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiQuyĐịnhToolStripMenuItem_Click);
            // 
            // kếtNốiCSDLToolStripMenuItem
            // 
            this.kếtNốiCSDLToolStripMenuItem.Name = "kếtNốiCSDLToolStripMenuItem";
            this.kếtNốiCSDLToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.kếtNốiCSDLToolStripMenuItem.Text = "Kết nối CSDL";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // báoCáoCôngNợToolStripMenuItem
            // 
            this.báoCáoCôngNợToolStripMenuItem.Name = "báoCáoCôngNợToolStripMenuItem";
            this.báoCáoCôngNợToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.báoCáoCôngNợToolStripMenuItem.Text = "Báo cáo công nợ";
            this.báoCáoCôngNợToolStripMenuItem.Click += new System.EventHandler(this.báoCáoCôngNợToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 262);
            this.Controls.Add(this.mstp);
            this.MainMenuStrip = this.mstp;
            this.Name = "MainForm";
            this.Text = "Quản Lí Nhà Sách";
            this.mstp.ResumeLayout(false);
            this.mstp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstp;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuNhậpSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnBánSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổChứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiQuyĐịnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtNốiCSDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuThuTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoCôngNợToolStripMenuItem;
    }
}

