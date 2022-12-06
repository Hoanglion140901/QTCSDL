using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BT_HDN_Click(object sender, EventArgs e)
        {
            HoaDonNhap f = new HoaDonNhap();
            f.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_HDB_Click(object sender, EventArgs e)
        {
            HoaDonBan f = new HoaDonBan();
            f.ShowDialog();
        }

        private void BT_HH_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            f.ShowDialog();
        }

        private void BT_NCC_Click(object sender, EventArgs e)
        {
            Nhacungcap f = new Nhacungcap();
            f.ShowDialog();
        }

        private void BT_KH_Click(object sender, EventArgs e)
        {
            Khachhang f = new Khachhang();
            f.ShowDialog();
        }

        private void BT_NV_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            f.ShowDialog();
        }

        private void BT_DNNCT_Click(object sender, EventArgs e)
        {
            NhapChiTiet f = new NhapChiTiet();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BanChiTiet f = new BanChiTiet();
            f.ShowDialog();
        }
    }
}