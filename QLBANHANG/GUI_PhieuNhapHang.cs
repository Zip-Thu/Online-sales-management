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
    public partial class fPhieuNhapHang : Form
    {
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_NhapHang busNH = new BUS_NhapHang();
        BUS_NhapHangDetails busCTNH = new BUS_NhapHangDetails();
        public fPhieuNhapHang()
        {
            InitializeComponent();
        }

        private void fPhieuNhapHang_Load(object sender, EventArgs e)
        {
            dgv_NH.DataSource = busNH.getNhapHang();
            dgvSP.DataSource = busSP.getSanPham();
            dgvPNH.DataSource = busCTNH.getCTNH();
        }

        private void dgv_NH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgv_NH.SelectedRows[0];
            {
                // Chuyển giá trị lên form
                tbNH_ID.Text = row.Cells[0].Value.ToString();
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
            }
        }

        private void dgvPNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgvPNH.SelectedRows[0];
            {
                // Chuyển giá trị lên for
                tbNH_ID.Text = row.Cells[0].Value.ToString();
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

            if (tbNH_ID.Text != "" && tbSP_ID.Text != "" && tbPrice.Text != "" && tbQuantity.Text != "" && tbName.Text != "" )
            {
                // Tạo DTo

                DTO_NhapHangDetails tv = new DTO_NhapHangDetails (Int16.Parse(tbNH_ID.Text), Int16.Parse(tbSP_ID.Text), Int32.Parse(tbPrice.Text),tbNote.Text, Int16.Parse(tbQuantity.Text), Int32.Parse(lbSum.Text), tbName.Text) ; // Vì ID tự tăng nên để ID số gì cũng dc
                // Them
                if (busCTNH.themCTNH(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvPNH.DataSource = busCTNH.getCTNH(); // refresh datagridview

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
            // Kiểm tra nếu có chọn table rồi
            if (dgvPNH.SelectedRows.Count > 0)
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

                if (tbNH_ID.Text != "" && tbSP_ID.Text != "" && tbPrice.Text != "" && tbQuantity.Text != "" && tbName.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvPNH.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Tạo DTo
                    DTO_NhapHangDetails tsp = new DTO_NhapHangDetails(Int16.Parse(tbNH_ID.Text), Int16.Parse(tbSP_ID.Text), Int32.Parse(tbPrice.Text), tbNote.Text, Int16.Parse(tbQuantity.Text), Int32.Parse(lbSum.Text), tbName.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                     //Sua
                    if (busCTNH.suaCTNH(tsp))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvPNH.DataSource = busCTNH.getCTNH(); // refresh datagridview
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
            if (dgvPNH.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvPNH.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busCTNH.xoaCTNH(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvPNH.DataSource = busCTNH.getCTNH(); // refresh datagridview
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
