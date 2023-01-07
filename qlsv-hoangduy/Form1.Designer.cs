
namespace qlsv_hoangduy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNgay = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.qlsvDataSet = new qlsv_hoangduy.qlsvDataSet();
            this.qlsvDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsvDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qlsvDataSet1 = new qlsv_hoangduy.qlsvDataSet1();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new qlsv_hoangduy.qlsvDataSet1TableAdapters.lopTableAdapter();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.cboLopLoc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgSinhVien = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiếp nhận sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "MSSV";
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(91, 115);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(206, 20);
            this.txtMssv.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(91, 168);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(206, 20);
            this.txtHoTen.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Họ Tên";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.AllowDrop = true;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(91, 216);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(206, 21);
            this.cboGioiTinh.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Giới tính";
            // 
            // cboNgay
            // 
            this.cboNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgay.FormattingEnabled = true;
            this.cboNgay.Items.AddRange(new object[] {
            "Ngày"});
            this.cboNgay.Location = new System.Drawing.Point(91, 262);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Size = new System.Drawing.Size(63, 21);
            this.cboNgay.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ngày sinh";
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "Tháng"});
            this.cboThang.Location = new System.Drawing.Point(160, 262);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(74, 21);
            this.cboThang.TabIndex = 14;
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "Năm"});
            this.cboNam.Location = new System.Drawing.Point(240, 262);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(57, 21);
            this.cboNam.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(91, 307);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(206, 20);
            this.txtDiaChi.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Địa chỉ";
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHinhAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinhAnh.ErrorImage = null;
            this.pbHinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("pbHinhAnh.Image")));
            this.pbHinhAnh.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbHinhAnh.InitialImage")));
            this.pbHinhAnh.Location = new System.Drawing.Point(344, 52);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(268, 282);
            this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinhAnh.TabIndex = 18;
            this.pbHinhAnh.TabStop = false;
            this.pbHinhAnh.Click += new System.EventHandler(this.pbHinhAnh_Click);
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(353, 340);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.ReadOnly = true;
            this.txtHinhAnh.Size = new System.Drawing.Size(187, 20);
            this.txtHinhAnh.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hình ảnh";
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Location = new System.Drawing.Point(546, 338);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(75, 23);
            this.btnTaiAnh.TabIndex = 21;
            this.btnTaiAnh.Text = "Tải ảnh";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // qlsvDataSet
            // 
            this.qlsvDataSet.DataSetName = "qlsvDataSet";
            this.qlsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlsvDataSetBindingSource
            // 
            this.qlsvDataSetBindingSource.DataSource = this.qlsvDataSet;
            this.qlsvDataSetBindingSource.Position = 0;
            // 
            // qlsvDataSetBindingSource1
            // 
            this.qlsvDataSetBindingSource1.DataSource = this.qlsvDataSet;
            this.qlsvDataSetBindingSource1.Position = 0;
            // 
            // qlsvDataSet1
            // 
            this.qlsvDataSet1.DataSetName = "qlsvDataSet1";
            this.qlsvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.qlsvDataSet1;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(6, 72);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(430, 40);
            this.btnThemMoi.TabIndex = 23;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // cboLopLoc
            // 
            this.cboLopLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopLoc.FormattingEnabled = true;
            this.cboLopLoc.Location = new System.Drawing.Point(49, 62);
            this.cboLopLoc.Name = "cboLopLoc";
            this.cboLopLoc.Size = new System.Drawing.Size(273, 21);
            this.cboLopLoc.TabIndex = 24;
            this.cboLopLoc.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 192);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu sinh viên";
            // 
            // dtgSinhVien
            // 
            this.dtgSinhVien.AllowUserToAddRows = false;
            this.dtgSinhVien.AllowUserToDeleteRows = false;
            this.dtgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSinhVien.Location = new System.Drawing.Point(6, 19);
            this.dtgSinhVien.Name = "dtgSinhVien";
            this.dtgSinhVien.ReadOnly = true;
            this.dtgSinhVien.RowTemplate.Height = 30;
            this.dtgSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSinhVien.Size = new System.Drawing.Size(1133, 167);
            this.dtgSinhVien.TabIndex = 0;
            this.dtgSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSinhVien_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(6, 123);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(430, 40);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(430, 40);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(740, 72);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(273, 20);
            this.txtTimKiem.TabIndex = 30;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboLopLoc);
            this.groupBox2.Location = new System.Drawing.Point(691, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 101);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ lọc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThemMoi);
            this.groupBox3.Location = new System.Drawing.Point(691, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 225);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công cụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(6, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(430, 40);
            this.btnLamMoi.TabIndex = 28;
            this.btnLamMoi.Text = "Làm mới form";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(91, 66);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(206, 21);
            this.cboLop.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 622);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTaiAnh);
            this.Controls.Add(this.txtHinhAnh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbHinhAnh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.cboNgay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.BindingSource qlsvDataSetBindingSource;
        private qlsvDataSet qlsvDataSet;
        private System.Windows.Forms.BindingSource qlsvDataSetBindingSource1;
        private qlsvDataSet1 qlsvDataSet1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private qlsvDataSet1TableAdapters.lopTableAdapter lopTableAdapter;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.ComboBox cboLopLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgSinhVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnLamMoi;
    }
}

