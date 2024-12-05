using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class QLTaiKhoanCaNhan : Form
    {
        dataConnection data = new dataConnection();
        int Matk = 0;
        public QLTaiKhoanCaNhan(int matk)
        {
            InitializeComponent();
            Matk = matk;
        }

        private void QLTaiKhoanCaNhan_Load(object sender, EventArgs e)
        {
            DataTable dt = data.TruyVan("select* from TaiKhoan where MaTaiKhoan="+Matk+"");
            foreach (DataRow row in dt.Rows)
            {
                lb_Matk.Text = Matk.ToString();
                lb_Hoten.Text = row["HoTen"].ToString();
                lb_Email.Text = row["Email"].ToString();
                lb_SDT.Text = row["SoDienThoai"].ToString();
                lb_MatKhau.Text = row["MatKhau"].ToString();
                lb_Quyen.Text = row["MaQuyen"].ToString() ;
            }
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            if (txt_MkMoi.Text.Trim() != string.Empty && txt_MkCu.Text.Trim() != string.Empty && txt_XNMK.Text.Trim()!=string.Empty)
            {
                DataTable dt = data.TruyVan("select* from TaiKhoan where MaTaiKhoan=" + Matk + "");
                foreach(DataRow row in dt.Rows)
                {
                    if (txt_MkCu.Text == row["MatKhau"].ToString().Trim())
                    {
                        if(txt_MkMoi.Text ==txt_XNMK.Text)
                        {
                            string capnhatMK = "update TaiKhoan set MatKhau='" + txt_MkMoi.Text + "' where MaTaiKhoan="+Matk+"";
                            data.Exe(capnhatMK);
                            lb_MatKhau.Text = txt_MkMoi.Text;
                            MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Xác Nhận Mật Khẩu Không Chính Xác","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            txt_XNMK.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Cũ Không Chính Xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_MkCu.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private bool kiemtrafrm = false;
        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            FrmMain frmMain = new FrmMain(Matk);
            frmMain.Show();
        }


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

        private void but_Reset_Click(object sender, EventArgs e)
        {
            txt_MkCu.ResetText();
            txt_XNMK.ResetText();
            txt_MkMoi.ResetText();
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

        private void btn_QLSan_Click_1(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            frm_QLSan frm_QLSan = new frm_QLSan(Matk);
            frm_QLSan.ShowDialog();
        }

        private void btn_TKCN_Click_1(object sender, EventArgs e)
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

        private void btn_ThongKe_Click_1(object sender, EventArgs e)
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
