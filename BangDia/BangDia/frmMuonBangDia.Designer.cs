namespace BangDia
{
    partial class frmMuonBangDia
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataKH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNgDuKienTra = new System.Windows.Forms.DateTimePicker();
            this.dateNgMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.da = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDaThemBD = new System.Windows.Forms.ListView();
            this.viewMaBang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewTuaDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewChuDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewSoLuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBangDia = new System.Windows.Forms.ListView();
            this.lstViewMaBang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewTuaDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewChuDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchBD = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 37);
            this.button1.TabIndex = 33;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataKH
            // 
            this.dataKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKH.Location = new System.Drawing.Point(9, 26);
            this.dataKH.Margin = new System.Windows.Forms.Padding(4);
            this.dataKH.Name = "dataKH";
            this.dataKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKH.Size = new System.Drawing.Size(584, 204);
            this.dataKH.TabIndex = 0;
            this.dataKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKH_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataKH);
            this.groupBox1.Location = new System.Drawing.Point(454, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(609, 238);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Khách Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateNgDuKienTra
            // 
            this.dateNgDuKienTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgDuKienTra.Location = new System.Drawing.Point(199, 185);
            this.dateNgDuKienTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgDuKienTra.Name = "dateNgDuKienTra";
            this.dateNgDuKienTra.Size = new System.Drawing.Size(211, 24);
            this.dateNgDuKienTra.TabIndex = 29;
            this.dateNgDuKienTra.ValueChanged += new System.EventHandler(this.dateNgDuKienTra_ValueChanged);
            // 
            // dateNgMuon
            // 
            this.dateNgMuon.Enabled = false;
            this.dateNgMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgMuon.Location = new System.Drawing.Point(199, 136);
            this.dateNgMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgMuon.Name = "dateNgMuon";
            this.dateNgMuon.Size = new System.Drawing.Size(211, 24);
            this.dateNgMuon.TabIndex = 28;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(199, 258);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(211, 24);
            this.txtMaKH.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã Khách Hàng:";
            // 
            // da
            // 
            this.da.AutoSize = true;
            this.da.Location = new System.Drawing.Point(59, 193);
            this.da.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(128, 18);
            this.da.TabIndex = 25;
            this.da.Text = "Ngày Dự Kiến Trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ngày Mượn:";
            // 
            // listViewDaThemBD
            // 
            this.listViewDaThemBD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.viewMaBang,
            this.viewTuaDe,
            this.viewChuDe,
            this.viewTacGia,
            this.viewDonGia,
            this.viewSoLuon});
            this.listViewDaThemBD.FullRowSelect = true;
            this.listViewDaThemBD.Location = new System.Drawing.Point(662, 66);
            this.listViewDaThemBD.Margin = new System.Windows.Forms.Padding(4);
            this.listViewDaThemBD.MultiSelect = false;
            this.listViewDaThemBD.Name = "listViewDaThemBD";
            this.listViewDaThemBD.Size = new System.Drawing.Size(552, 192);
            this.listViewDaThemBD.TabIndex = 34;
            this.listViewDaThemBD.UseCompatibleStateImageBehavior = false;
            this.listViewDaThemBD.View = System.Windows.Forms.View.Details;
            this.listViewDaThemBD.SelectedIndexChanged += new System.EventHandler(this.listViewDaThemBD_SelectedIndexChanged);
            // 
            // viewMaBang
            // 
            this.viewMaBang.Text = "Mã Băng";
            // 
            // viewTuaDe
            // 
            this.viewTuaDe.Text = "Tựa Đề";
            // 
            // viewChuDe
            // 
            this.viewChuDe.Text = "Chủ Đề";
            // 
            // viewTacGia
            // 
            this.viewTacGia.Text = "Tác Giả";
            // 
            // viewDonGia
            // 
            this.viewDonGia.Text = "Đơn Giá";
            // 
            // viewSoLuon
            // 
            this.viewSoLuon.Text = "Số Lượng";
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
            this.listViewBangDia.Location = new System.Drawing.Point(8, 68);
            this.listViewBangDia.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBangDia.MultiSelect = false;
            this.listViewBangDia.Name = "listViewBangDia";
            this.listViewBangDia.Size = new System.Drawing.Size(548, 192);
            this.listViewBangDia.TabIndex = 35;
            this.listViewBangDia.UseCompatibleStateImageBehavior = false;
            this.listViewBangDia.View = System.Windows.Forms.View.Details;
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
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(579, 166);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 37);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "-";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtSearchBD);
            this.groupBox2.Controls.Add(this.listViewBangDia);
            this.groupBox2.Controls.Add(this.listViewDaThemBD);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(25, 361);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1233, 266);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn Băng Đĩa";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BangDia.Properties.Resources.search_clipart_yckKqbRei;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(170, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 24);
            this.panel2.TabIndex = 43;
            // 
            // txtSearchBD
            // 
            this.txtSearchBD.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSearchBD.Location = new System.Drawing.Point(8, 31);
            this.txtSearchBD.Name = "txtSearchBD";
            this.txtSearchBD.Size = new System.Drawing.Size(156, 24);
            this.txtSearchBD.TabIndex = 42;
            this.txtSearchBD.TextChanged += new System.EventHandler(this.txtSearchBD_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 299);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 40);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(65, 299);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 40);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(436, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 37);
            this.label6.TabIndex = 39;
            this.label6.Text = "GHI NHẬN MƯỢN ĐĨA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BangDia.Properties.Resources.search_clipart_yckKqbRei;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1041, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 18);
            this.panel1.TabIndex = 41;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSearch.Location = new System.Drawing.Point(879, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 24);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmMuonBangDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1236, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateNgDuKienTra);
            this.Controls.Add(this.dateNgMuon);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.da);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMuonBangDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghi Nhận Mượn Đĩa";
            this.Load += new System.EventHandler(this.frmMuonBangDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgDuKienTra;
        private System.Windows.Forms.DateTimePicker dateNgMuon;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label da;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ListView listViewDaThemBD;
        private System.Windows.Forms.ColumnHeader viewMaBang;
        private System.Windows.Forms.ColumnHeader viewTuaDe;
        private System.Windows.Forms.ColumnHeader viewChuDe;
        private System.Windows.Forms.ColumnHeader viewTacGia;
        private System.Windows.Forms.ColumnHeader viewDonGia;
        private System.Windows.Forms.ColumnHeader viewSoLuon;
        private System.Windows.Forms.ListView listViewBangDia;
        private System.Windows.Forms.ColumnHeader lstViewMaBang;
        private System.Windows.Forms.ColumnHeader lstViewTuaDe;
        private System.Windows.Forms.ColumnHeader lstViewChuDe;
        private System.Windows.Forms.ColumnHeader lstViewTacGia;
        private System.Windows.Forms.ColumnHeader lstViewDonGia;
        private System.Windows.Forms.ColumnHeader lstViewSoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchBD;
    }
}