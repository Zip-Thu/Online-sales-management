using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS_QUANLY;

namespace QLBANHANG
{
    public partial class fLogin : Form
    {
        DTO_TaiKhoan taikhoan = new DTO_TaiKhoan();
        BUS_TaiKhoan TKBUS = new BUS_TaiKhoan();

        public fLogin()
        {
            InitializeComponent();
        }



        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            taikhoan.STaiKhoan = tbNameLogin.Text;
            taikhoan.SMatKhau = tbPass.Text;

            string getuser = TKBUS.CheckLogic(taikhoan);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }


            fTableManager f = new fTableManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
