using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTDB
{
    public partial class HoaDonNhap : Form
    {
        string ChuoiKetNoi = @"Data Source=DONGPHUONG\SQLEXPRESS;Initial Catalog=QLBH_HOI;Integrated Security=True";
        public HoaDonNhap()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "select * from NHAP";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridView1.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Show();
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                if (txtMaHDN.Text != "" && txtMaNCC.Text != "" && txtNgayNhap.Text != "" && txtTongTien.Text != "")
                {
                    conn.Open();
                    string sql = "insert into NHAP values('" + txtMaHDN.Text + "','" + txtMaNCC.Text + "','" + txtNgayNhap.Text + "','" + txtTongTien.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        load();
                    }
                    else
                        MessageBox.Show("Thêm thất bại");
                    conn.Close();
                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin");
                //

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void Sửa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "update NHAP set MaNCC='" + txtMaNCC.Text + "' where MaHDN='" + txtMaHDN.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    load();
                }
                else
                    MessageBox.Show("Sửa thất bại");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void CapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(ChuoiKetNoi);
                conn.Open();
                string sql = " delete from NHAP where mahdn='" + txtMaHDN.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công!");
                load();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaHDN.Clear();
            txtMaNCC.Clear();
            txtTongTien.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMaNCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNgayNhap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTongTien.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
