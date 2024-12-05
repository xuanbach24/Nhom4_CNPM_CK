using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        dataConnection data= new dataConnection();
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                Control control = sender as Control;
                e.Handled = true;
                this.errorProvider1.SetError(control, "Loi");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private bool kiemtrafrm = false;

        public void button1_DangNhap_Click(object sender, EventArgs e)
        {
            data.openCon();
            try { 
                if (txt_sdt.Text==null)
                {
                    MessageBox.Show("Vui Lòng Nhập Số Điện Thoại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   txt_sdt.Focus();
                }
                if (txt_mk.Text == null)
                {
                    MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   txt_mk.Focus();
                }

                DataTable dsTaiKhoan = data.TruyVan("select* from TaiKhoan where SoDienThoai='" + txt_sdt.Text.Trim() + "' and MatKhau='" + txt_mk.Text.Trim() + "'");
                
                if (dsTaiKhoan.Rows.Count < 1)
                {
                    MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
                else
                {
                    int matk = 0;
                    foreach(DataRow row in dsTaiKhoan.Rows)
                    {
                        matk = int.Parse(row["MaTaiKhoan"].ToString());
                    }
                    kiemtrafrm = true;
                    this.Hide();
                    FrmMain frmMain = new FrmMain(matk);
                    frmMain.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            data.closeCon();
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kiemtrafrm)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn Có Muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_sdtt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
