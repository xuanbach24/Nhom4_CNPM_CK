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
    public partial class frm_report : Form
    {
        public frm_report()
        {
            InitializeComponent();
        }

        private void frm_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSanBongDaMiniDataSet.DatSan' table. You can move, or remove it, as needed.
            this.DatSanTableAdapter.Fill(this.QLSanBongDaMiniDataSet.DatSan);

            this.reportViewer1.RefreshReport();
        }
    }
}
