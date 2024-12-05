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
    public partial class inhoadon : Form
    {
        dataConnection data = new dataConnection();
        int matk = 0;
        int madatsan = 0;
        public inhoadon(int matk,int madatsan)
        {
            InitializeComponent();
            this.matk = matk;
            this.madatsan = madatsan;
        }

        public void xuathoadon(int matk,int madatsan)
        {
            //Thong tin nhan vien
            DataTable nhanvien = data.TruyVan("select* from taikhoan where mataikhoan='" + matk + "'");
            DataTable mahd = data.TruyVan("select* from hoadon where madatsan='" + madatsan + "'");
            lb_mahd.Text = mahd.Rows[0][0].ToString();
            lb_tennv.Text = nhanvien.Rows[0][1].ToString();
            //Thong tin khach hang
            DataTable dt = data.TruyVan("select * from DatSan Where Madatsan=" + madatsan + "");
            lb_tenkh.Text = dt.Rows[0][4].ToString();
            lb_sdt.Text = dt.Rows[0][5].ToString();
            lb_ngay.Text = dt.Rows[0][1].ToString();
            string giobd = dt.Rows[0][2].ToString();
            string giokt = dt.Rows[0][3].ToString();
            lb_gio.Text = "" + giobd + " -> " + giokt + "";
            string masan= dt.Rows[0][10].ToString();
            DataTable tensan = data.TruyVan("select* from san where masan='" + masan + "'");
            lb_tensan.Text = tensan.Rows[0][1].ToString();
            string loaisan= tensan.Rows[0][3].ToString();
            DataTable gia = data.TruyVan("select* from loaisan where maloaisan='" + loaisan + "'");
            lb_gia.Text = gia.Rows[0][2].ToString();
            lb_tong.Text = dt.Rows[0][6].ToString();
        }

        private void inhoadon_Load(object sender, EventArgs e)
        {
            xuathoadon(matk, madatsan);
        }
    }
}
