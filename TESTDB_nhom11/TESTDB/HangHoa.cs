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
    public partial class HangHoa : Form
    {
        string ChuoiKetNoi = @"Data Source=DONGPHUONG\SQLEXPRESS;Initial Catalog=QLBH_HOI;Integrated Security=True";
        public HangHoa()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "select * from HANGHOA";
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
        private void HangHoa_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                if (txtMaMH.Text != "" && txtTenMH.Text != "" && txtDonGiaBan.Text != "" && txtDonGiaNhap.Text != "" && txtSoLuong.Text != "")
                {
                    conn.Open();
                    string sql = "insert into HANGHOA values('" + txtMaMH.Text + "','" + txtTenMH.Text + "','" + txtDonGiaBan.Text + "','" + txtDonGiaNhap.Text + "','" + txtSoLuong.Text + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                conn.Open();
                 string sql = "update HANGHOA set TenMH='" + txtTenMH.Text + "',Dongiaban" + txtDonGiaBan.Text + "',Dongiamua='" + txtDonGiaNhap.Text + "',SL='" + txtSoLuong.Text + "' where MaMH='" + txtMaMH.Text+"'";
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

        private void Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(ChuoiKetNoi);
                conn.Open();
                string sql = "delete from HANGHOA where MaMH='" + txtMaMH.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                load();
                conn.Close();

            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Show();
        }

        private void NhapLai_Click(object sender, EventArgs e)
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtDonGiaBan.Clear();
            txtDonGiaNhap.Clear();
            txtSoLuong.Clear();
        }

        private void CapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDonGiaNhap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDonGiaBan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
