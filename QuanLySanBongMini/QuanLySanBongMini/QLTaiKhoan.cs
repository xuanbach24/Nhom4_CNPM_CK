using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class QLTaiKhoan : Form
    {
        private int Matk = 0;
        dataConnection data = new dataConnection();
        public QLTaiKhoan(int matk)
        {
            InitializeComponent();
            Matk = matk;
        }

        public void loadGridView()
        {
            DataTable dt= data.TruyVan("select* from TaiKhoan");
            if(dt != null )
            {
                dataGridView1.DataSource = dt;
            }
        }
        public void loadComboBox()
        {
            DataTable quyen = data.TruyVan("select* from Quyen");
            comboBox_Quyen.Items.Clear();
            foreach(DataRow row in quyen.Rows)
            {
                comboBox_Quyen.Items.Add(row["MaQuyen"].ToString());
            }
        }
        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadGridView();
        }
        private bool kiemtrafrm = false;
     

        private void frmFormClosing(object sender, FormClosingEventArgs e)
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txt_HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_Email.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_SDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_MatKhau.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox_Quyen.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text.Trim() == string.Empty || txt_Email.Text.Trim() == string.Empty || txt_SDT.Text.Trim() == string.Empty || txt_MatKhau.Text.Trim() == string.Empty || comboBox_Quyen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable kiemtra = data.TruyVan("select* from TaiKhoan");
                foreach (DataRow row in kiemtra.Rows)
                {
                    if (txt_Email.Text == row["Email"].ToString().Trim() || txt_SDT.Text == row["SoDienThoai"].ToString().Trim())
                    {
                        MessageBox.Show("Tài Khoản Đã Bị Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        string them = "insert into TaiKhoan values('" + txt_HoTen.Text + "','" + txt_Email.Text + "','" + txt_SDT.Text + "','" + txt_MatKhau.Text + "','" + comboBox_Quyen + "')";
                        data.Exe(them);
                        MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            loadGridView();

        }

        private void but_Xoa_Click(object sender, EventArgs e)
        {
            string xoa = "delete from TaiKhoan where SoDienThoai='" + txt_SDT.Text + "'";
            data.Exe(xoa);
            loadGridView();
            MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void but_Sua_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text.Trim() == string.Empty || txt_Email.Text.Trim() == string.Empty || txt_SDT.Text.Trim() == string.Empty || txt_MatKhau.Text.Trim() == string.Empty || comboBox_Quyen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataTable kiemtra = data.TruyVan("select* from TaiKhoan");
                foreach (DataRow row in kiemtra.Rows)
                {
                    if (txt_Email.Text == row["Email"].ToString() || txt_SDT.Text == row["SoDienThoai"].ToString())
                    {
                        MessageBox.Show("Tài Khoản Đã Bị Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        string sua = "update TaiKhoan set HoTen='" + txt_HoTen.Text + "',Email='" + txt_Email.Text + "',MatKhau='" + txt_MatKhau.Text + "',MaQuyen='" + comboBox_Quyen.Text + "')";
                        data.Exe(sua);
                        loadGridView();
                        MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void but_Reset_Click(object sender, EventArgs e)
        {
            comboBox_Quyen.Text = "--Chọn--";
            txt_Email.Text = txt_HoTen.Text = txt_MatKhau.Text = txt_SDT.Text = string.Empty;
        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        bool sidebarExpand;

        private void sibartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void btn_datsan_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            frm_DatSan frm_DatSan = new frm_DatSan(Matk);
            frm_DatSan.ShowDialog();
        }

        private void btn_QLSan_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            frm_QLSan frm_QLSan = new frm_QLSan(Matk);
            frm_QLSan.ShowDialog();
        }

        private void btn_TKCN_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            QLTaiKhoanCaNhan qLTaiKhoanCaNhan = new QLTaiKhoanCaNhan(Matk);
            qLTaiKhoanCaNhan.ShowDialog();
        }

        private void btn_QLTK_Click_1(object sender, EventArgs e)
        {
            DataTable dt = data.TruyVan("select* from TaiKhoan where MaTaiKhoan=" + Matk + "");
            if (dt.Rows.Count > 0)
            {
                string quyen = dt.Rows[0]["MaQuyen"].ToString().Trim();
                if (quyen == "owner")
                {
                    kiemtrafrm = true;
                    this.Hide();
                    QLTaiKhoan qLTaiKhoan = new QLTaiKhoan(Matk);
                    qLTaiKhoan.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Xin Lỗi, Bạn Không Có Quyền Truy Cập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            frm_ThongKe frm_ThongKe = new frm_ThongKe(Matk);
            frm_ThongKe.ShowDialog();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            frm_DangNhap frm_DangNhap = new frm_DangNhap();
            frm_DangNhap.ShowDialog();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            frm_HoaDon frm_HoaDon = new frm_HoaDon(Matk);
            frm_HoaDon.ShowDialog();
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            FrmMain frmMain = new FrmMain(Matk);
            frmMain.ShowDialog();
        }
    }
}
