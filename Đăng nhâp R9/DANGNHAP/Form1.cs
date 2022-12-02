using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string chuoiketnoi = @"Data Source=LEON;Initial Catalog=QLBH_HOI;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        //Phương thức load dữ liệu lên
        public void load()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
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


        private void Form1_Load(object sender, EventArgs e)
        {
            load();

        }

        private void NhapLai_Click(object sender, EventArgs e)
        {
            txtMaHH.Clear();
            txtTenHH.Clear();
            TxtDonGiaBan.Clear();
            txtDonGiaMua.Clear();
            txtSoLuong.Clear();
        }

        private void CapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void ThemMoi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtMaHH.Text != "" && txtTenHH.Text != "" && txtDonGiaMua.Text != "" && TxtDonGiaBan.Text != "" && txtSoLuong.Text != "")
                {
                    conn.Open();
                    //
                    string sql = "insert into HANGHOA values('" +txtMaHH.Text+"','"+txtTenHH.Text+"',"+TxtDonGiaBan.Text+"," + txtDonGiaMua.Text+ "," +txtSoLuong.Text+ ")";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        load();
                    }
                    else
                        MessageBox.Show("thêm thất bại");
                    conn.Close();
                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin");
                

                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }

        }

        private void Sua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "update HANGHOA set TenMH='" +txtTenHH.Text+ "' where MaMH='"+txtMaHH.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa Thành Công");
                    load();
                }
                else
                    MessageBox.Show("thêm thất bại");

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
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?","Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thongbao==DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql = "delete from HANGHOA where MaMH='" + txtMaHH.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                load();
                conn.Close();
            }    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
