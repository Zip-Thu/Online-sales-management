using BUS_QUANLY;
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

namespace QLBANHANG
{
    public partial class fNewAccount : Form
    {
        BUS_NewAccount busTK = new BUS_NewAccount();
        public fNewAccount()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbNameLogin.Text != "" && tbPass.Text != "" && tbID.Text != "" && tbQuyen.Text != "")
            {
                // Tạo DTo
                DTO_NewAccount tv = new DTO_NewAccount (Int16.Parse(tbID.Text), tbNameLogin.Text, tbPass.Text, Int16.Parse(tbQuyen.Text)); // Vì ID tự tăng nên để ID số gì cũng dc
                // Them
                if (busTK.themTK(tv))
                {
                    MessageBox.Show("Thêm thành công");
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
    }
}
