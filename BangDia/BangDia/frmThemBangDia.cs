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
    public partial class frmThemBangDia : Form
    {
        DBDataContext db = new DBDataContext();
        List<BangDia> lstBD;
        ListViewItem lvi;
        public static List<String> lstBDView = new List<String>();
        public static bool mua;
        public frmThemBangDia()
        {
            InitializeComponent();
        }

        private void listViewBangDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThemBangDia_Load(object sender, EventArgs e)
        {
            var b = from temp in db.BangDias
                     select temp;
            lstBD = b.ToList();
            foreach(var s in lstBD)
            {
                //lvi = new ListViewItem(s.MaBang);
                lvi.SubItems.Add(s.TuaDe);
                lvi.SubItems.Add(s.ChuDe);
                lvi.SubItems.Add(s.TacGia);
                lvi.SubItems.Add(s.DonGia.ToString());
                lvi.SubItems.Add("0");
                listViewBangDia.Items.Add(lvi);
            }
            //listViewBangDia.SelectedItems[0].
            this.listViewBangDia.MouseWheel += new MouseEventHandler(listViewBangDia_MouseWheel);
        }

        private void listViewBangDia_MouseWheel(object sender, MouseEventArgs e)
        {
            if (listViewBangDia.SelectedItems[0].Selected)
            {
                if (e.Delta > 0)
                {
                    listViewBangDia.SelectedItems[0].SubItems[5].Text = (Int32.Parse(listViewBangDia.SelectedItems[0].SubItems[5].Text) + 1).ToString();
                }
                else
                    listViewBangDia.SelectedItems[0].SubItems[5].Text = (Int32.Parse(listViewBangDia.SelectedItems[0].SubItems[5].Text) - 1).ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (listViewBangDia.SelectedItems[0].Selected)
            {
                var sl = (from s in db.BangDias
                         //where s.MaBang == listViewBangDia.SelectedItems[0].SubItems[0].Text
                         select s.SoLuong).Single();
                if(sl >=  Int32.Parse(listViewBangDia.SelectedItems[0].SubItems[5].Text))
                {
                    DialogResult dr = MessageBox.Show(@"Thêm Thành Công",@"Thông Báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    if(dr == DialogResult.OK)
                    {
                        mua = true;
                        lstBDView.Add(listViewBangDia.SelectedItems[0].SubItems[0].ToString());
                        lstBDView.Add(listViewBangDia.SelectedItems[0].SubItems[1].ToString());
                        lstBDView.Add(listViewBangDia.SelectedItems[0].SubItems[2].ToString());
                        lstBDView.Add(listViewBangDia.SelectedItems[0].SubItems[3].ToString());
                        lstBDView.Add(listViewBangDia.SelectedItems[0].SubItems[4].ToString());
                        lstBDView.Add(listViewBangDia.SelectedItems[0].SubItems[5].ToString());
                        this.Hide();
                    }
                }
           
                
            }

        }
    }
}
