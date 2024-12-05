namespace QuanLySanBongMini
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.txt_mk = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1_DangNhap = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(827, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 666);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.Color.Transparent;
            this.txt_sdt.BaseColor = System.Drawing.Color.White;
            this.txt_sdt.BorderColor = System.Drawing.Color.Silver;
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_sdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_sdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_sdt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(752, 278);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.Radius = 15;
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.Size = new System.Drawing.Size(347, 40);
            this.txt_sdt.TabIndex = 10;
            this.txt_sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mk
            // 
            this.txt_mk.BackColor = System.Drawing.Color.Transparent;
            this.txt_mk.BaseColor = System.Drawing.Color.White;
            this.txt_mk.BorderColor = System.Drawing.Color.Silver;
            this.txt_mk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mk.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_mk.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_mk.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mk.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(752, 396);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Radius = 15;
            this.txt_mk.SelectedText = "";
            this.txt_mk.Size = new System.Drawing.Size(347, 40);
            this.txt_mk.TabIndex = 11;
            this.txt_mk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(747, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(747, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // button1_DangNhap
            // 
            this.button1_DangNhap.AnimationHoverSpeed = 0.07F;
            this.button1_DangNhap.AnimationSpeed = 0.03F;
            this.button1_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.button1_DangNhap.BaseColor = System.Drawing.Color.Black;
            this.button1_DangNhap.BorderColor = System.Drawing.Color.Black;
            this.button1_DangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1_DangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.button1_DangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_DangNhap.ForeColor = System.Drawing.Color.White;
            this.button1_DangNhap.Image = null;
            this.button1_DangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.button1_DangNhap.Location = new System.Drawing.Point(752, 508);
            this.button1_DangNhap.Name = "button1_DangNhap";
            this.button1_DangNhap.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.button1_DangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1_DangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.button1_DangNhap.OnHoverImage = null;
            this.button1_DangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.button1_DangNhap.Radius = 15;
            this.button1_DangNhap.Size = new System.Drawing.Size(347, 39);
            this.button1_DangNhap.TabIndex = 14;
            this.button1_DangNhap.Text = "Đăng Nhập";
            this.button1_DangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1_DangNhap.Click += new System.EventHandler(this.button1_DangNhap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(957, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Forgot Password";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 0;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.gunaTextBox1.Enabled = false;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Font = new System.Drawing.Font("Snap ITC", 19.8F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Location = new System.Drawing.Point(0, -1);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.ReadOnly = true;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(631, 122);
            this.gunaTextBox1.TabIndex = 17;
            this.gunaTextBox1.Text = "   QUẢN LÝ SÂN BÓNG MINI";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1_DangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DangNhap";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Quản Lý Sân Bóng MINI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txt_sdt;
        private Guna.UI.WinForms.GunaTextBox txt_mk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton button1_DangNhap;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
    }
}

