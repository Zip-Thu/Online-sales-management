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

namespace QLBANHANG
{
    public partial class fSanPham : Form
    {
        BUS_SanPham busSP = new BUS_SanPham();
        public fSanPham()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if ( tbName.Text != "" && tbNote.Text != "" && tbPrice.Text != "" && tbQuantity.Text != "")
            {
                // Tạo DTo
                
                DTO_SanPham tv = new DTO_SanPham(0, tbName.Text, tbNote.Text, Int32.Parse(tbPrice.Text),Int16.Parse(tbQuantity.Text)); // Vì ID tự tăng nên để ID số gì cũng dc
                // Them
                if (busSP.themSanPham(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvTSP.DataSource = busSP.getSanPham(); // refresh datagridview
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


        private void GUI_SanPham_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = busSP.getSanPham(); // get Sản Phẩm
        }



        private void btEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvSP.SelectedRows.Count > 0)
            {
                if ( tbName.Text != "" && tbNote.Text != "" && tbPrice.Text != "" && tbQuantity.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvSP.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Tạo DTo
                    DTO_SanPham tsp = new DTO_SanPham(ID, tbName.Text,  tbNote.Text, Int32.Parse(tbPrice.Text), Int16.Parse(tbQuantity.Text)); 
                    // Sửa
                    if (busSP.suaSanPham(tsp))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvSP.DataSource = busSP.getSanPham(); // refresh datagridview
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

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvSP.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvSP.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busSP.xoaSanPham(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvSP.DataSource = busSP.getSanPham(); // refresh datagridview
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

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgvSP.SelectedRows[0];
            {
                // Chuyển giá trị lên form
                tbName.Text = row.Cells[1].Value.ToString();
                tbNote.Text = row.Cells[2].Value.ToString();
                tbPrice.Text = row.Cells[3].Value.ToString();
                tbQuantity.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
