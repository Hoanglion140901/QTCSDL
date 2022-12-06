namespace TESTDB
{
    partial class BanChiTiet
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
            this.Sửa = new System.Windows.Forms.Button();
            this.Thêm = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.Xóa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.textMaHDBC = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nhaplai = new System.Windows.Forms.Button();
            this.CapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sửa
            // 
            this.Sửa.BackColor = System.Drawing.Color.Azure;
            this.Sửa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sửa.Location = new System.Drawing.Point(339, 489);
            this.Sửa.Margin = new System.Windows.Forms.Padding(4);
            this.Sửa.Name = "Sửa";
            this.Sửa.Size = new System.Drawing.Size(216, 26);
            this.Sửa.TabIndex = 51;
            this.Sửa.Text = "Sửa Hóa Đơn";
            this.Sửa.UseVisualStyleBackColor = false;
            this.Sửa.Click += new System.EventHandler(this.Sửa_Click);
            // 
            // Thêm
            // 
            this.Thêm.BackColor = System.Drawing.Color.Azure;
            this.Thêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thêm.Location = new System.Drawing.Point(98, 489);
            this.Thêm.Margin = new System.Windows.Forms.Padding(4);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(216, 26);
            this.Thêm.TabIndex = 50;
            this.Thêm.Text = "Thêm Hóa Đơn";
            this.Thêm.UseVisualStyleBackColor = false;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // Thoát
            // 
            this.Thoát.BackColor = System.Drawing.Color.Azure;
            this.Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thoát.Location = new System.Drawing.Point(829, 489);
            this.Thoát.Margin = new System.Windows.Forms.Padding(4);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(216, 26);
            this.Thoát.TabIndex = 49;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = false;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // Xóa
            // 
            this.Xóa.BackColor = System.Drawing.Color.Azure;
            this.Xóa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Xóa.Location = new System.Drawing.Point(588, 489);
            this.Xóa.Margin = new System.Windows.Forms.Padding(4);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(216, 26);
            this.Xóa.TabIndex = 48;
            this.Xóa.Text = "Xóa Hóa Đơn";
            this.Xóa.UseVisualStyleBackColor = false;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(330, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 36);
            this.label10.TabIndex = 47;
            this.label10.Text = "THÔNG TIN BÁN CHI TIẾT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(98, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "Mã Mặt Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(608, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(608, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Thành Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(98, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã Hóa Đơn Bán";
            // 
            // txtMaMH
            // 
            this.txtMaMH.BackColor = System.Drawing.Color.Azure;
            this.txtMaMH.Location = new System.Drawing.Point(284, 99);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(296, 24);
            this.txtMaMH.TabIndex = 42;
            this.txtMaMH.TextChanged += new System.EventHandler(this.txtMaMH_TextChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.Azure;
            this.txtThanhTien.Location = new System.Drawing.Point(748, 100);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(296, 24);
            this.txtThanhTien.TabIndex = 41;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // textMaHDBC
            // 
            this.textMaHDBC.BackColor = System.Drawing.Color.Azure;
            this.textMaHDBC.Location = new System.Drawing.Point(284, 61);
            this.textMaHDBC.Margin = new System.Windows.Forms.Padding(4);
            this.textMaHDBC.Name = "textMaHDBC";
            this.textMaHDBC.Size = new System.Drawing.Size(296, 24);
            this.textMaHDBC.TabIndex = 40;
            this.textMaHDBC.TextChanged += new System.EventHandler(this.textMaHDBC_TextChanged);
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.Azure;
            this.txtSL.Location = new System.Drawing.Point(748, 61);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(296, 24);
            this.txtSL.TabIndex = 39;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 289);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nhaplai
            // 
            this.Nhaplai.BackColor = System.Drawing.Color.Azure;
            this.Nhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nhaplai.Location = new System.Drawing.Point(588, 449);
            this.Nhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.Nhaplai.Name = "Nhaplai";
            this.Nhaplai.Size = new System.Drawing.Size(216, 26);
            this.Nhaplai.TabIndex = 52;
            this.Nhaplai.Text = "Nhập Lại";
            this.Nhaplai.UseVisualStyleBackColor = false;
            this.Nhaplai.Click += new System.EventHandler(this.Nhaplai_Click);
            // 
            // CapNhat
            // 
            this.CapNhat.BackColor = System.Drawing.Color.Azure;
            this.CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CapNhat.Location = new System.Drawing.Point(829, 449);
            this.CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.Size = new System.Drawing.Size(216, 26);
            this.CapNhat.TabIndex = 53;
            this.CapNhat.Text = "Cập nhật";
            this.CapNhat.UseVisualStyleBackColor = false;
            this.CapNhat.Click += new System.EventHandler(this.button2_Click);
            // 
            // BanChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1152, 538);
            this.Controls.Add(this.CapNhat);
            this.Controls.Add(this.Nhaplai);
            this.Controls.Add(this.Sửa);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.textMaHDBC);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BanChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Chi Tiết";
            this.Load += new System.EventHandler(this.BanChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Sửa;
        private Button Thêm;
        private Button Thoát;
        private Button Xóa;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtMaMH;
        private TextBox txtThanhTien;
        private TextBox textMaHDBC;
        private TextBox txtSL;
        private DataGridView dataGridView1;
        private Button Nhaplai;
        private Button CapNhat;
    }
}