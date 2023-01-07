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
    public partial class FormQlLop : Form
    {
        SqlConnection cn = null;
        SqlCommand cmd;
        SqlDataAdapter da;
        OpenFileDialog openFile = new OpenFileDialog();
        string makhoa, malop, tenlop,siso;
        private void FormQlLop_Load(object sender, EventArgs e)
        {
            HienThiDSLop();
            HienThiKhoa();
        }
        public FormQlLop()
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
        private void txtSiSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
                (e.KeyChar == '.' && (txtMaLop.Text.Length == 0 || txtMaLop.Text.IndexOf('.') != -1))))
                e.Handled = true;
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
        public void HienThiDSLop()
        {
            connect();
            dtgLop.DataSource = LayThongTinBang("sp_Select", "LOP").Tables[0].DefaultView;
            disconnect();
        }
        public void HienThiKhoa()
        {
            connect();
            cboKhoa.DisplayMember = "tenkhoa";
            cboKhoa.ValueMember = "makhoa";
            cboKhoa.DataSource = LayThongTinBang("sp_Select", "KHOA").Tables[0].DefaultView;
        }
        public void LayDuLieu()
        {
            makhoa = cboKhoa.SelectedValue.ToString();
            malop = txtMaLop.Text.ToString();
            tenlop = txtTenLop.Text.ToString();
            siso = txtSiSo.Text.ToString();
        }
        public void LuuDuLieu(string storeProd,string makhoa,string malop,string tenlop,string siso)
        {
            cmd = new SqlCommand(storeProd, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@makhoa", SqlDbType.NChar).Value = makhoa;
            cmd.Parameters.Add("@malop", SqlDbType.NChar).Value = malop;
            cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = tenlop;
            cmd.Parameters.Add("@siso", SqlDbType.Int).Value = siso;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm lớp mới thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa lớp này không?", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (dtgLop.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dtgLop.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dtgLop.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["malop"].Value);
                    XoaDuLieu("sp_delete", "LOP", "malop = '" + cellValue + "'");
                    MessageBox.Show("Xóa thành công");
                    HienThiDSLop();
                }
                else
                {
                    MessageBox.Show("Không còn gì để xóa");
                    HienThiDSLop();
                }
            }
        }

        private void dtgLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgLop.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgLop.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgLop.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["malop"].Value);
                DataTable tbl = LayThongTinBang("sp_Select", "LOP where malop ='" + cellValue + "'").Tables[0];
                cboKhoa.SelectedValue = tbl.Rows[0]["makhoa"].ToString();
                txtMaLop.Text = tbl.Rows[0]["malop"].ToString().Trim();
                txtMaLop.ReadOnly = true;
                txtTenLop.Text = tbl.Rows[0]["tenlop"].ToString();
                txtSiSo.Text = tbl.Rows[0]["siso"].ToString();
            }
        }

        public void SuaDuLieu(string storeProd,string makhoa , string malop, string tenlop, string siso)
        {
            cmd = new SqlCommand(storeProd, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@malop", SqlDbType.NChar).Value = malop;
            cmd.Parameters.Add("@makhoa", SqlDbType.NChar).Value = makhoa;
            cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = tenlop;
            cmd.Parameters.Add("@siso", SqlDbType.Int).Value = siso;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa lớp thành công");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            connect();
            LayDuLieu();
            if (malop == "")
            {
                MessageBox.Show("Chưa nhập mã lớp");
                txtMaLop.Focus();
                return;
            }
            else if (tenlop == "")
            {
                MessageBox.Show("Chưa nhập tên lớp");
                txtTenLop.Focus();
                return;
            }
            else if (siso == "")
            {
                MessageBox.Show("Chưa nhập sỉ số");
                txtSiSo.Focus();
                return;
            }
            else if (int.Parse(siso) > 40 || int.Parse(siso) < 10)
            {
                MessageBox.Show("Sỉ số lớp tối thiểu 10 và tối đa 40 hs");
                txtSiSo.Focus();
                return;
            }
            SuaDuLieu("sp_updateLop", makhoa,malop, tenlop, siso);
            HienThiDSLop();
        }
        public void TimKiem()
        {
            string TuKhoa;
            TuKhoa = txtMaLop.Text;
            DataTable tbl = LayThongTinBang("sp_Select", "LOP where malop ='" + TuKhoa + "'").Tables[0];
            if(tbl.Rows.Count > 0)
            {
                txtTenLop.Text = tbl.Rows[0]["tenlop"].ToString();
                txtSiSo.Text = tbl.Rows[0]["siso"].ToString();
                cboKhoa.SelectedValue = tbl.Rows[0]["makhoa"].ToString();
            }
            else
            {
                txtTenLop.Text = "";
                txtSiSo.Text = "";
                cboKhoa.SelectedIndex = 0 ;
            }

        }

        private void txtMaLop_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TimKiem();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            connect();
            LayDuLieu();
            if(malop == "")
            {
                MessageBox.Show("Chưa nhập mã lớp");
                txtMaLop.Focus();
                return;
            }
            else if (tenlop == "")
            {
                MessageBox.Show("Chưa nhập tên lớp");
                txtTenLop.Focus();
                return;
            }else if (siso == "")
            {
                MessageBox.Show("Chưa nhập sỉ số");
                txtSiSo.Focus();
                return;
            }else if (int.Parse(siso) > 40 || int.Parse(siso) < 10)
            {
                MessageBox.Show("Sỉ số lớp tối thiểu 10 và tối đa 40 hs");
                txtSiSo.Focus();
                return;
            }
            LuuDuLieu("sp_insertLop",makhoa,malop,tenlop,siso);
            HienThiDSLop();
        }
        public void XoaDuLieu(string storeProd, string tenbang, string dieukien)
        {
            connect();
            cmd = new SqlCommand(storeProd, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = tenbang;
            cmd.Parameters.Add("@dieukien", SqlDbType.NVarChar).Value = dieukien;
            cmd.ExecuteNonQuery();
            disconnect();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtSiSo.Text = "";
            cboKhoa.SelectedIndex = 0;
        }
    }
}
