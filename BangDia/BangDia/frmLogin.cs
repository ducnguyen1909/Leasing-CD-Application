using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangDia
{
    public partial class frmLogin : Form
    {
        DBDataContext db = new DBDataContext();
        //List<TaiKhoan> lstTK;
        public frmLogin()
        {
            InitializeComponent();
            
            //lstTK = kq;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.Text.Equals("") || txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show(@"Thông tin đăng nhập thiếu", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                //txtDangNhap.Focus();
            }
           
            var kq = (from temp in db.TaiKhoans
                        where temp.TenDN == txtDangNhap.Text.Trim() && temp.MatKhau == txtMatKhau.Text
                        select temp).SingleOrDefault();
            if(kq == null)
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
            else
            {
                frmMain frmM = new frmMain();
                this.Hide();
                frmM.Show();
            }
        }
    }
}
