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
    public partial class frmMuonBangDia : Form
    {
        DBDataContext db = new DBDataContext();
        List<KhachHang> lstKH;
        List<BangDia> lstBD;
        ListViewItem lvi = new ListViewItem();
        List<HSMuon> lstHSM;
        //BangDia bdia = new BangDia();
        HSMuon_BangDia hsmuonBD = new HSMuon_BangDia();
        public frmMuonBangDia()
        {
            InitializeComponent();
        }

        private void frmMuonBangDia_Load(object sender, EventArgs e)
        {
            var kh = from temp in db.KhachHangs
                     select temp;
            lstKH = kh.ToList();
            dataKH.DataSource = lstKH;


            //ListViewItem lvi = new ListViewItem();
            //if (frmThemBangDia.mua == true)
            //{
            //    List<String> lst = frmThemBangDia.lstBDView;

            //    foreach (var s in lst)
            //    {
            //        listViewDaThemBD.Items.Add(s.ToString());
            //    }
            //}

            var b = from temp in db.BangDias
                    select temp;
            lstBD = b.ToList();
            foreach (var s in lstBD)
            {
                lvi = new ListViewItem(s.MaBang.ToString());
                lvi.SubItems.Add(s.TuaDe);
                lvi.SubItems.Add(s.ChuDe);
                lvi.SubItems.Add(s.TacGia);
                lvi.SubItems.Add(s.DonGia.ToString());
                lvi.SubItems.Add(s.SoLuong.ToString());
                listViewBangDia.Items.Add(lvi);
            }
            //listViewBangDia.SelectedItems[0].
            this.listViewDaThemBD.MouseWheel += new MouseEventHandler(listViewBangDiaDT_MouseWheel);


        }

        private void listViewBangDiaDT_MouseWheel(object sender, MouseEventArgs e)
        {

            //var sl = from slbd in db.BangDias
            //         select new { slbd.SoLuong };
            
            if (listViewDaThemBD.SelectedItems[0].Selected)
            {
                    
                if(e.Delta > 0)
                {
                    listViewDaThemBD.SelectedItems[0].SubItems[5].Text = (Int32.Parse(listViewDaThemBD.SelectedItems[0].SubItems[5].Text) + 1).ToString();
                    if (Int32.Parse(listViewDaThemBD.SelectedItems[0].SubItems[5].Text) > Int32.Parse(listViewBangDia.SelectedItems[0].SubItems[5].Text))
                    {
                        MessageBox.Show("Số lượng không được lớn hơn " + Int32.Parse(listViewBangDia.SelectedItems[0].SubItems[5].Text));
                        listViewDaThemBD.SelectedItems[0].SubItems[5].Text = listViewBangDia.SelectedItems[0].SubItems[5].Text;
                    }
                }
                else
                {
                    listViewDaThemBD.SelectedItems[0].SubItems[5].Text = (Int32.Parse(listViewDaThemBD.SelectedItems[0].SubItems[5].Text) - 1).ToString();
                    if (Int32.Parse(listViewDaThemBD.SelectedItems[0].SubItems[5].Text) < 0)
                    {
                        MessageBox.Show("Số lượng không đượcc nhỏ hơn 0 !");
                        listViewDaThemBD.SelectedItems[0].SubItems[5].Text = "1";
                    }
                }
                        

            }
            
            
        }

        private void dataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var chiso = dataKH.SelectedCells[0].RowIndex; // lay so dong

            txtMaKH.Text = lstKH[chiso].MaKH.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //016559396641A
        }

        private void comboxTenBang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewDaThemBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = listViewDaThemBD.Items.Count - 1; i >= 0; i--)
            {
                if (listViewDaThemBD.Items[i].Selected)
                {
                    if(MessageBox.Show("Bạn có muốn xóa không","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        listViewDaThemBD.Items[i].Remove();
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemBD in listViewBangDia.SelectedItems)
            {
                ListViewItem clone = (ListViewItem)itemBD.Clone();

                listViewDaThemBD.Items.Insert(GetInsertPosition(clone, listViewDaThemBD), clone);
            }
        }

        private static int GetInsertPosition(ListViewItem item, ListView target)
        {
            const int compareColumn = 1;
            foreach (ListViewItem targetItem in target.Items)
            {
                if (targetItem.SubItems[compareColumn].Text.CompareTo(item.SubItems[compareColumn].Text) > 0)
                {
                    return targetItem.Index;
                }
            }
            return target.Items.Count;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Mã Khách Hàng không thể để trống!");
                return;
            }
            
            if(listViewDaThemBD.Items.Count <= 0)
            {
                MessageBox.Show("Chưa có Băng Đĩa nào!");
                return;
            }
            HSMuon hsmuon = new HSMuon
            {
                //MaHSMuon = txtMaHSMuon.Text,
                NgayMuon = dateNgMuon.Value,
                NgayDuKien = dateNgDuKienTra.Value,
                MaKH = Int32.Parse(txtMaKH.Text),
                DaTra = false // chua tra
            };
            db.HSMuons.InsertOnSubmit(hsmuon);
            db.SubmitChanges();

            

            for(int i = 0; i < listViewDaThemBD.Items.Count  ;i++)
            {
               

               if(listViewDaThemBD.Columns[0].Text == "Mã Băng" )
               {
                   var hsm = from temp in db.HSMuons
                      select new {temp.MaHSMuon};
                   foreach (var s in hsm)
                   {


                       var mabang = Int32.Parse(listViewDaThemBD.Items[i].SubItems[0].Text);

                       int soluong = int.Parse(listViewDaThemBD.Items[i].SubItems[5].Text);

                       int slBangDia = Int32.Parse(listViewBangDia.Items[i].SubItems[5].Text);
                       int tongSoLuong = slBangDia - soluong;

                       String statement = "insert into HSMuon_BangDia values('" + s.MaHSMuon + "','" + mabang + "','" + soluong + "')";
                       db.ExecuteQuery<HSMuon_BangDia>(statement);

                       var kq = from temp in db.BangDias
                                where temp.MaBang == mabang
                                select temp;
                       foreach (var sl in kq)
                       {
                           sl.SoLuong = tongSoLuong;
                       }
                       db.SubmitChanges();
                       //string statementCN = "update BangDia set SoLuong=" + tongSoLuong + " where MaBang = '" + mabang + "'";//cap nhat lai so luong bang dia
                       //db.ExecuteQuery<BangDia>(statementCN);
                   }
               }

                
               
            }

            MessageBox.Show("Lưu Thành Công!!");

            

        }

        private void dateNgDuKienTra_ValueChanged(object sender, EventArgs e)
        {
            if(dateNgDuKienTra.Value.Year < dateNgMuon.Value.Year)
            {
                MessageBox.Show("Năm không được nhỏ hơn năm mượn !");
                
                dateNgDuKienTra.Value = dateNgMuon.Value;
                return;
            }

            if(dateNgDuKienTra.Value.Month < dateNgMuon.Value.Month)
            {
                MessageBox.Show("Tháng không được nhỏ hơn tháng mượn !");
                dateNgDuKienTra.Value = dateNgMuon.Value;
                return;
            }

            if(dateNgDuKienTra.Value.Day < dateNgMuon.Value.Day)
            {
                MessageBox.Show("Ngày không nhỏ hơn ngày hiện tại!");
                dateNgDuKienTra.Value = dateNgMuon.Value;
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dateNgDuKienTra.Value = DateTime.Now;
            txtMaKH.Text = "";
            listViewDaThemBD.Items.Clear();
            listViewDaThemBD.Update();
            listViewDaThemBD.Refresh();
        }

        private void txtMaHSMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHSMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearch.Text.Trim();
            var query = (from temp in db.KhachHangs
                         where temp.MaKH.ToString().StartsWith(searchValue) || temp.TenKH.StartsWith(searchValue) || temp.DT.ToString().StartsWith(searchValue)
                         select temp).ToList();
            dataKH.DataSource = query;
        }

        private void txtSearchBD_TextChanged(object sender, EventArgs e)
        {
            
            var result = lstBD.Where(x => x.MaBang == Int32.Parse(txtSearchBD.Text)).ToList();
        }

        
    }
}
