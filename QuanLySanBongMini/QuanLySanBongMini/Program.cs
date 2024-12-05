using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Application.Run(new frm_DangNhap());
        }
        static void OnApplicationExit(object sender, EventArgs e)
        {
            // Đóng tất cả các form đang mở
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }
    }
}
