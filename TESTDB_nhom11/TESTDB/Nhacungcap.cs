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

namespace TESTDB
{
    public partial class Nhacungcap : Form
    {
        string chuoiketnoi = @"Data Source=DONGPHUONG\SQLEXPRESS;Initial Catalog=QLBH_HOI;Integrated Security=True";
        public Nhacungcap()
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
            string sql = "Select * from NHACUNGCAP";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();

            dt.Fill(ds, "NHACUNGCAP");

            dataGridView1.DataSource = ds.Tables["NHACUNGCAP"];

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            txtmancc.Clear();
            txttenncc.Clear();
            txtsodienthoai.Clear();
            txtdiachi.Clear();
            txtsotaikhoan.Clear();
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
                if (txtmancc.Text != "" && txttenncc.Text != "" && txtsodienthoai.Text != "" && txtdiachi.Text != "")
                {
                    conn.Open();
                    string sql = " insert into NHACUNGCAP values('" + txtmancc.Text + "',N'" + txttenncc.Text + "','" + txtsodienthoai.Text + "',N'" + txtdiachi.Text + "','" + txtsotaikhoan.Text + "')";
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
                string sql = " update NHACUNGCAP set tenncc=N'" + txttenncc.Text + "',diachincc=N'" + txtdiachi.Text + "'," +
                    "sdtncc='" + txtsodienthoai.Text + "', stk='" + txtsotaikhoan.Text + "' where MaNCC='" + txtmancc.Text + "'";
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
                string sql = " delete from nhacungcap where mancc='" + txtmancc.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công!");
                load();
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmancc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttenncc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsodienthoai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsotaikhoan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Show();
        }

        private void txtmancc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}