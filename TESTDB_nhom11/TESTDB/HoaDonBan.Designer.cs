namespace TESTDB
{
    partial class HoaDonBan
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
            this.Thoat = new System.Windows.Forms.Button();
            this.txtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.Sửa = new System.Windows.Forms.Button();
            this.Thêm = new System.Windows.Forms.Button();
            this.Lưu = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.Azure;
            this.Thoat.Location = new System.Drawing.Point(843, 582);
            this.Thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(168, 26);
            this.Thoat.TabIndex = 41;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.txtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayBan.Location = new System.Drawing.Point(720, 71);
            this.txtNgayBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(296, 24);
            this.txtNgayBan.TabIndex = 40;
            // 
            // Sửa
            // 
            this.Sửa.BackColor = System.Drawing.Color.Azure;
            this.Sửa.Location = new System.Drawing.Point(341, 582);
            this.Sửa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sửa.Name = "Sửa";
            this.Sửa.Size = new System.Drawing.Size(163, 26);
            this.Sửa.TabIndex = 39;
            this.Sửa.Text = "Sửa Hóa Đơn";
            this.Sửa.UseVisualStyleBackColor = false;
            this.Sửa.Click += new System.EventHandler(this.Sửa_Click);
            // 
            // Thêm
            // 
            this.Thêm.BackColor = System.Drawing.Color.Azure;
            this.Thêm.Location = new System.Drawing.Point(63, 582);
            this.Thêm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(178, 26);
            this.Thêm.TabIndex = 38;
            this.Thêm.Text = "Thêm Hóa Đơn";
            this.Thêm.UseVisualStyleBackColor = false;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // Lưu
            // 
            this.Lưu.BackColor = System.Drawing.Color.Azure;
            this.Lưu.Location = new System.Drawing.Point(608, 540);
            this.Lưu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lưu.Name = "Lưu";
            this.Lưu.Size = new System.Drawing.Size(156, 26);
            this.Lưu.TabIndex = 37;
            this.Lưu.Text = "Nhập lại";
            this.Lưu.UseVisualStyleBackColor = false;
            this.Lưu.Click += new System.EventHandler(this.Lưu_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Azure;
            this.bt_xoa.Location = new System.Drawing.Point(608, 582);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(156, 26);
            this.bt_xoa.TabIndex = 36;
            this.bt_xoa.Text = "Xóa Hóa Đơn";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(407, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 36);
            this.label9.TabIndex = 35;
            this.label9.Text = "HÓA ĐƠN BÁN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(608, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tổng Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.Azure;
            this.txtMaKH.Location = new System.Drawing.Point(249, 135);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(296, 24);
            this.txtMaKH.TabIndex = 31;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.Azure;
            this.txtTongTien.Location = new System.Drawing.Point(720, 103);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(296, 24);
            this.txtTongTien.TabIndex = 30;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.Azure;
            this.txtMaNV.Location = new System.Drawing.Point(249, 104);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(296, 24);
            this.txtMaNV.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Hóa Đơn Bán";
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.BackColor = System.Drawing.Color.Azure;
            this.txtMaHDB.Location = new System.Drawing.Point(249, 72);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(296, 24);
            this.txtMaHDB.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 326);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(608, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ngày Bán";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(843, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 26);
            this.button1.TabIndex = 43;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1061, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.txtNgayBan);
            this.Controls.Add(this.Sửa);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.Lưu);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHDB);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "HoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAN";
            this.Load += new System.EventHandler(this.BAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Thoat;
        private DateTimePicker txtNgayBan;
        private Button Sửa;
        private Button Thêm;
        private Button Lưu;
        private Button bt_xoa;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMaKH;
        private TextBox txtTongTien;
        private TextBox txtMaNV;
        private Label label1;
        private TextBox txtMaHDB;
        private DataGridView dataGridView1;
        private Label label5;
        private Button button1;
    }
}