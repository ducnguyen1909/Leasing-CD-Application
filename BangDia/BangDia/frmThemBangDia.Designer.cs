namespace BangDia
{
    partial class frmThemBangDia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewBangDia = new System.Windows.Forms.ListView();
            this.lstViewMaBang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewTuaDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewChuDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewBangDia
            // 
            this.listViewBangDia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstViewMaBang,
            this.lstViewTuaDe,
            this.lstViewChuDe,
            this.lstViewTacGia,
            this.lstViewDonGia,
            this.lstViewSoLuong});
            this.listViewBangDia.FullRowSelect = true;
            this.listViewBangDia.GridLines = true;
            this.listViewBangDia.Location = new System.Drawing.Point(41, 54);
            this.listViewBangDia.MultiSelect = false;
            this.listViewBangDia.Name = "listViewBangDia";
            this.listViewBangDia.Size = new System.Drawing.Size(432, 172);
            this.listViewBangDia.TabIndex = 0;
            this.listViewBangDia.UseCompatibleStateImageBehavior = false;
            this.listViewBangDia.View = System.Windows.Forms.View.Details;
            this.listViewBangDia.SelectedIndexChanged += new System.EventHandler(this.listViewBangDia_SelectedIndexChanged);
            // 
            // lstViewMaBang
            // 
            this.lstViewMaBang.Text = "Mã Băng";
            // 
            // lstViewTuaDe
            // 
            this.lstViewTuaDe.Text = "Tựa Đề";
            // 
            // lstViewChuDe
            // 
            this.lstViewChuDe.Text = "Chủ Đề";
            // 
            // lstViewTacGia
            // 
            this.lstViewTacGia.Text = "Tác Giả";
            // 
            // lstViewDonGia
            // 
            this.lstViewDonGia.Text = "Đơn Giá";
            // 
            // lstViewSoLuong
            // 
            this.lstViewSoLuong.Text = "Số Lượng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(65, 247);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmThemBangDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 300);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listViewBangDia);
            this.Name = "frmThemBangDia";
            this.Text = "frmThemBangDia";
            this.Load += new System.EventHandler(this.frmThemBangDia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBangDia;
        private System.Windows.Forms.ColumnHeader lstViewMaBang;
        private System.Windows.Forms.ColumnHeader lstViewTuaDe;
        private System.Windows.Forms.ColumnHeader lstViewChuDe;
        private System.Windows.Forms.ColumnHeader lstViewTacGia;
        private System.Windows.Forms.ColumnHeader lstViewDonGia;
        private System.Windows.Forms.ColumnHeader lstViewSoLuong;
        private System.Windows.Forms.Button btnThem;
    }
}