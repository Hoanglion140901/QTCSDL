namespace TESTDB
{
    partial class Nhacungcap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manhacungcap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_THEM = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.Label();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtsotaikhoan = new System.Windows.Forms.TextBox();
            this.sotaikhoan = new System.Windows.Forms.Label();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.sodienthoai = new System.Windows.Forms.Label();
            this.bt_nhaplai = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.tennhacungcap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 326);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // manhacungcap
            // 
            this.manhacungcap.AutoSize = true;
            this.manhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manhacungcap.Location = new System.Drawing.Point(30, 68);
            this.manhacungcap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manhacungcap.Name = "manhacungcap";
            this.manhacungcap.Size = new System.Drawing.Size(145, 18);
            this.manhacungcap.TabIndex = 1;
            this.manhacungcap.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(355, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BT_THEM
            // 
            this.BT_THEM.BackColor = System.Drawing.Color.Azure;
            this.BT_THEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BT_THEM.Location = new System.Drawing.Point(110, 277);
            this.BT_THEM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BT_THEM.Name = "BT_THEM";
            this.BT_THEM.Size = new System.Drawing.Size(124, 32);
            this.BT_THEM.TabIndex = 3;
            this.BT_THEM.Text = "Thêm";
            this.BT_THEM.UseVisualStyleBackColor = false;
            this.BT_THEM.Click += new System.EventHandler(this.BT_THEM_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Azure;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.Location = new System.Drawing.Point(386, 277);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(124, 32);
            this.bt_sua.TabIndex = 4;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Azure;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_xoa.Location = new System.Drawing.Point(649, 277);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(124, 32);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // txtmancc
            // 
            this.txtmancc.BackColor = System.Drawing.Color.Azure;
            this.txtmancc.Location = new System.Drawing.Point(219, 61);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmancc.Multiline = true;
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(335, 31);
            this.txtmancc.TabIndex = 6;
            this.txtmancc.TextChanged += new System.EventHandler(this.txtmancc_TextChanged);
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.Azure;
            this.txtdiachi.Location = new System.Drawing.Point(219, 184);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(890, 31);
            this.txtdiachi.TabIndex = 8;
            // 
            // diachi
            // 
            this.diachi.AutoSize = true;
            this.diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diachi.Location = new System.Drawing.Point(30, 197);
            this.diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(60, 18);
            this.diachi.TabIndex = 12;
            this.diachi.Text = "Địa chỉ";
            // 
            // txttenncc
            // 
            this.txttenncc.BackColor = System.Drawing.Color.Azure;
            this.txttenncc.Location = new System.Drawing.Point(768, 61);
            this.txttenncc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttenncc.Multiline = true;
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(335, 31);
            this.txttenncc.TabIndex = 13;
            // 
            // txtsotaikhoan
            // 
            this.txtsotaikhoan.BackColor = System.Drawing.Color.Azure;
            this.txtsotaikhoan.Location = new System.Drawing.Point(768, 120);
            this.txtsotaikhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsotaikhoan.Multiline = true;
            this.txtsotaikhoan.Name = "txtsotaikhoan";
            this.txtsotaikhoan.Size = new System.Drawing.Size(335, 31);
            this.txtsotaikhoan.TabIndex = 14;
            // 
            // sotaikhoan
            // 
            this.sotaikhoan.AutoSize = true;
            this.sotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sotaikhoan.Location = new System.Drawing.Point(569, 128);
            this.sotaikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sotaikhoan.Name = "sotaikhoan";
            this.sotaikhoan.Size = new System.Drawing.Size(110, 18);
            this.sotaikhoan.TabIndex = 15;
            this.sotaikhoan.Text = "Số Tài Khoản";
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.BackColor = System.Drawing.Color.Azure;
            this.txtsodienthoai.Location = new System.Drawing.Point(219, 120);
            this.txtsodienthoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsodienthoai.Multiline = true;
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(335, 31);
            this.txtsodienthoai.TabIndex = 16;
            // 
            // sodienthoai
            // 
            this.sodienthoai.AutoSize = true;
            this.sodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sodienthoai.Location = new System.Drawing.Point(30, 128);
            this.sodienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.Size = new System.Drawing.Size(115, 18);
            this.sodienthoai.TabIndex = 17;
            this.sodienthoai.Text = "Số Điện Thoại";
            // 
            // bt_nhaplai
            // 
            this.bt_nhaplai.BackColor = System.Drawing.Color.Azure;
            this.bt_nhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_nhaplai.Location = new System.Drawing.Point(811, 229);
            this.bt_nhaplai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_nhaplai.Name = "bt_nhaplai";
            this.bt_nhaplai.Size = new System.Drawing.Size(124, 32);
            this.bt_nhaplai.TabIndex = 18;
            this.bt_nhaplai.Text = "Nhập lại";
            this.bt_nhaplai.UseVisualStyleBackColor = false;
            this.bt_nhaplai.Click += new System.EventHandler(this.bt_nhaplai_Click);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.BackColor = System.Drawing.Color.Azure;
            this.bt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_capnhat.Location = new System.Drawing.Point(986, 229);
            this.bt_capnhat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(124, 32);
            this.bt_capnhat.TabIndex = 19;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = false;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.Azure;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.Location = new System.Drawing.Point(914, 277);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(124, 32);
            this.bt_thoat.TabIndex = 20;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // tennhacungcap
            // 
            this.tennhacungcap.AutoSize = true;
            this.tennhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tennhacungcap.Location = new System.Drawing.Point(569, 68);
            this.tennhacungcap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tennhacungcap.Name = "tennhacungcap";
            this.tennhacungcap.Size = new System.Drawing.Size(150, 18);
            this.tennhacungcap.TabIndex = 21;
            this.tennhacungcap.Text = "Tên Nhà Cung Cấp";
            // 
            // Nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1151, 584);
            this.Controls.Add(this.tennhacungcap);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_nhaplai);
            this.Controls.Add(this.sodienthoai);
            this.Controls.Add(this.txtsodienthoai);
            this.Controls.Add(this.sotaikhoan);
            this.Controls.Add(this.txtsotaikhoan);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.BT_THEM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manhacungcap);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Nhacungcap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhacungcap";
            this.Load += new System.EventHandler(this.Nhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label manhacungcap;
        private Label label2;
        private Button BT_THEM;
        private Button bt_sua;
        private Button bt_xoa;
        private TextBox txtmancc;
        private TextBox txtdiachi;
        private Label diachi;
        private TextBox txttenncc;
        private TextBox txtsotaikhoan;
        private Label sotaikhoan;
        private TextBox txtsodienthoai;
        private Label sodienthoai;
        private Button bt_nhaplai;
        private Button bt_capnhat;
        private Button bt_thoat;
        private Label tennhacungcap;
    }
}