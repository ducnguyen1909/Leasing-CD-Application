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
    public partial class frmThanhToan : Form
    {
        DBDataContext db = new DBDataContext();
        List<HSMuon> lstHSM;
        List<BangDia> lstBD;
        ListViewItem lvi;
        double tongtien;
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            var hsmuon = from temp in db.HSMuons
                         join kh in db.KhachHangs on temp.MaKH equals kh.MaKH
                         select new { temp.MaHSMuon, temp.NgayMuon, temp.NgayDuKien, temp.DaTra , kh.MaKH};
            
            dataHSMuon.DataSource = hsmuon;

           
        }

        private void dataHSMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var hsmuon = from temp in db.HSMuons
                         join kh in db.KhachHangs on temp.MaKH equals kh.MaKH
                         select new { temp.MaHSMuon, temp.NgayMuon, temp.NgayDuKien, kh.MaKH };
           
            //var chiso = dataHSMuon.SelectedCells[0].RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataHSMuon.Rows[e.RowIndex];
                txtMaHSMuon.Text = row.Cells["MaHSMuon"].Value.ToString();
                dateNgMuon.Value = (DateTime)row.Cells["NgayMuon"].Value;
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                //txtMaHSMuon.Text = .MaHSMuon.ToString();
                //dateNgMuon.Value = (DateTime)lstHSM[chiso].NgayMuon;
                //txtMaKH.Text = lstHSM[chiso].MaKH.ToString();
                if(dataHSMuon.SelectedRows[0].Selected)
                {
                    listViewDiaDaMua.Items.Clear();
                    listViewDiaDaMua.Update();
                    listViewDiaDaMua.Refresh();
                    this.capnhat();
                }
            }
           
           
        }

        private void capnhat()
        {
            var bdm = from bang in db.BangDias
                      join hsmBD in db.HSMuon_BangDias on bang.MaBang equals hsmBD.MaBang
                      join hsm in db.HSMuons on hsmBD.MaHSMuon equals hsm.MaHSMuon
                      where hsm.MaHSMuon == Int32.Parse(txtMaHSMuon.Text)
                      select new { bang.MaBang, bang.TuaDe, bang.ChuDe, bang.TacGia, hsmBD.SoLuongMua, bang.DonGia };
            foreach (var s in bdm)
            {
                lvi = new ListViewItem(s.MaBang.ToString());
                lvi.SubItems.Add(s.TuaDe);
                lvi.SubItems.Add(s.ChuDe);
                lvi.SubItems.Add(s.TacGia);
                lvi.SubItems.Add(s.SoLuongMua.ToString());
                lvi.SubItems.Add(s.DonGia.ToString());
                listViewDiaDaMua.Items.Add(lvi);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var tinhTrang = from temp in db.HSMuons
                            where Int32.Parse(txtMaHSMuon.Text) == temp.MaHSMuon
                            select new { temp.DaTra , temp.MaHSMuon};
            foreach(var t in tinhTrang)
            {
                if (t.DaTra == true)
                {
                    MessageBox.Show("Hồ Sơ Mượn: "+t.MaHSMuon+" này đã thanh toán","Thông Báo",MessageBoxButtons.OK);
                    return;
                }
            }
            TimeSpan dis = dateNgTra.Value.Subtract(dateNgMuon.Value);
            int days = (int)dis.TotalDays;
            if(days == 0)
            {
                days = 1;
            }
            for (int i = 0; i < listViewDiaDaMua.Items.Count; i++)
            {
                var mabang = Int32.Parse(listViewDiaDaMua.Items[i].SubItems[0].Text);

                int sl = Int32.Parse(listViewDiaDaMua.Items[i].SubItems[4].Text);
                double dongia = Double.Parse(listViewDiaDaMua.Items[i].SubItems[5].Text);
                double kq = dongia * sl;
                tongtien = tongtien + kq;

                var bangdia = from temp in db.BangDias
                              where temp.MaBang == mabang
                              select temp;
                foreach(var x in bangdia)
                {
                    x.SoLuong = x.SoLuong + sl;
                }
                db.SubmitChanges();

                
            }


            tongtien = tongtien * days;
            DoanhThu dt = new DoanhThu
            {
                //MaDT = txtMaDT.Text,
                NgayTra = dateNgTra.Value,
                TongTien = Decimal.Parse(tongtien.ToString()),
                MaHSMuon = Int32.Parse(txtMaHSMuon.Text),
                
            };
            db.DoanhThus.InsertOnSubmit(dt);
            db.SubmitChanges();
            var hsDaTra = from temp in db.HSMuons
                          where Int32.Parse(txtMaHSMuon.Text) == temp.MaHSMuon
                          select temp;
            foreach (var dtra in hsDaTra)
            {
                dtra.DaTra = true;
            }
            db.SubmitChanges();
            MessageBox.Show("Ngày Mượn: " + dateNgMuon.Value.ToShortDateString() + "\n" +
                            "Ngày Trả: " + dateNgTra.Value.ToShortDateString() + "\n" +
                            "Tổng số ngày mượn: " + days + "\n" +
                            "Tổng Tiền: " + tongtien.ToString() + "\n" +
                            "Mã HS Mượn: " + txtMaHSMuon.Text);
        }

        private void dataHSMuon_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHSMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
               
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearch.Text.Trim();
            var query = (from temp in db.HSMuons
                         where temp.MaKH.ToString().StartsWith(searchValue)
                         select temp).ToList();
            dataHSMuon.DataSource = query;
        }
    }
}
