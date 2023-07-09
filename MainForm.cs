using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace CNPM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Form f = new SachForm();
            //f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blah<KhachHangForm>();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blah<SachForm>();
        }

        private void lậpPhiếuNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blah<PhieuNhapSach>();
        }

        private void lậpHóaĐơnBánSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blah<LapHoaDon>();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new QuiDinh();
            f.ShowDialog();
        }

        public void Blah<T>() where T: Form, new()
        {
            if (Application.OpenForms.OfType<T>().Any())
            {
                Application.OpenForms.OfType<T>().First().WindowState = FormWindowState.Normal;
                Application.OpenForms.OfType<T>().First().Focus();
            }
            else
            {
                Form f = new T();
                f.MaximizeBox = false;
                f.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lậpPhiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blah<PhieuThuTien>();
        }

        private void báoCáoTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blah<BaoCaoTon>();
        }

        private void báoCáoCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blah<BaoCaoCongNo>();
        }

    }
}
