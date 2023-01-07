using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace qlsv_hoangduy
{
    public partial class Form1 : Form
    {
        SqlConnection cn = null;
        SqlCommand cmd;
        SqlDataAdapter da;
        OpenFileDialog openFile = new OpenFileDialog();
        string  mssv, hoten, diachi, ngay, thang, nam, malop, ngaysinh;
        int gioitinh;
        Byte[] image = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void connect()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\winform\\qlsv-hoangduy\\qlsv-hoangduy\\app_data\\qlsv.mdf;Integrated Security=True";
            cn = new SqlConnection(connectionString);
            cn.Open();

        }

        public void disconnect()
        {
            cn.Close();

        }

        public void fullscreen()
        {
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
           // this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        public void TimKiem()
        {
            string TuKhoa;
            TuKhoa = txtTimKiem.Text;
            //System.Threading.Thread.Sleep(1000);
            dtgSinhVien.DataSource = LayThongTinBang("sp_Select","SINHVIEN where mssv like '%" + TuKhoa + "%' or hoten like '%" + TuKhoa + '%' + "'").Tables[0].DefaultView;
        }

        public DataSet LayThongTinBang(string storeProd, string tenbang)
        {
            cmd = new SqlCommand(storeProd, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = tenbang;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void HienThiLop()
        {
            connect();
            cboLop.DisplayMember = "tenlop";
            cboLop.ValueMember = "malop";
            cboLop.DataSource = LayThongTinBang("sp_Select", "LOP").Tables[0].DefaultView;
            cboLopLoc.DisplayMember = "tenlop";
            cboLopLoc.ValueMember = "malop";
            cboLopLoc.DataSource = LayThongTinBang("sp_Select", "LOP").Tables[0].DefaultView;
        }

        public void HienThiSinhVien()
        {
            string malop;
            malop = cboLopLoc.SelectedValue.ToString() ;
            malop.ToString();
            dtgSinhVien.DataSource = LayThongTinBang("sp_Select", " SINHVIEN where malop ='" + malop +"'").Tables[0].DefaultView;
        }

        public void ChonAnh()
        {
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            openFile.InitialDirectory = @"C:";
            openFile.FileName = "";
            openFile.Filter = "All files(*.*)|*.*";
            //openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            openFile.ShowDialog();
            if (openFile.FileName != "")
            {
                txtHinhAnh.Text = openFile.SafeFileName.Substring(openFile.SafeFileName.LastIndexOf(@"\") + 1);
                pbHinhAnh.Image = Image.FromFile(openFile.FileName);

                //Read jpg into file stream, and from there into Byte array.
                FileStream fsFile = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                image = new Byte[fsFile.Length];
                fsFile.Read(image, 0, image.Length);
                fsFile.Close();
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiSinhVien();
        }

        private void pbHinhAnh_Click(object sender, EventArgs e)
        {
            ChonAnh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không?", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
            if (dtgSinhVien.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgSinhVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgSinhVien.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["mssv"].Value);
                XoaDuLieu("sp_delete", "SINHVIEN", "mssv = '" + cellValue + "'");
                MessageBox.Show("Xóa thành công");
                HienThiSinhVien();
            }
            else
            {
                MessageBox.Show("Không còn gì để xóa");
                HienThiSinhVien();
            }
            }
        }

        public void NgayThangNam()
        {
            for (int i = 1; i<= 31; i++)
            {
                cboNgay.Items.Add(i.ToString());
            }
            for (int i = 1; i<= 12; i++)
            {
                cboThang.Items.Add(i.ToString());
            }
            for (int i = 1990; i<= DateTime.Now.Year + 1; i++)
            {
                cboNam.Items.Add(i.ToString());
            }
            cboNgay.SelectedIndex = 0;
            cboThang.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if(String.Compare(txtTimKiem.Text, "Nhập mssv hoặc họ tên để tìm kiếm", true) == 0)
            {
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập mssv hoặc họ tên để tìm kiếm";
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            TimKiem();

        }

        private void dtgSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgSinhVien.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgSinhVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgSinhVien.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["mssv"].Value);
                DataTable tbl = LayThongTinBang("sp_Select", " SINHVIEN where mssv ='" + cellValue + "'").Tables[0];
                txtMssv.Text = tbl.Rows[0]["mssv"].ToString().Trim();
                txtMssv.ReadOnly = true ;
                txtHoTen.Text = tbl.Rows[0]["hoten"].ToString();
                txtDiaChi.Text = tbl.Rows[0]["diachi"].ToString();
                cboLop.SelectedValue = tbl.Rows[0]["malop"].ToString();
                cboGioiTinh.SelectedIndex = int.Parse(tbl.Rows[0]["gioitinh"].ToString());
                void XuLyNgayThangNam(ComboBox cboXuLy,int GiaTriBatDau,int GiaTriDoDai)
                {
                    if (tbl.Rows[0]["ngaysinh"].ToString().Substring(GiaTriBatDau, 1).StartsWith("0"))
                    {
                        cboXuLy.SelectedItem= tbl.Rows[0]["ngaysinh"].ToString().Substring(GiaTriBatDau + 1, 1);
                    }
                    else
                    {
                        cboXuLy.SelectedItem = tbl.Rows[0]["ngaysinh"].ToString().Substring(GiaTriBatDau, GiaTriDoDai);
                    }
                }
                XuLyNgayThangNam(cboNgay,0,2);
                XuLyNgayThangNam(cboThang,3,2);
                XuLyNgayThangNam(cboNam,6,4);
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            ChonAnh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên");
                txtHoTen.Focus();
                return;
            }
            else if (cboNgay.SelectedIndex == 0 || cboThang.SelectedIndex == 0 || cboNam.SelectedIndex == 0)
            {
                MessageBox.Show("Chọn đầy đủ ngày - tháng - năm");
                return;
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Nhập vào địa chỉ");
                txtDiaChi.Focus();
                return;
            }
            else if (txtHinhAnh.Text == "")
            {
                MessageBox.Show("Chưa chọn ảnh");
                return;
            }
            connect();
            LuuHinh();
            LayDuLieu();
            SuaDuLieu("sp_UpdateSinhVien", mssv, hoten, gioitinh, ngaysinh, diachi, image, malop);
            HienThiSinhVien();
            disconnect();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMssv.Text = "";
            txtMssv.ReadOnly = false;
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtHinhAnh.Text = "";
            cboNgay.SelectedIndex = 0;
            cboThang.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
            cboGioiTinh.SelectedIndex = 0;
        }

        private void LuuHinh()
        {
            //saveFile.FileName = txtHinhAnh.Text;
            string duongDanHinh = Application.StartupPath + @"\Images\";

            if (openFile.FileName != "")
            {
                switch (openFile.FilterIndex)
                {
                    case 1: // nếu là jpg
                        pbHinhAnh.Image.Save(System.IO.Directory.GetCurrentDirectory() + @"\Images\" + txtHinhAnh.Text, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        pbHinhAnh.Image.Save(System.IO.Directory.GetCurrentDirectory() + @"\Images\" + txtHinhAnh.Text, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        pbHinhAnh.Image.Save(System.IO.Directory.GetCurrentDirectory() + @"\Images\" + txtHinhAnh.Text, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        pbHinhAnh.Image.Save(System.IO.Directory.GetCurrentDirectory() + @"\Images\" + txtHinhAnh.Text, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
        }

        public void LayDuLieu()
        {
            malop = cboLop.SelectedValue.ToString();
            mssv = txtMssv.Text;
            hoten = txtHoTen.Text;
            gioitinh = cboGioiTinh.SelectedIndex;
            ngay = cboNgay.SelectedItem.ToString();
            thang = cboThang.SelectedItem.ToString();
            nam = cboNam.SelectedItem.ToString();
            ngaysinh = nam + "/" + thang + "/" + ngay;
            diachi = txtDiaChi.Text;
        }

        public void XoaDuLieu(string storeProd, string tenbang,string dieukien)
        {
            connect();
            cmd = new SqlCommand(storeProd, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = tenbang;
            cmd.Parameters.Add("@dieukien", SqlDbType.NVarChar).Value = dieukien;
            cmd.ExecuteNonQuery();
            disconnect();
        }

        public void LuuDuLieu(string storeProd, string mssv, string hoten, int gioitinh, string ngaysinh, string diachi,Byte[] hinhanh,string malop)
        {
            cmd = new SqlCommand(storeProd, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mssv", SqlDbType.NChar).Value = mssv;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
            cmd.Parameters.Add("@gioitinh", SqlDbType.Int).Value = gioitinh;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            cmd.Parameters.Add("@diachi", SqlDbType.Text).Value = diachi;
            cmd.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh;
            cmd.Parameters.Add("@malop", SqlDbType.NChar).Value = malop;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
        }
        public void SuaDuLieu(string storeProd, string mssv, string hoten, int gioitinh, string ngaysinh, string diachi,Byte[] hinhanh,string malop)
        {
            cmd = new SqlCommand(storeProd, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mssv", SqlDbType.NChar).Value = mssv;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
            cmd.Parameters.Add("@gioitinh", SqlDbType.Int).Value = gioitinh;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            cmd.Parameters.Add("@diachi", SqlDbType.Text).Value = diachi;
            cmd.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh;
            cmd.Parameters.Add("@malop", SqlDbType.NChar).Value = malop;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMssv.Text == "")
            {
                MessageBox.Show("Nhập vào mã số sinh viên");
                txtDiaChi.Focus();
                return;
            }
            else if (txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên");
                txtHoTen.Focus();
                return;
            } else if (cboNgay.SelectedIndex == 0 || cboThang.SelectedIndex == 0 || cboNam.SelectedIndex == 0)
            {
                MessageBox.Show("Chọn đầy đủ ngày - tháng - năm");
                return;
            }
            else if (txtDiaChi.Text == "") {
                MessageBox.Show("Nhập vào địa chỉ");
                txtDiaChi.Focus();
                return;
            }else if (txtHinhAnh.Text == "") {
                MessageBox.Show("Chưa chọn ảnh");
                return;
            }
            connect();
            LuuHinh();
            LayDuLieu();
            LuuDuLieu("sp_Insert", mssv, hoten, gioitinh, ngaysinh, diachi,image, malop);
            HienThiSinhVien();
            disconnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fullscreen();
            cboGioiTinh.SelectedIndex = 0;
            txtTimKiem.Text = "Nhập mssv hoặc họ tên để tìm kiếm";
            connect();
            HienThiLop();
            NgayThangNam();
            disconnect();
        }
    }
}
