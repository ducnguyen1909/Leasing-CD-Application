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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMain frmM = new frmMain();
            frmKhachHang frmKH = new frmKhachHang();
            //this.Hide();
            frmKH.Show();
            
        }

        private void ghiNhậnMượnĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonBangDia frmMBD = new frmMuonBangDia();
            //this.Hide();
            frmMBD.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhToan frmTT = new frmThanhToan();
            //this.Hide();
            frmTT.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frmTK = new frmThongKe();
            frmTK.Show();
        }
    }
}
