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
    public partial class HoaDonBan : Form
    {
        string ChuoiKetNoi = @"Data Source=DONGPHUONG\SQLEXPRESS;Initial Catalog=QLBH_HOI;Integrated Security=True";
        public HoaDonBan()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "select * from BAN";
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
        private void BAN_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                if (txtMaHDB.Text != "" && txtMaNV.Text != "" && txtMaKH.Text != "" && txtNgayBan.Text != "" && txtTongTien.Text != "")
                {
                    conn.Open();
                    string sql = "insert into BAN values('" + txtMaHDB.Text + "','" + txtMaNV.Text + "','" + txtMaKH.Text + "','" + txtNgayBan.Text + "','" + txtTongTien.Text + "')";

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
                string sql = "update BAN set MaNV='" + txtMaNV.Text + "',makh='"+txtMaKH.Text+"',NgayBH='"+txtNgayBan.Text+"',Tongtien='"+txtTongTien.Text+"' where MaHDB='" + txtMaHDB.Text + "'";
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

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(ChuoiKetNoi);
                conn.Open();
                string sql = "delete from BAN where MaHDB='" + txtMaHDB.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                load();
                conn.Close();

            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            txtMaHDB.Clear();
            txtMaNV.Clear();
            txtMaKH.Clear();
            txtTongTien.Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMaNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMaKH.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNgayBan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
