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
    public partial class fHoaDon : Form
    {
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_DonHang busDH = new BUS_DonHang();
        BUS_HoaDon busHD = new BUS_HoaDon();
        public fHoaDon()
        {
            InitializeComponent();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            dgv_DH.DataSource = busDH.getDonHang();
            dgvSP.DataSource = busSP.getSanPham();
            dgvHD.DataSource = busHD.getHD();
        }

        private void dgv_DH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgv_DH.SelectedRows[0];
            {
                // Chuyển giá trị lên form
                tbOrderID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgvSP.SelectedRows[0];
            {
                // Chuyển giá trị lên form
                tbSP_ID.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbPrice.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgvHD.SelectedRows[0];
            {
                // Chuyển giá trị lên form
                tbOrderID.Text = row.Cells[0].Value.ToString();
                tbSP_ID.Text = row.Cells[1].Value.ToString();
                tbPrice.Text = row.Cells[2].Value.ToString();
                tbNote.Text = row.Cells[3].Value.ToString();
                tbQuantity.Text = row.Cells[4].Value.ToString();
                lbSum.Text = row.Cells[5].Value.ToString();
                tbName.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào và thực hiện tính toán
            if (decimal.TryParse(tbQuantity.Text, out decimal quantity) &&
                decimal.TryParse(tbPrice.Text, out decimal price))
            {
                decimal sumTotal = quantity * price;
                lbSum.Text = sumTotal.ToString(); // Định dạng số tiền
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng định dạng Số Lượng và Giá.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Int16.Parse(tbQuantity.Text) > Int32.Parse(dgvSP.SelectedRows[0].Cells[4].Value.ToString()))
            {
                MessageBox.Show("Xin hãy nhập lại số lượng!");
                return;
            }

            if (tbOrderID.Text != "" && tbSP_ID.Text != "" && tbPrice.Text != "" && tbQuantity.Text != "" && tbName.Text != "")
            {
                if (Int32.Parse(tbQuantity.Text) <0)
                {
                    MessageBox.Show("Xin hãy nhập lại!");
                    return;
                }    
                // Tạo DTo

                DTO_HoaDon tv = new DTO_HoaDon(Int16.Parse(tbOrderID.Text), Int16.Parse(tbSP_ID.Text), Int32.Parse(tbPrice.Text), tbNote.Text, Int16.Parse(tbQuantity.Text), Int32.Parse(lbSum.Text), tbName.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                // Them
                if (busHD.themHoaDon(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvHD.DataSource = busHD.getHD(); // refresh datagridview

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
            // Kiểm tra đầu vào và thực hiện tính toán
            if (decimal.TryParse(tbQuantity.Text, out decimal quantity) &&
                decimal.TryParse(tbPrice.Text, out decimal price))
            {
                decimal sumTotal = quantity * price;
                lbSum.Text = sumTotal.ToString(); // Định dạng số tiền
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng định dạng Số Lượng và Giá.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kiểm tra nếu có chọn table rồi
            if (dgvHD.SelectedRows.Count > 0)
            {
                if (tbOrderID.Text != "" && tbSP_ID.Text != "" && tbPrice.Text != "" && tbQuantity.Text != "" && tbName.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvHD.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Tạo DTo
                    DTO_HoaDon tsp = new DTO_HoaDon(Int16.Parse(tbOrderID.Text), Int16.Parse(tbSP_ID.Text), Int32.Parse(tbPrice.Text), tbNote.Text, Int16.Parse(tbQuantity.Text), Int32.Parse(lbSum.Text), tbName.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                                                                                                                                                                                                                                         //Sua
                    if (busHD.suaHoaDon(tsp))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvHD.DataSource = busHD.getHD(); // refresh datagridview
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
                MessageBox.Show("Hãy chọn sản phẩm muốn sửa");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvHD.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvHD.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busHD.xoaHoaDon(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHD.DataSource = busHD.getHD(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
