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
    public partial class fNCC : Form
    {
        BUS_NCC busNCC = new BUS_NCC();

        public fNCC()
        {
            InitializeComponent();
        }

        //THÊM
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != "" && tbName.Text != "" && tbSDT.Text != "" && tbAddress.Text != "")
            {
                // Tạo DTo
                DTO_NCC tv = new DTO_NCC(0, tbName.Text, tbSDT.Text, tbEmail.Text, tbAddress.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                // Them
                if (busNCC.themNCC(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvTNCC.DataSource = busNCC.getNCC(); // refresh datagridview
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

        private void GUI_NCC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busNCC.getNCC(); // get NCC
        }

        // SỬA
        private void btEdit_Click(object sender, EventArgs e)
        {

            // Kiểm tra nếu có chọn table rồi
            if (dgvNCC.SelectedRows.Count > 0)
            {
                if (tbEmail.Text != "" && tbName.Text != "" && tbSDT.Text != "" && tbAddress.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvNCC.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Tạo DTo
                    DTO_NCC tncc = new DTO_NCC(ID, tbName.Text, tbSDT.Text, tbEmail.Text, tbAddress.Text);
                    // Sửa
                    if (busNCC.suaNCC(tncc))
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
            else
            {
                MessageBox.Show("Hãy chọn Nhà Cung Cấp muốn sửa");
            }
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgvNCC.SelectedRows[0];
            // Chuyển giá trị lên form
            tbName.Text = row.Cells[1].Value.ToString();
            tbSDT.Text = row.Cells[2].Value.ToString();
            tbEmail.Text = row.Cells[3].Value.ToString();
            tbAddress.Text = row.Cells[4].Value.ToString();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvNCC.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvNCC.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busNCC.xoaNCC(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNCC.DataSource = busNCC.getNCC(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn Nhà Cung Cấp muốn xóa");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
