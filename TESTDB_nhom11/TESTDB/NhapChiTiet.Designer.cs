namespace TESTDB
{
    partial class NhapChiTiet
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
            this.CapNhat = new System.Windows.Forms.Button();
            this.Sửa = new System.Windows.Forms.Button();
            this.Thêm = new System.Windows.Forms.Button();
            this.Xóa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CapNhat
            // 
            this.CapNhat.BackColor = System.Drawing.Color.Azure;
            this.CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CapNhat.Location = new System.Drawing.Point(870, 474);
            this.CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.Size = new System.Drawing.Size(195, 26);
            this.CapNhat.TabIndex = 67;
            this.CapNhat.Text = "Cập Nhật";
            this.CapNhat.UseVisualStyleBackColor = false;
            this.CapNhat.Click += new System.EventHandler(this.CapNhat_Click);
            // 
            // Sửa
            // 
            this.Sửa.BackColor = System.Drawing.Color.Azure;
            this.Sửa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sửa.Location = new System.Drawing.Point(335, 524);
            this.Sửa.Margin = new System.Windows.Forms.Padding(4);
            this.Sửa.Name = "Sửa";
            this.Sửa.Size = new System.Drawing.Size(195, 26);
            this.Sửa.TabIndex = 66;
            this.Sửa.Text = "Sửa Hóa Đơn";
            this.Sửa.UseVisualStyleBackColor = false;
            this.Sửa.Click += new System.EventHandler(this.Sửa_Click);
            // 
            // Thêm
            // 
            this.Thêm.BackColor = System.Drawing.Color.Azure;
            this.Thêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thêm.Location = new System.Drawing.Point(68, 524);
            this.Thêm.Margin = new System.Windows.Forms.Padding(4);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(195, 26);
            this.Thêm.TabIndex = 65;
            this.Thêm.Text = "Thêm Hóa Đơn";
            this.Thêm.UseVisualStyleBackColor = false;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // Xóa
            // 
            this.Xóa.BackColor = System.Drawing.Color.Azure;
            this.Xóa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Xóa.Location = new System.Drawing.Point(604, 524);
            this.Xóa.Margin = new System.Windows.Forms.Padding(4);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(195, 26);
            this.Xóa.TabIndex = 64;
            this.Xóa.Text = "Xóa Hóa Đơn";
            this.Xóa.UseVisualStyleBackColor = false;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(370, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(373, 36);
            this.label10.TabIndex = 63;
            this.label10.Text = "Thông Tin Nhập Chi Tiết ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(55, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "Mã Mặt Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(624, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 61;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(624, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Thành Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(55, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Mã Hóa Đơn Nhập";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMaMH
            // 
            this.txtMaMH.BackColor = System.Drawing.Color.Azure;
            this.txtMaMH.Location = new System.Drawing.Point(272, 84);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(296, 24);
            this.txtMaMH.TabIndex = 58;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.Azure;
            this.txtThanhTien.Location = new System.Drawing.Point(768, 87);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(296, 24);
            this.txtThanhTien.TabIndex = 57;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.BackColor = System.Drawing.Color.Azure;
            this.txtMaHDN.Location = new System.Drawing.Point(272, 51);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(296, 24);
            this.txtMaHDN.TabIndex = 56;
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.Azure;
            this.txtSL.Location = new System.Drawing.Point(768, 51);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(296, 24);
            this.txtSL.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 326);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.Azure;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thoat.Location = new System.Drawing.Point(870, 524);
            this.Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(195, 26);
            this.Thoat.TabIndex = 53;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(604, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 26);
            this.button1.TabIndex = 68;
            this.button1.Text = "Nhập Lại";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NhapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1155, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CapNhat);
            this.Controls.Add(this.Sửa);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Thoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NhapChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapChiTiet";
            this.Load += new System.EventHandler(this.NhapChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CapNhat;
        private Button Sửa;
        private Button Thêm;
        private Button Xóa;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtMaMH;
        private TextBox txtThanhTien;
        private TextBox txtMaHDN;
        private TextBox txtSL;
        private DataGridView dataGridView1;
        private Button Thoat;
        private Button button1;
    }
}