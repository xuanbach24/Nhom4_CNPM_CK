using DevExpress.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class frm_DatSan : Form
    {
        int Matk = 0;
        public frm_DatSan(int matk)
        {
            InitializeComponent();
            Matk = matk;
        }

        dataConnection data= new dataConnection();
        public void load()
        {
            DataTable dsloaisan = data.TruyVan("select* from LoaiSan");
            foreach(DataRow row in dsloaisan.Rows)
            {
                LoaiSan.Items.Add(row["MaLoaiSan"].ToString());
            }
            
            Combo_ThanhToan.Items.Clear();
            Combo_ThanhToan.Items.Add("Đã Thanh Toán");
            Combo_ThanhToan.Items.Add("Chưa Thanh Toán");

            Combo_TrangThai.Items.Clear();
            Combo_TrangThai.Items.Add("Đặt Mới");
            Combo_TrangThai.Items.Add("Hủy Sân");

        }

        public void loadDataGrid()
        {
            DataTable dt = data.TruyVan("Select* from DatSan");
            if (dt != null)
            {
                dt.DefaultView.Sort = "MADATSAN DESC";
                dataGridView1.DataSource = dt;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string MaLoaiSan = "";
            int gia=0;
            DataTable dsLoaiSan = data.TruyVan("select* from LoaiSan where MaLoaiSan ='"+LoaiSan.Text+"'");
            foreach (DataRow row in dsLoaiSan.Rows)
            {
                MaLoaiSan= row["MaLoaiSan"].ToString();
                gia = int.Parse(row["GiaTrenGio"].ToString());
            }
            int tgbd = int.Parse(txt_GioBD.Text);
            int tgkt = int.Parse(txt_GioKT.Text);
            if (tgbd > tgkt)
            {
                tgkt = tgkt + 24;
                txt_TongTien.Text = (gia * (tgkt - tgbd)).ToString();
            }
            else
            {
                txt_TongTien.Text = (gia * (int.Parse(txt_GioKT.Text) - int.Parse(txt_GioBD.Text))).ToString();
            }
            SanSo.Items.Clear();
            DataTable dssanso = data.TruyVan("select* from San where MaLoaiSan='" + LoaiSan.Text + "' and DangSuaChua=0");
            foreach (DataRow row in dssanso.Rows)
            {
                SanSo.Items.Add(row["TenSan"].ToString());
            }
        }
        private bool checkTrungLich(string maSan, DateTime ngayDS, int gioBD, int gioKT)
        {
            string checkNgay = ngayDS.ToShortDateString();
            DataTable dsDatSan = data.TruyVan("select * from DatSan where NgayDatSan='" + checkNgay + "' and GioBatDau=" + gioBD + " and GioKetThuc=" + gioKT + " and MaSan='" + maSan + "'");
            if (dsDatSan.Rows.Count > 0)
                return true;
            return false;
        }
        private void frm_DatSan_Load(object sender, EventArgs e)
        {
            load();
            loadDataGrid();

        }


        private bool kiemtrafrm=false;

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
            if(dataGridView1.Rows.Count == 0)
            {
                dataGridView1.ClearSelection();
            }
            else
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() != null)
                {
                    date.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    txt_GioBD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_GioKT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txt_HoTen.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txt_SDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txt_TongTien.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    DataTable dsSan = data.TruyVan("select * from San where MaSan ='" + dataGridView1.CurrentRow.Cells[10].Value.ToString().Trim() + "'");
                    foreach (DataRow dr in dsSan.Rows)
                    {
                        SanSo.Text = dr["TenSan"].ToString().Trim();

                        DataTable dsLoaiSan = data.TruyVan("select * from LoaiSan where MaLoaiSan ='" + dr["MaLoaiSan"].ToString().Trim() + "'");
                        foreach (DataRow row in dsLoaiSan.Rows)
                        {
                            LoaiSan.Text = row["TenLoaiSan"].ToString().Trim();
                        }
                    }
                    Combo_ThanhToan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim() == "True" ? "Đã Thanh Toán" : "Chưa Thanh Toán";
                    Combo_TrangThai.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString().Trim() == "True" ? "Đã Hủy" : "Đang Hoạt Động";
                }
                else
                {
                    MessageBox.Show("Lỗi Không Có Dữ Liệu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                
            }
        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            bool kiemtralap = true;
            int a = 0;
            int b = 0;

            if (txt_GioBD.Text.Trim() == string.Empty || txt_GioKT.Text.Trim() == string.Empty || txt_HoTen.Text.Trim() == string.Empty || txt_SDT.Text.Trim() == string.Empty || Combo_ThanhToan.Text.Trim() == string.Empty || Combo_TrangThai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Combo_ThanhToan.Text == "Đã Thanh Toán")
                {
                    a = 1;
                }
                if (Combo_TrangThai.Text == "Hủy Sân")
                {
                    b = 1;
                }
                string Masan = "";
                DataTable chonsan = data.TruyVan("select* from San where TenSan='" + SanSo.Text + "'");
                foreach (DataRow row in chonsan.Rows)
                {
                    Masan = row["MaSan"].ToString();
                }
                string formattedDate = date.Value.ToString("yyyy-MM-dd");
                DataTable kiemtra = data.TruyVan("select* from DatSan");
                int tgbd = int.Parse(txt_GioBD.Text);
                int tgkt = int.Parse(txt_GioKT.Text);
                if (tgbd > tgkt)
                {
                    tgkt = tgkt + 24;
                }
                string query = "INSERT INTO DatSan (NgayDatSan,GioBatDau, GioKetThuc, HoTen, SDTLienLac, TongTien, DaThanhToan, DaHuy, MaTaiKhoan, MaSan) VALUES ('" + formattedDate + "'," + txt_GioBD.Text + "," + txt_GioKT.Text + ",N'" + txt_HoTen.Text + "','" + txt_SDT.Text + "'," + txt_TongTien.Text + "," + a + "," + b + "," + Matk + ",'" + Masan + "')";

                foreach (DataRow row in kiemtra.Rows)
                {
                    int dataGBD = int.Parse(row["GioBatDau"].ToString());
                    int dataGKT = int.Parse(row["GioKetThuc"].ToString());


                    if (dataGBD > dataGKT)
                    {
                        dataGKT = dataGKT + 24;
                    }
                    if (checkTrungLich(Masan, date.Value, tgbd, tgkt))
                    {
                        if (tgbd < dataGKT && tgkt > dataGBD)
                        {
                            MessageBox.Show("Khoảng Thời Gian Đã Bị Trùng");

                            kiemtralap = false;
                            break;
                        }
                    }
                }
                if (kiemtralap == true)
                {
                    data.Exe(query);
                    loadDataGrid();
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void but_Xoa_Click(object sender, EventArgs e)
        {
            data.Exe("DELETE from DatSan where SDTLienLac='" + txt_SDT.Text + "'");
            loadDataGrid();
            MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void but_Sua_Click(object sender, EventArgs e)
        {
            bool kiemtralap = true;
            int a = 0;
            int b = 0;

            if (txt_GioBD.Text.Trim() == string.Empty || txt_GioKT.Text.Trim() == string.Empty || txt_HoTen.Text.Trim() == string.Empty || txt_SDT.Text.Trim() == string.Empty || Combo_ThanhToan.Text.Trim() == string.Empty || Combo_TrangThai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Combo_ThanhToan.Text == "Đã Thanh Toán")
                {
                    a = 1;
                }
                if (Combo_TrangThai.Text == "Hủy Sân")
                {
                    b = 1;
                }
                string Masan = "";
                DataTable chonsan = data.TruyVan("select* from San where TenSan='" + SanSo.Text + "'");
                foreach (DataRow row in chonsan.Rows)
                {
                    Masan = row["MaSan"].ToString();
                }
                string formattedDate = date.Value.ToString("yyyy-MM-dd");
                int tgbd = int.Parse(txt_GioBD.Text);
                int tgkt = int.Parse(txt_GioKT.Text);

                DataTable kiemtra = data.TruyVan("select* from DatSan");
                if (tgbd > tgkt)
                {
                    tgkt = tgkt + 24;
                }
                string query = "UPDATE DatSan SET NgayDatSan= '" + formattedDate + "', GioBatDau=" + tgbd + ", GioKetThuc=" + tgkt + ", HoTen =N'" + txt_HoTen.Text + "', TongTien=" + txt_TongTien.Text + ", DaThanhToan=" + a + ", DaHuy=" + b + ", MaTaiKhoan= " + Matk + ", MaSan='" + Masan + "' where SDTLienLac='" + txt_SDT.Text.Trim() + "'";

                foreach (DataRow row in kiemtra.Rows)
                {
                    int dataGBD = int.Parse(row["GioBatDau"].ToString());
                    int dataGKT = int.Parse(row["GioKetThuc"].ToString());


                    if (dataGBD > dataGKT)
                    {
                        dataGKT = dataGKT + 24;
                    }
                    if (checkTrungLich(Masan, date.Value, tgbd, tgkt))
                    {
                        if (tgbd < dataGKT && tgkt > dataGBD)
                        {
                            kiemtralap = false;
                            MessageBox.Show("Khoảng Thời Gian Đã Bị Trùng");
                            break;
                        }

                    }

                }
                if (kiemtralap)
                {
                    data.Exe(query);
                    loadDataGrid();
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void but_Reset_Click(object sender, EventArgs e)
        {
            txt_GioBD.Text = txt_GioKT.Text = txt_HoTen.Text = txt_SDT.Text = txt_TongTien.Text = string.Empty;
            Combo_ThanhToan.Text = Combo_TrangThai.Text = LoaiSan.Text = SanSo.Text = "--Chọn--";
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

        private void btn_report_Click(object sender, EventArgs e)
        {
            kiemtrafrm = true;
            frm_report frm = new frm_report();
            frm.ShowDialog();
        }
    }
}
