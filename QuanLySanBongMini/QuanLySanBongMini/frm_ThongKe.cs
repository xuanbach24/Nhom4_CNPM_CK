using DevExpress.XtraCharts;
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
    public partial class frm_ThongKe : Form
    {
        private int Matk = 0;
        dataConnection data = new dataConnection();
        public frm_ThongKe(int matk)
        {
            InitializeComponent();
            Matk = matk;
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

        private void btn_TKNam_Click(object sender, EventArgs e)
        {
            DateTime selectdate = date_bd.Value;
            string Nam = selectdate.Year.ToString();

            // Kiểm tra và xóa các series cũ (nếu có) trước khi thêm series mới
            bieudo.Series.Clear();

            // Tạo một series mới cho biểu đồ cột
            Series series = new Series("Biểu Đồ Thống Kê", ViewType.Bar);

            // Thêm dữ liệu cho biểu đồ cột
            for (int i = 1; i <= 12; i++)
            {
                DataTable doanhthu = data.TruyVan("select sum([Tổng Tiền Thu Được]) as TongTien from TongTien where year(NgayDatSan)='" + Nam + "' and Month(NgayDatSan)='" + i + "'");
                string doanhthubieudo = doanhthu.Rows[0]["TongTien"].ToString();

                // Kiểm tra nếu doanh thu là null hoặc trống thì đặt giá trị là "0"
                if (string.IsNullOrEmpty(doanhthubieudo))
                {
                    doanhthubieudo = "0";
                }

                // Thêm điểm vào series
                series.Points.Add(new SeriesPoint("Tháng " + i, int.Parse(doanhthubieudo)));
            }

            // Thêm series vào biểu đồ
            bieudo.Series.Add(series);

            // Thiết lập tiêu đề
            bieudo.Titles.Clear();  // Xóa các tiêu đề cũ trước khi thêm tiêu đề mới
            bieudo.Titles.Add(new ChartTitle { Text = "Biểu Đồ Thống Kê Năm " + Nam });

            // Hiển thị biểu đồ trên form
            bieudo.Dock = DockStyle.Fill;

            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(bieudo);
            //Biểu đồ tròn
            bieudotron.Series.Clear();
            Series series1 = new Series("Tỉ Lệ Sân Đặt Nhiều", ViewType.Pie);
            loadbieudonam(Nam);

        }

        private void btn_TKRandom_Click(object sender, EventArgs e)
        {
            DateTime selectdate = date_bd.Value;
            string nam = selectdate.Year.ToString();
            string thang = selectdate.Month.ToString();
            // Kiểm tra và xóa các series cũ (nếu có) trước khi thêm series mới
            bieudo.Series.Clear();

            // Tạo một series mới cho biểu đồ cột
            Series series = new Series("Biểu Đồ Thống Kê", ViewType.Bar);

            // Thêm dữ liệu cho biểu đồ cột
            for (int i = 1; i <= 31; i++)
            {
                DataTable doanhthu = data.TruyVan("select sum([Tổng Tiền Thu Được]) as TongTien from TongTien where year(NgayDatSan)='" + nam + "' and Month(NgayDatSan)='" + thang + "' and day(ngaydatsan)='" + i + "'");
                string doanhthubieudo = doanhthu.Rows[0]["TongTien"].ToString();

                // Kiểm tra nếu doanh thu là null hoặc trống thì đặt giá trị là "0"
                if (string.IsNullOrEmpty(doanhthubieudo))
                {
                    doanhthubieudo = "0";
                }

                // Thêm điểm vào series
                series.Points.Add(new SeriesPoint("Ngày " + i, int.Parse(doanhthubieudo)));
            }

            // Thêm series vào biểu đồ
            bieudo.Series.Add(series);

            // Thiết lập tiêu đề
            bieudo.Titles.Clear();  // Xóa các tiêu đề cũ trước khi thêm tiêu đề mới
            bieudo.Titles.Add(new ChartTitle { Text = "Biểu Đồ Thống Kê Tháng " + thang });


            groupBox1.Controls.Clear();
            // Hiển thị biểu đồ trên form
            bieudo.Dock = DockStyle.Fill;

            groupBox1.Controls.Add(bieudo);
            loadbieudothang(nam, thang);
        }

        public void loadbieudonam(string nam)
        {
            bieudotron.Series.Clear();
            // Tạo series cho biểu đồ tròn
            Series series = new Series("Số Lượng Sân Đặt", ViewType.Pie);
            DataTable slsan = data.TruyVan("select masan,tensan from San");
            foreach (DataRow row in slsan.Rows)
            {
                string masan = row["masan"].ToString();
                DataTable slnam = data.TruyVan("SELECT SUM([SLSAN]) as 'TongSan' FROM SOLUONGSANDAT WHERE MASAN='" + masan + "' AND YEAR(NgayDatSan)='" + nam + "' group by TenSan");
                int Tongsan = 0;
                if (slnam.Rows.Count > 0)
                {
                    string tongSanStr = slnam.Rows[0]["TongSan"].ToString();
                    Tongsan = string.IsNullOrEmpty(tongSanStr) ? 0 : int.Parse(tongSanStr);
                }

                string tensan = row["tensan"].ToString();
                series.Points.Add(new SeriesPoint(tensan, Tongsan));

            }
            bieudotron.Series.Add(series);
            series.Label.TextPattern = "{A}: {VP: p0}";
        }

        public void loadbieudothang(string nam, string thang)
        {
            bieudotron.Series.Clear();
            // Tạo series cho biểu đồ tròn
            Series series = new Series("Số Lượng Sân Đặt", ViewType.Pie);
            DataTable slsan = data.TruyVan("select masan,tensan from San");
            foreach (DataRow row in slsan.Rows)
            {
                string masan = row["masan"].ToString();
                DataTable slnam = data.TruyVan("SELECT SUM([SLSAN]) as 'TongSan' FROM SOLUONGSANDAT WHERE MASAN='" + masan + "' AND YEAR(NgayDatSan)='" + nam + "' AND MONTH(NGAYDATSAN)='" + thang + "' group by TenSan");
                int Tongsan = 0;
                if (slnam.Rows.Count > 0)
                {
                    string tongSanStr = slnam.Rows[0]["TongSan"].ToString();
                    Tongsan = string.IsNullOrEmpty(tongSanStr) ? 0 : int.Parse(tongSanStr);
                }

                string tensan = row["tensan"].ToString();
                series.Points.Add(new SeriesPoint(tensan, Tongsan));

            }
            bieudotron.Series.Add(series);
            series.Label.TextPattern = "{A}: {VP: p0}";
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
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
