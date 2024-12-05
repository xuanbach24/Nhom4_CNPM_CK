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
    public partial class frm_HoaDon : Form
    {
        int Matk = 0;
        dataConnection data = new dataConnection();
        public frm_HoaDon(int matk)
        {
            InitializeComponent();
            Matk = matk;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            data.openCon();
            string cmd = "select * from Hoadon where mahd= " + txt_timkiem.Text.Trim() + "";
            DataTable dt = data.TruyVan(cmd);
            dataGridView1.DataSource = dt;
            data.closeCon();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            data.openCon();
            string cmd = "select * from hoadon";
            DataTable dt = data.TruyVan(cmd);
            dataGridView1.DataSource = dt;
            data.closeCon();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string formatdate = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_mahd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txt_ngayhd.Text = DateTime.Parse(formatdate).ToString("yyyy-MM-dd");
                    txt_thanhtien.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_mads.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    if (txt_mahd.Text != string.Empty)
                    {
                        btn_xuathd.Enabled = true;
                    }
                    txt_sdt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi:"+ex);
            }
            
            
        }

        private void btn_xuathd_Click(object sender, EventArgs e)
        {
            int madatsan=int.Parse(txt_mads.Text);
            inhoadon Inhoadon = new inhoadon(Matk,madatsan);
            Inhoadon.ShowDialog();

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

        bool sidebarExpand;

        private void sibartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
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

        private void btn_QLTK_Click(object sender, EventArgs e)
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
