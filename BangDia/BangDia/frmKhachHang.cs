using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangDia
{
    public partial class frmKhachHang : Form
    {
        DBDataContext db = new DBDataContext();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        List<KhachHang> lst;
        private void Form1_Load(object sender, EventArgs e)
        {
            var kh = from temp in db.KhachHangs
                     select temp;
            lst = kh.ToList();
   
            dataKH.DataSource = lst;
            dataKH.ClearSelection();
            Clear();
        }

        private void dataKH_SelectionChanged(object sender, EventArgs e)
        {
        }
        List<KhachHang> t = new List<KhachHang>();
        int chiso;
        private void dataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            chiso = dataKH.SelectedCells[0].RowIndex; // lay so dong

            txtMaKH.Text = lst[chiso].MaKH.ToString();
            txtTenKH.Text = lst[chiso].TenKH.ToString();
            txtCMND.Text = lst[chiso].CMND.ToString();
            txtDiaChi.Text = lst[chiso].DiaChi.ToString();
            txtDT.Text = lst[chiso].DT.ToString();
            //var bang = (DataTable)dataKH.DataSource;
            setSeting(true);
           
            //txtTenKH.Text = lst[]
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenKH.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                txtTenKH.Focus();
                return;
            }
            if(txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên Khách Hàng!");
                txtTenKH.Focus();
                return;
            }
            if(txtCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập CMND!");
                txtCMND.Focus();
                return;
            }
            KhachHang kh = new KhachHang{
            TenKH = txtTenKH.Text,
            CMND = int.Parse(txtCMND.Text),
            DiaChi = txtDiaChi.Text,
            DT = txtDT.Text,
            };

            db.KhachHangs.InsertOnSubmit(kh);
            db.SubmitChanges();
            var kh1 = from temp in db.KhachHangs
                     select temp;
            lst = kh1.ToList();
            dataKH.DataSource = lst;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                txtTenKH.Focus();
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên Khách Hàng!");
                txtTenKH.Focus();
                return;
            }
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập CMND!");
                txtCMND.Focus();
                return;
            }
            var kq = (from temp in db.KhachHangs
                     where temp.MaKH == Int32.Parse(txtMaKH.Text)
                      select temp).Single();
            kq.TenKH = txtTenKH.Text;
            kq.CMND = int.Parse(txtCMND.Text);
            kq.DiaChi = txtDiaChi.Text;
            kq.DT = txtDT.Text;
            db.SubmitChanges();
            var kh1 = from temp in db.KhachHangs
                      select temp;
            lst = kh1.ToList();
            dataKH.DataSource = lst;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.KhachHangs.DeleteOnSubmit(lst[chiso]);
                db.SubmitChanges();
                var kh1 = from temp in db.KhachHangs
                          select temp;
                lst = kh1.ToList();
                dataKH.DataSource = lst;
                btnClear_Click(sender,e);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            //dataKH.ClearSelection();
        }

        public void Clear()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
            dataKH.ClearSelection();
            setSeting(false);
        }

        private void setSeting(bool status)
        {
            btnThem.Enabled = !status;
            btnSua.Enabled = status;
            btnXoa.Enabled = status;
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            
            


        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void txtDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
