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
    public partial class NhanVien : Form
    {
        string chuoiketnoi = @"Data Source=DONGPHUONG\SQLEXPRESS;Initial Catalog=QLBH_HOI;Integrated Security=True";
        public NhanVien()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
            string sql = "Select * from NHANVIEN";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();

            dt.Fill(ds, "NHANVIEN");

            dataGridView1.DataSource = ds.Tables["NHANVIEN"];

            conn.Close();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txttennv.Clear();
            txtsodienthoai.Clear();
            dateTimePicker1.ResetText();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void BT_THEM_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmanv.Text != "" && txttennv.Text != "" && txtsodienthoai.Text != "" )
                {
                    conn.Open();
                    string sql = " insert into NHANVIEN values('" + txtmanv.Text + "',N'" + txttennv.Text + "','" + dateTimePicker1.Text + "','" + txtsodienthoai.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
            string sMANV = txtmanv.Text;
            string sTENNV = txttennv.Text;
            string sSDT = txtsodienthoai.Text;
            string sNGAYSINH = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sql = "UPDATE NHANVIEN SET tennv=@TENNV, ngaysinh=@NGAYSINH, sdt=@SDT where manv = @MANV";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MANV", sMANV);
            cmd.Parameters.AddWithValue("@TENNV", sTENNV);
            cmd.Parameters.AddWithValue("@NGAYSINH", sNGAYSINH);
            cmd.Parameters.AddWithValue("@SDT", sSDT);
            int kq = (int)cmd.ExecuteNonQuery();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
            conn.Close();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql = " delete from nhanvien where manv='" + txtmanv.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công!");
                load();
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttennv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsodienthoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Show();
        }
    }
}
