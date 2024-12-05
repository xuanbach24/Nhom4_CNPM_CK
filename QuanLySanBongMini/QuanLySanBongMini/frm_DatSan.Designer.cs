namespace QuanLySanBongMini
{
    partial class frm_DatSan
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.but_Reset = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_Them = new FontAwesome.Sharp.IconButton();
            this.but_Xoa = new FontAwesome.Sharp.IconButton();
            this.but_Sua = new FontAwesome.Sharp.IconButton();
            this.btn_report = new FontAwesome.Sharp.IconButton();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.Combo_ThanhToan = new System.Windows.Forms.ComboBox();
            this.Combo_TrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wcfInstantFeedbackSource1 = new DevExpress.Data.WcfLinq.WcfInstantFeedbackSource();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_GioKT = new System.Windows.Forms.TextBox();
            this.txt_GioBD = new System.Windows.Forms.TextBox();
            this.SanSo = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.LoaiSan = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label6, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label6.Location = new System.Drawing.Point(25, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Họ Tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label7, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label7.Location = new System.Drawing.Point(467, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số Điện Thoại:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 468);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1438, 322);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TongTien
            // 
            this.TongTien.AutoSize = true;
            this.TongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongTien.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.TongTien, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.TongTien.Location = new System.Drawing.Point(25, 187);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(96, 22);
            this.TongTien.TabIndex = 19;
            this.TongTien.Text = "Tổng Tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label9, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label9.Location = new System.Drawing.Point(25, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Thanh Toán:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label10, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label10.Location = new System.Drawing.Point(467, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Trạng Thái Sân:";
            // 
            // but_Reset
            // 
            this.but_Reset.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Reset.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.but_Reset.FlatAppearance.BorderSize = 0;
            this.but_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.but_Reset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Reset.ForeColor = System.Drawing.Color.White;
            this.errorProvider1.SetIconAlignment(this.but_Reset, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.but_Reset.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.but_Reset.IconColor = System.Drawing.Color.White;
            this.but_Reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorProvider1.SetIconPadding(this.but_Reset, 2);
            this.but_Reset.IconSize = 25;
            this.but_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Reset.Location = new System.Drawing.Point(529, 258);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Padding = new System.Windows.Forms.Padding(2);
            this.but_Reset.Size = new System.Drawing.Size(119, 38);
            this.but_Reset.TabIndex = 39;
            this.but_Reset.Text = "   Reset";
            this.but_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Reset.UseVisualStyleBackColor = false;
            this.but_Reset.Click += new System.EventHandler(this.but_Reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label5, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label5.Location = new System.Drawing.Point(37, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại Sân:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label8, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label8.Location = new System.Drawing.Point(37, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sân Số: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label4, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label4.Location = new System.Drawing.Point(37, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giờ Kết Thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label3, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giờ Bắt Đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.errorProvider1.SetIconAlignment(this.label2, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Đặt Sân:";
            // 
            // but_Them
            // 
            this.but_Them.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Them.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.but_Them.FlatAppearance.BorderSize = 0;
            this.but_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.but_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Them.ForeColor = System.Drawing.Color.White;
            this.but_Them.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.but_Them.IconColor = System.Drawing.Color.White;
            this.but_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorProvider1.SetIconPadding(this.but_Them, 2);
            this.but_Them.IconSize = 25;
            this.but_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Them.Location = new System.Drawing.Point(29, 258);
            this.but_Them.Name = "but_Them";
            this.but_Them.Padding = new System.Windows.Forms.Padding(2);
            this.but_Them.Size = new System.Drawing.Size(119, 38);
            this.but_Them.TabIndex = 36;
            this.but_Them.Text = "   Đặt Sân";
            this.but_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Them.UseVisualStyleBackColor = false;
            this.but_Them.Click += new System.EventHandler(this.but_Them_Click);
            // 
            // but_Xoa
            // 
            this.but_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.but_Xoa.FlatAppearance.BorderSize = 0;
            this.but_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.but_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Xoa.ForeColor = System.Drawing.Color.White;
            this.but_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.but_Xoa.IconColor = System.Drawing.Color.White;
            this.but_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorProvider1.SetIconPadding(this.but_Xoa, 2);
            this.but_Xoa.IconSize = 25;
            this.but_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Xoa.Location = new System.Drawing.Point(198, 258);
            this.but_Xoa.Name = "but_Xoa";
            this.but_Xoa.Padding = new System.Windows.Forms.Padding(2);
            this.but_Xoa.Size = new System.Drawing.Size(119, 38);
            this.but_Xoa.TabIndex = 37;
            this.but_Xoa.Text = "   Xóa";
            this.but_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Xoa.UseVisualStyleBackColor = false;
            this.but_Xoa.Click += new System.EventHandler(this.but_Xoa_Click);
            // 
            // but_Sua
            // 
            this.but_Sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Sua.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.but_Sua.FlatAppearance.BorderSize = 0;
            this.but_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.but_Sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Sua.ForeColor = System.Drawing.Color.White;
            this.but_Sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.but_Sua.IconColor = System.Drawing.Color.White;
            this.but_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorProvider1.SetIconPadding(this.but_Sua, 2);
            this.but_Sua.IconSize = 25;
            this.but_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Sua.Location = new System.Drawing.Point(363, 258);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Padding = new System.Windows.Forms.Padding(2);
            this.but_Sua.Size = new System.Drawing.Size(119, 38);
            this.but_Sua.TabIndex = 38;
            this.but_Sua.Text = "   Sửa";
            this.but_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Sua.UseVisualStyleBackColor = false;
            this.but_Sua.Click += new System.EventHandler(this.but_Sua_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_report.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btn_report.IconColor = System.Drawing.Color.White;
            this.btn_report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorProvider1.SetIconPadding(this.btn_report, 2);
            this.btn_report.IconSize = 25;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(692, 258);
            this.btn_report.Name = "btn_report";
            this.btn_report.Padding = new System.Windows.Forms.Padding(2);
            this.btn_report.Size = new System.Drawing.Size(156, 38);
            this.btn_report.TabIndex = 40;
            this.btn_report.Text = "Report";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.ForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.Location = new System.Drawing.Point(182, 54);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(238, 30);
            this.txt_HoTen.TabIndex = 12;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.ForeColor = System.Drawing.Color.Black;
            this.txt_SDT.Location = new System.Drawing.Point(648, 54);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(194, 30);
            this.txt_SDT.TabIndex = 14;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.ForeColor = System.Drawing.Color.Black;
            this.txt_TongTien.Location = new System.Drawing.Point(182, 184);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(238, 30);
            this.txt_TongTien.TabIndex = 20;
            // 
            // Combo_ThanhToan
            // 
            this.Combo_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_ThanhToan.ForeColor = System.Drawing.Color.Black;
            this.Combo_ThanhToan.FormattingEnabled = true;
            this.Combo_ThanhToan.Location = new System.Drawing.Point(182, 113);
            this.Combo_ThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Combo_ThanhToan.Name = "Combo_ThanhToan";
            this.Combo_ThanhToan.Size = new System.Drawing.Size(238, 30);
            this.Combo_ThanhToan.TabIndex = 16;
            this.Combo_ThanhToan.Text = "--Chọn--";
            // 
            // Combo_TrangThai
            // 
            this.Combo_TrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_TrangThai.ForeColor = System.Drawing.Color.Black;
            this.Combo_TrangThai.FormattingEnabled = true;
            this.Combo_TrangThai.Location = new System.Drawing.Point(648, 113);
            this.Combo_TrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Combo_TrangThai.Name = "Combo_TrangThai";
            this.Combo_TrangThai.Size = new System.Drawing.Size(194, 30);
            this.Combo_TrangThai.TabIndex = 18;
            this.Combo_TrangThai.Text = "--Chọn--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(164, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 50);
            this.label1.TabIndex = 28;
            this.label1.Text = "Đặt Sân Bóng";
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 10;
            this.sidebartimer.Tick += new System.EventHandler(this.sibartimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Sua);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_report);
            this.groupBox1.Controls.Add(this.TongTien);
            this.groupBox1.Controls.Add(this.but_Reset);
            this.groupBox1.Controls.Add(this.Combo_TrangThai);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.but_Xoa);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Combo_ThanhToan);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.but_Them);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(142, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 323);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txt_GioKT
            // 
            this.txt_GioKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioKT.Location = new System.Drawing.Point(222, 157);
            this.txt_GioKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GioKT.Name = "txt_GioKT";
            this.txt_GioKT.Size = new System.Drawing.Size(163, 30);
            this.txt_GioKT.TabIndex = 6;
            // 
            // txt_GioBD
            // 
            this.txt_GioBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioBD.Location = new System.Drawing.Point(222, 108);
            this.txt_GioBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GioBD.Name = "txt_GioBD";
            this.txt_GioBD.Size = new System.Drawing.Size(163, 30);
            this.txt_GioBD.TabIndex = 4;
            // 
            // SanSo
            // 
            this.SanSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanSo.FormattingEnabled = true;
            this.SanSo.Location = new System.Drawing.Point(222, 249);
            this.SanSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SanSo.Name = "SanSo";
            this.SanSo.Size = new System.Drawing.Size(163, 30);
            this.SanSo.TabIndex = 10;
            this.SanSo.Text = "--Chọn--";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(222, 52);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(247, 30);
            this.date.TabIndex = 2;
            // 
            // LoaiSan
            // 
            this.LoaiSan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiSan.FormattingEnabled = true;
            this.LoaiSan.Location = new System.Drawing.Point(222, 201);
            this.LoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoaiSan.Name = "LoaiSan";
            this.LoaiSan.Size = new System.Drawing.Size(163, 30);
            this.LoaiSan.TabIndex = 8;
            this.LoaiSan.Text = "--Chọn--";
            this.LoaiSan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LoaiSan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_GioBD);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.SanSo);
            this.groupBox2.Controls.Add(this.txt_GioKT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(1074, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 325);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sân ";
            // 
            // sidebar
            // 
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.sidebar.MaximumSize = new System.Drawing.Size(350, 860);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 860);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(70, 860);
            this.sidebar.TabIndex = 45;
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
            this.btn_trangchu.TabIndex = 20;
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
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.btn_DangXuat);
            this.panel11.Location = new System.Drawing.Point(3, 647);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(374, 68);
            this.panel11.TabIndex = 27;
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(25, 74);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(302, 68);
            this.panel12.TabIndex = 21;
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
            // frm_DatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1592, 821);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DatSan";
            this.Text = "frm_DatSan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFormClosing);
            this.Load += new System.EventHandler(this.frm_DatSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label TongTien;
        private System.Windows.Forms.ComboBox Combo_TrangThai;
        private System.Windows.Forms.ComboBox Combo_ThanhToan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton but_Them;
        private FontAwesome.Sharp.IconButton btn_report;
        private FontAwesome.Sharp.IconButton but_Reset;
        private FontAwesome.Sharp.IconButton but_Sua;
        private FontAwesome.Sharp.IconButton but_Xoa;
        private DevExpress.Data.WcfLinq.WcfInstantFeedbackSource wcfInstantFeedbackSource1;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LoaiSan;
        private System.Windows.Forms.TextBox txt_GioBD;
        private System.Windows.Forms.TextBox txt_GioKT;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SanSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
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
        private FontAwesome.Sharp.IconButton btn_trangchu;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
    }
}