using BUS_QUANLY;
using DTO;
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
    
    public partial class fDonHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_DonHang busDH = new BUS_DonHang();
        public fDonHang()
        {
            InitializeComponent();
        }

        private void fDonHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = busKH.getKhachHang();
            dgvDH.DataSource = busDH.getDonHang();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy row hiện tại
            DataGridViewRow row = dgvKH.SelectedRows[0];
            // Chuyển giá trị lên form
            tbID.Text = row.Cells[0].Value.ToString();
            tbName.Text = row.Cells[1].Value.ToString();
        }

        private void dgvDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy row hiện tại
            DataGridViewRow row = dgvDH.SelectedRows[0];
            // Chuyển giá trị lên form
            tbID.Text = row.Cells[3].Value.ToString();
            tbName.Text = row.Cells[4].Value.ToString();
            if (row.Cells[1].Value.ToString() == "True")
            {
                cbYes.Checked = true;
            }
            else
            {
                cbNo.Checked = true;
            }
            tbdate.Text = row.Cells[2].Value.ToString();
        }

        private void cbYes_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbYes.Checked)
            {
                cbNo.Checked = false;
            }
        }

        private void cbNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbNo.Checked)
            {
                cbYes.Checked = false;
            }
        }
       

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            string isChecked = cbYes.Checked ? "True" : "False";

            DateTime dt;
            if (!DateTime.TryParse(tbdate.Text, out dt))
            {
                MessageBox.Show("Nhập sai format ngày. Hãy nhập lại!");
                return;
            }
            string formatDeli = dt.ToString("yyyy-MM-dd HH:mm:ss");

            if (tbID.Text != "" && tbName.Text != "" && (cbNo.Checked || cbYes.Checked) && tbdate.Text != "")
            {
                // Tạo DTo
                DTO_DonHang tv = new DTO_DonHang(0, isChecked, formatDeli, Int32.Parse(tbID.Text), tbName.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                // Them
                if (busDH.themDonHang(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDH.DataSource = busDH.getDonHang(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string isChecked = cbYes.Checked ? "True" : "False";

            DateTime dt;
            if (!DateTime.TryParse(tbdate.Text, out dt))
            {
                MessageBox.Show("Nhập sai format ngày. Hãy nhập lại!");
                return;
            }
            string formatDeli = dt.ToString("yyyy-MM-dd HH:mm:ss");

            if (tbID.Text != "" && tbName.Text != "" && (cbNo.Checked || cbYes.Checked) && tbdate.Text != "")
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvDH.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Tạo DTo
                DTO_DonHang tv = new DTO_DonHang(ID, isChecked, formatDeli, Int32.Parse(tbID.Text), tbName.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                if (busDH.suaDonHang(tv))
                {
                    MessageBox.Show("Sửa thành công");
                    dgvKH.DataSource = busKH.getKhachHang(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvDH.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvDH.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busDH.xoaDonHang(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDH.DataSource = busDH.getDonHang(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hàng muốn xóa");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
