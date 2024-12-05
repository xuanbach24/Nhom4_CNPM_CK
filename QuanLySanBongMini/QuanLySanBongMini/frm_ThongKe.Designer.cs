namespace QuanLySanBongMini
{
    partial class frm_ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.date_bd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bieudo = new DevExpress.XtraCharts.ChartControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bieudotron = new DevExpress.XtraCharts.ChartControl();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_menu = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_datsan = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_TKCN = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_QLSan = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_QLTK = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_HoaDon = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_trangchu = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new FontAwesome.Sharp.IconButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.bieudo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieudotron)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_bd
            // 
            this.date_bd.Location = new System.Drawing.Point(237, 169);
            this.date_bd.Name = "date_bd";
            this.date_bd.Size = new System.Drawing.Size(259, 22);
            this.date_bd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn Thống Kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(266, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống Kê Sân Bóng";
            // 
            // bieudo
            // 
            this.bieudo.Location = new System.Drawing.Point(6, 20);
            this.bieudo.Name = "bieudo";
            this.bieudo.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.bieudo.Size = new System.Drawing.Size(606, 367);
            this.bieudo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bieudo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 393);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biểu Đồ Doanh Thu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bieudotron);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(772, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 542);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Biểu Đồ SL Đặt Sân";
            // 
            // bieudotron
            // 
            this.bieudotron.Location = new System.Drawing.Point(6, 20);
            this.bieudotron.Name = "bieudotron";
            this.bieudotron.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.bieudotron.Size = new System.Drawing.Size(757, 516);
            this.bieudotron.TabIndex = 0;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel11);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.White;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(350, 760);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 760);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(70, 760);
            this.sidebar.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 120);
            this.panel1.TabIndex = 21;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Black;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btn_menu.IconColor = System.Drawing.Color.White;
            this.btn_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menu.IconSize = 50;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(-3, 23);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(377, 77);
            this.btn_menu.TabIndex = 10;
            this.btn_menu.Text = "  MENU";
            this.btn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_datsan);
            this.panel2.Location = new System.Drawing.Point(3, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 68);
            this.panel2.TabIndex = 22;
            // 
            // btn_datsan
            // 
            this.btn_datsan.BackColor = System.Drawing.Color.Black;
            this.btn_datsan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_datsan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_datsan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datsan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datsan.ForeColor = System.Drawing.Color.White;
            this.btn_datsan.IconChar = FontAwesome.Sharp.IconChar.FutbolBall;
            this.btn_datsan.IconColor = System.Drawing.Color.White;
            this.btn_datsan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_datsan.IconSize = 50;
            this.btn_datsan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datsan.Location = new System.Drawing.Point(-4, -4);
            this.btn_datsan.Name = "btn_datsan";
            this.btn_datsan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_datsan.Size = new System.Drawing.Size(377, 77);
            this.btn_datsan.TabIndex = 16;
            this.btn_datsan.Text = "  Đặt Sân Bóng";
            this.btn_datsan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_datsan.UseVisualStyleBackColor = false;
            this.btn_datsan.Click += new System.EventHandler(this.btn_datsan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_TKCN);
            this.panel3.Location = new System.Drawing.Point(3, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 68);
            this.panel3.TabIndex = 23;
            // 
            // btn_TKCN
            // 
            this.btn_TKCN.BackColor = System.Drawing.Color.Black;
            this.btn_TKCN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TKCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TKCN.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TKCN.ForeColor = System.Drawing.Color.White;
            this.btn_TKCN.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_TKCN.IconColor = System.Drawing.Color.White;
            this.btn_TKCN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_TKCN.IconSize = 50;
            this.btn_TKCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TKCN.Location = new System.Drawing.Point(-4, -4);
            this.btn_TKCN.Name = "btn_TKCN";
            this.btn_TKCN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_TKCN.Size = new System.Drawing.Size(377, 77);
            this.btn_TKCN.TabIndex = 17;
            this.btn_TKCN.Text = "  Tài Khoản Cá Nhân";
            this.btn_TKCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TKCN.UseVisualStyleBackColor = false;
            this.btn_TKCN.Click += new System.EventHandler(this.btn_TKCN_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_QLSan);
            this.panel4.Location = new System.Drawing.Point(3, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 68);
            this.panel4.TabIndex = 24;
            // 
            // btn_QLSan
            // 
            this.btn_QLSan.BackColor = System.Drawing.Color.Black;
            this.btn_QLSan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QLSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLSan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLSan.ForeColor = System.Drawing.Color.White;
            this.btn_QLSan.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btn_QLSan.IconColor = System.Drawing.Color.White;
            this.btn_QLSan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QLSan.IconSize = 50;
            this.btn_QLSan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLSan.Location = new System.Drawing.Point(-4, -4);
            this.btn_QLSan.Name = "btn_QLSan";
            this.btn_QLSan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_QLSan.Size = new System.Drawing.Size(377, 77);
            this.btn_QLSan.TabIndex = 16;
            this.btn_QLSan.Text = "  Quản Lý Sân Bóng";
            this.btn_QLSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLSan.UseVisualStyleBackColor = false;
            this.btn_QLSan.Click += new System.EventHandler(this.btn_QLSan_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_QLTK);
            this.panel5.Location = new System.Drawing.Point(3, 351);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 68);
            this.panel5.TabIndex = 23;
            // 
            // btn_QLTK
            // 
            this.btn_QLTK.BackColor = System.Drawing.Color.Black;
            this.btn_QLTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QLTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLTK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTK.ForeColor = System.Drawing.Color.White;
            this.btn_QLTK.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btn_QLTK.IconColor = System.Drawing.Color.White;
            this.btn_QLTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QLTK.IconSize = 50;
            this.btn_QLTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLTK.Location = new System.Drawing.Point(-4, -4);
            this.btn_QLTK.Name = "btn_QLTK";
            this.btn_QLTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_QLTK.Size = new System.Drawing.Size(377, 77);
            this.btn_QLTK.TabIndex = 18;
            this.btn_QLTK.Text = "  Quản Lý Tài Khoản";
            this.btn_QLTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLTK.UseVisualStyleBackColor = false;
            this.btn_QLTK.Click += new System.EventHandler(this.btn_QLTK_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.btn_ThongKe);
            this.panel6.Location = new System.Drawing.Point(3, 425);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 68);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(25, 74);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(302, 68);
            this.panel7.TabIndex = 21;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Black;
            this.btn_ThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btn_ThongKe.IconColor = System.Drawing.Color.White;
            this.btn_ThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ThongKe.IconSize = 50;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(-4, -4);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ThongKe.Size = new System.Drawing.Size(377, 77);
            this.btn_ThongKe.TabIndex = 19;
            this.btn_ThongKe.Text = "  Thống Kê";
            this.btn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_HoaDon);
            this.panel8.Location = new System.Drawing.Point(3, 499);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(374, 68);
            this.panel8.TabIndex = 25;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.Black;
            this.btn_HoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_HoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btn_HoaDon.IconColor = System.Drawing.Color.White;
            this.btn_HoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_HoaDon.IconSize = 50;
            this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.Location = new System.Drawing.Point(-4, -4);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_HoaDon.Size = new System.Drawing.Size(377, 77);
            this.btn_HoaDon.TabIndex = 20;
            this.btn_HoaDon.Text = "  Hóa Đơn";
            this.btn_HoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_trangchu);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(3, 573);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(374, 68);
            this.panel9.TabIndex = 26;
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.BackColor = System.Drawing.Color.Black;
            this.btn_trangchu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_trangchu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_trangchu.FlatAppearance.BorderSize = 0;
            this.btn_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trangchu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.ForeColor = System.Drawing.Color.White;
            this.btn_trangchu.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btn_trangchu.IconColor = System.Drawing.Color.White;
            this.btn_trangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_trangchu.IconSize = 60;
            this.btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.Location = new System.Drawing.Point(-4, -4);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_trangchu.Size = new System.Drawing.Size(377, 77);
            this.btn_trangchu.TabIndex = 22;
            this.btn_trangchu.Text = "Trang Chủ";
            this.btn_trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_trangchu.UseVisualStyleBackColor = false;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(25, 74);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(302, 68);
            this.panel10.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_DangXuat);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(3, 647);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(374, 68);
            this.panel11.TabIndex = 27;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_DangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btn_DangXuat.IconColor = System.Drawing.Color.White;
            this.btn_DangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DangXuat.IconSize = 60;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(-4, -4);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_DangXuat.Size = new System.Drawing.Size(377, 77);
            this.btn_DangXuat.TabIndex = 20;
            this.btn_DangXuat.Text = "  Đăng Xuất";
            this.btn_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(25, 74);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(302, 68);
            this.panel12.TabIndex = 21;
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 10;
            this.sidebartimer.Tick += new System.EventHandler(this.sibartimer_Tick);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(527, 125);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(2);
            this.iconButton1.Size = new System.Drawing.Size(184, 39);
            this.iconButton1.TabIndex = 45;
            this.iconButton1.Text = "Thống Kê Tháng";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btn_TKRandom_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(527, 203);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(2);
            this.iconButton2.Size = new System.Drawing.Size(184, 39);
            this.iconButton2.TabIndex = 46;
            this.iconButton2.Text = "Thống Kê Năm";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.btn_TKNam_Click);
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1553, 743);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_bd);
            this.Name = "frm_ThongKe";
            this.Text = "frm_ThongKe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFormClosing);
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bieudo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bieudotron)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date_bd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl bieudo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraCharts.ChartControl bieudotron;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_menu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_datsan;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_TKCN;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_QLSan;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btn_QLTK;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton btn_ThongKe;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton btn_HoaDon;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton btn_DangXuat;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Timer sidebartimer;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private FontAwesome.Sharp.IconButton btn_trangchu;
    }
}