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

namespace QuanLyBenhVien.UI
{
    public partial class uc_Thongtincanhan : UserControl
    {
        public uc_Thongtincanhan()
        {
            InitializeComponent();
        }
        private void uc_Thongtincanhan_Load(object sender, EventArgs e)
        {

            lblcmnd.Text= Cons.Cons.loginnhanvien.CMND;
            lblTen.Text = Cons.Cons.loginnhanvien.Ten;
            lblNgaySinh.Text = Cons.Cons.loginnhanvien.NgaySinh.ToString();
            lblGioitinh.Text = Cons.Cons.loginnhanvien.GioiTinh;
            lblex.Text = Cons.Cons.loginnhanvien.Ex.ToString();
            lblDiaChi.Text = Cons.Cons.loginnhanvien.DiaChi;
            lblSdt.Text = Cons.Cons.loginnhanvien.SDT;
            lblChucvu.Text = Cons.Cons.chucvu;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lblChucvu_Click(object sender, EventArgs e)
        {

        }

        private void lblSdt_Click(object sender, EventArgs e)
        {

        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void lblGioitinh_Click(object sender, EventArgs e)
        {

        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
