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
    public partial class frmThongKe : Form
    {
        DBDataContext db = new DBDataContext();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsThongKe.BangDia' table. You can move, or remove it, as needed.
           

            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //var q = from temp in db.
            try
            {
                
                BangDiaBindingSource.DataSource = db.BangDias.ToList();
                this.reportViewerBD.RefreshReport();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
        }
    }
}
