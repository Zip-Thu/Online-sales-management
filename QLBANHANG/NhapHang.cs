using BUS_QUANLY;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLBANHANG
{
    public partial class fNhapHang : Form
    {
        BUS_NCC busNCC = new BUS_NCC();
        BUS_NhapHang busNH = new BUS_NhapHang();
        public fNhapHang()
        {
            InitializeComponent();
        }

        private void fNhapHang_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busNCC.getNCC();
            dgvNH.DataSource = busNH.getNhapHang();

        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //Lấy row hiện tại
            DataGridViewRow row = dgvNCC.SelectedRows[0];
            // Chuyển giá trị lên form
            tbID.Text = row.Cells[0].Value.ToString();
            tbName.Text = row.Cells[1].Value.ToString();
        }

        private void dgvNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy row hiện tại
            DataGridViewRow row = dgvNH.SelectedRows[0];
            // Chuyển giá trị lên form
            tbID.Text = row.Cells[1].Value.ToString();
            tbName.Text = row.Cells[2].Value.ToString();
            if (row.Cells[4].Value.ToString() == "True")
            {
                cbYes.Checked = true;
            }
            else
            {
                cbNo.Checked = true;
            }
            tbdate.Text = row.Cells[3].Value.ToString();

            
        }

        private void cbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYes.Checked)
            {
                cbNo.Checked = false;
            }
        }

        private void cbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo.Checked)
            {
                cbYes.Checked = false;
            }
        }




        private void btAdd_Click(object sender, EventArgs e)
        {
            string isChecked = cbYes.Checked ? "True" : "False";

            DateTime dt;
            if (!DateTime.TryParse(tbdate.Text, out dt))
            {
                MessageBox.Show("Nhập sai format ngày. Hãy nhập lại!");
                return;
            }
            string formatDeli = dt.ToString("yyyy-MM-dd HH:mm:ss");

            if (tbID.Text != "" && tbName.Text != "" && (cbNo.Checked || cbYes.Checked) && tbdate.Text !="")
            {
                // Tạo DTo
                DTO_NhapHang tv = new DTO_NhapHang(0, Int32.Parse(tbID.Text),tbName.Text, formatDeli, isChecked); // Vì ID tự tăng nên để ID số gì cũng dc
                // Them
                if (busNH.themNhapHang(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvNH.DataSource = busNH.getNhapHang(); // refresh datagridview
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
                DataGridViewRow row = dgvNH.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Tạo DTo
                DTO_NhapHang tv = new DTO_NhapHang(ID, Int32.Parse(tbID.Text),tbName.Text, formatDeli, isChecked); // Vì ID tự tăng nên để ID số gì cũng dc
                if (busNH.suaNhapHang(tv))
                {
                    MessageBox.Show("Sửa thành công");
                    dgvNCC.DataSource = busNCC.getNCC(); // refresh datagridview
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
            if (dgvNH.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvNH.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busNH.xoaNhapHang(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNH.DataSource = busNH.getNhapHang(); // refresh datagridview
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
