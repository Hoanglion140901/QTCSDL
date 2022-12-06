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
    public partial class Khachhang : Form
    {
        string chuoiketnoi = @"Data Source=DONGPHUONG\SQLEXPRESS;Initial Catalog=QLBH_HOI;Integrated Security=True";
        public Khachhang()
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
            string sql = "Select * from KHACHHANG";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();

            dt.Fill(ds, "KHACHHANG");

            dataGridView1.DataSource = ds.Tables["KHACHHANG"];

            conn.Close();
        }
        private void Khachhang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
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
                if (txt_makh.Text != "" && txt_tenkh.Text != "" && txt_sdt.Text != "")
                {
                    conn.Open();
                    string sql = " insert into KHACHHANG values('" + txt_makh.Text + "',N'" + txt_tenkh.Text + "','" + txt_sdt.Text + "',N'" + txt_diachi.Text + "')";
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
                string sql = " update KHACHHANG set tenkh=N'" + txt_tenkh.Text + "',sdt=N'" + txt_sdt.Text + "'," + 
                             "diachi='" + txt_diachi.Text + "' where makh='"+ txt_makh.Text +"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    load();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql = " delete from Khachhang where makh='" + txt_makh.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công!");
                load();
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sdt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_diachi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
