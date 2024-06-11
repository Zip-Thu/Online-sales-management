using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }


        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSanPham f = new fSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNCC f = new fNCC();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void nhuCầuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapHang f = new fNhapHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chiTiếtNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhieuNhapHang f = new fPhieuNhapHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonHang f = new fDonHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fHoaDon f = new fHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tạoTàiKhoảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNewAccount f = new fNewAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
