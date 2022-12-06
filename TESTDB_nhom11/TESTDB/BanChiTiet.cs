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
    public partial class BanChiTiet : Form
    {
        string ChuoiKetNoi = @"Data Source=DONGPHUONG\SQLEXPRESS;Initial Catalog=QLBH_HOI;Integrated Security=True";
        public BanChiTiet()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "select * from BAN_CHI_TIET";
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
        private void BanChiTiet_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                if (textMaHDBC.Text != "" && txtMaMH.Text != "" && txtSL.Text != "" && txtThanhTien.Text != "")
                {
                    conn.Open();
                    string sql = "insert into BAN_CHI_TIET values('" + textMaHDBC.Text + "','" + txtMaMH.Text + "','" + txtSL.Text + "','" + txtThanhTien.Text + "')";

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
                string sql = "update BAN_CHI_TIET set soluong='" + txtSL.Text + "',thanhtien='" + txtThanhTien.Text + "' where MaHDB='" + textMaHDBC.Text + "' and mamh='"+txtMaMH.Text+"'";
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

        private void Xóa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(ChuoiKetNoi);
                conn.Open();
                string sql = "delete from BAN_CHI_TIET where MaHDB='" + textMaHDBC.Text + "' and mamh='" + txtMaMH + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                load();
                conn.Close();

            }
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Show();
        }

        private void textMaHDBC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaHDBC.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMaMH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtThanhTien.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
        }

        private void Nhaplai_Click(object sender, EventArgs e)
        {
            textMaHDBC.Clear();
            txtMaMH.Clear();
            txtSL.Clear();
            txtThanhTien.Clear();
        }
    }
}
