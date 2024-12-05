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
    public partial class frm_QLSan : Form
    {
        private int Matk = 0;
        dataConnection data = new dataConnection();
        public frm_QLSan(int matk)
        {
            InitializeComponent();
            Matk = matk;
        }
        public void loadGridView_San()
        {
            DataTable dt = data.TruyVan("select* from San");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        public void loadGridView_LoaiSan()
        {
            DataTable dt = data.TruyVan("select* from LoaiSan");
            if (dt != null)
            {
                dataGridView2.DataSource = dt;
            }
        }
        public void load_ComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hoạt Động Tốt");
            comboBox1.Items.Add("Đang Sữa Chữa");
            string truyvan = "select* from LoaiSan";
            DataTable dt = data.TruyVan(truyvan);
            comboBox2.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBox2.Items.Add(row["MaLoaiSan"].ToString());
            }
        }

        public void Key_Press(object sender, KeyPressEventArgs e)
        {
            Control ctr = sender as Control;
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                this.errorProvider1.SetError(ctr,"Lỗi");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void frm_QLSan_Load(object sender, EventArgs e)
        {
            load_ComboBox();
            loadGridView_LoaiSan();
            loadGridView_San();
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
                txt_MaSan.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_TenSan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() == "True" ? "Đang Sửa Chữa" : "Hoạt Động Tốt";
                comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                txt_MaLS.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txt_TenLS.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txt_Gia.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            this.Hide();
            FrmMain frmMain = new FrmMain(Matk);
            frmMain.Show();
        }

        private void but_ThemQLS_Click(object sender, EventArgs e)
        {
            bool kiemtralap = true;
            int intTT = 0;
            string Masan = txt_MaSan.Text;
            string Tensan = txt_TenSan.Text;
            string Trangthai = comboBox1.Text;
            string Loaisan = comboBox2.Text;
            if (Trangthai == "Đang Sữa Chữa")
            {
                intTT = 1;
            }
            if (txt_MaSan.Text.Trim() == string.Empty || txt_TenSan.Text.Trim() == string.Empty || comboBox1.Text.Trim() == string.Empty || comboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable Kiemtra = data.TruyVan("select* from San");
                foreach (DataRow row in Kiemtra.Rows)
                {
                    if (Masan == row["MaSan"].ToString().Trim() || Tensan == row["TenSan"].ToString().Trim())
                    {
                        MessageBox.Show("Đã Bị Trùng Sân");
                        kiemtralap = false;
                    }
                }
                if (kiemtralap)
                {
                    string Them = "insert into San values ('" + Masan + "',N'" + Tensan + "'," + intTT + ",'" + Loaisan + "')";
                    data.Exe(Them);
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            loadGridView_San();
        }

        private void but_XoaQLS_Click(object sender, EventArgs e)
        {
            string Masan = txt_MaSan.Text;
            string xoa = "delete from San where MaSan='" + Masan + "'";
            data.Exe(xoa);
            loadGridView_San();
            MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void but_SuaQLS_Click(object sender, EventArgs e)
        {
            bool kiemtralap = true;
            int intTT = 0;
            string Masan = txt_MaSan.Text;
            string Tensan = txt_TenSan.Text;
            string Trangthai = comboBox1.Text;
            string Loaisan = comboBox2.Text;
            if (Trangthai == "Đang Sữa Chữa")
            {
                intTT = 1;
            }
            if (txt_MaSan.Text.Trim() == string.Empty || txt_TenSan.Text.Trim() == string.Empty || comboBox1.Text.Trim() == string.Empty || comboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable Kiemtra = data.TruyVan("select* from San");
                foreach (DataRow row in Kiemtra.Rows)
                {
                }
                if (kiemtralap)
                {
                    string sua = "Update San set TenSan=N'" + Tensan + "',DangSuaChua='" + intTT + "',MaLoaiSan='" + Loaisan + "' where MaSan='" + Masan + "' ";
                    data.Exe(sua);
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            loadGridView_San();

        }

        private void but_ResetQLS_Click(object sender, EventArgs e)
        {
            txt_MaSan.Text = txt_TenSan.Text = string.Empty;
            comboBox1.Text = comboBox2.Text = "--Chọn--";
        }

        private void but_ThemLS_Click(object sender, EventArgs e)
        {
            bool kiemtralap = true;

            if (txt_MaLS.Text.Trim() == string.Empty || txt_TenLS.Text.Trim() == string.Empty || txt_Gia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string MaLS = txt_MaLS.Text;
                string TenLS = txt_TenLS.Text;
                int Gia = int.Parse(txt_Gia.Text);
                DataTable kiemtra = data.TruyVan("select* from LoaiSan");
                foreach (DataRow row in kiemtra.Rows)
                {
                    if (MaLS == row["MaLoaiSan"].ToString().Trim() || TenLS == row["TenLoaiSan"].ToString().Trim())
                    {
                        MessageBox.Show("Đã Trùng Thông Tin Sân", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kiemtralap = false;
                    }
                }
                if (kiemtralap)
                {
                    string themls = "insert into LoaiSan values ('" + MaLS + "',N'" + TenLS + "'," + Gia + ")";
                    data.Exe(themls);
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            loadGridView_LoaiSan();
            load_ComboBox();
        }

        private void but_XoaLS_Click(object sender, EventArgs e)
        {
            string MaLS = txt_MaLS.Text;
            string xoals = "delete from LoaiSan where MaLoaiSan='" + MaLS + "'";
            data.Exe(xoals);
            loadGridView_LoaiSan();
            load_ComboBox();
            MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void but_SuaLS_Click(object sender, EventArgs e)
        {
            if (txt_MaLS.Text.Trim() == string.Empty || txt_TenLS.Text.Trim() == string.Empty || txt_Gia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string MaLS = txt_MaLS.Text;
                string TenLS = txt_TenLS.Text;
                int Gia = int.Parse(txt_Gia.Text);
                string suals = "update LoaiSan set TenLoaiSan=N'" + TenLS + "',GiaTrenGio=" + Gia + " where MaLoaiSan='" + MaLS + "'";
                data.Exe(suals);
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            load_ComboBox();
            loadGridView_LoaiSan();

        }

        private void but_ResetLS_Click(object sender, EventArgs e)
        {
            txt_MaLS.Text = txt_TenLS.Text = txt_Gia.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
