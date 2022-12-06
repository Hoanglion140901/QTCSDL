namespace TESTDB
{
    partial class HoaDonNhap
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
            this.txtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.Sửa = new System.Windows.Forms.Button();
            this.Thêm = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.CapNhat = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.CalendarMonthBackground = System.Drawing.Color.White;
            this.txtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayNhap.Location = new System.Drawing.Point(693, 61);
            this.txtNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(296, 24);
            this.txtNgayNhap.TabIndex = 66;
            // 
            // Sửa
            // 
            this.Sửa.BackColor = System.Drawing.Color.Azure;
            this.Sửa.Location = new System.Drawing.Point(328, 554);
            this.Sửa.Margin = new System.Windows.Forms.Padding(4);
            this.Sửa.Name = "Sửa";
            this.Sửa.Size = new System.Drawing.Size(144, 26);
            this.Sửa.TabIndex = 65;
            this.Sửa.Text = "Sửa Hóa Đơn";
            this.Sửa.UseVisualStyleBackColor = false;
            this.Sửa.Click += new System.EventHandler(this.Sửa_Click);
            // 
            // Thêm
            // 
            this.Thêm.BackColor = System.Drawing.Color.Azure;
            this.Thêm.Location = new System.Drawing.Point(56, 554);
            this.Thêm.Margin = new System.Windows.Forms.Padding(4);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(154, 26);
            this.Thêm.TabIndex = 64;
            this.Thêm.Text = "Thêm Hóa Đơn";
            this.Thêm.UseVisualStyleBackColor = false;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // Thoát
            // 
            this.Thoát.BackColor = System.Drawing.Color.Azure;
            this.Thoát.Location = new System.Drawing.Point(858, 554);
            this.Thoát.Margin = new System.Windows.Forms.Padding(4);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(141, 26);
            this.Thoát.TabIndex = 63;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = false;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // CapNhat
            // 
            this.CapNhat.BackColor = System.Drawing.Color.Azure;
            this.CapNhat.Location = new System.Drawing.Point(860, 501);
            this.CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.Size = new System.Drawing.Size(141, 26);
            this.CapNhat.TabIndex = 62;
            this.CapNhat.Text = "Cập Nhật";
            this.CapNhat.UseVisualStyleBackColor = false;
            this.CapNhat.Click += new System.EventHandler(this.CapNhat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(421, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 36);
            this.label10.TabIndex = 61;
            this.label10.Text = "HÓA ĐƠN NHẬP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(63, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Mã Nhà Cung Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(573, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ngày Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(573, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Tổng Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Mã Hóa Đơn Nhập";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BackColor = System.Drawing.Color.Azure;
            this.txtMaNCC.Location = new System.Drawing.Point(226, 106);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(296, 24);
            this.txtMaNCC.TabIndex = 56;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.Azure;
            this.txtTongTien.Location = new System.Drawing.Point(693, 109);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(296, 24);
            this.txtTongTien.TabIndex = 55;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.BackColor = System.Drawing.Color.Azure;
            this.txtMaHDN.Location = new System.Drawing.Point(226, 64);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(296, 24);
            this.txtMaHDN.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 326);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Azure;
            this.bt_xoa.Location = new System.Drawing.Point(600, 554);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(144, 26);
            this.bt_xoa.TabIndex = 67;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(676, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 26);
            this.button1.TabIndex = 68;
            this.button1.Text = "Nhập lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.txtNgayNhap);
            this.Controls.Add(this.Sửa);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.CapNhat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker txtNgayNhap;
        private Button Sửa;
        private Button Thêm;
        private Button Thoát;
        private Button CapNhat;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtMaNCC;
        private TextBox txtTongTien;
        private TextBox txtMaHDN;
        private DataGridView dataGridView1;
        private Button bt_xoa;
        private Button button1;
    }
}