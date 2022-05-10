using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.UI
{
    public partial class uc_Thongtincanhan1 : UserControl
    {
        public uc_Thongtincanhan1()
        {
            InitializeComponent();
        }

        private void uc_Thongtincanhan1_Load(object sender, EventArgs e)
        {
            lblcmnd.Text = Cons.Cons.loginnhanvien.CMND;
            lblTen.Text = Cons.Cons.loginnhanvien.Ten;
            lblNgaySinh.Text = Cons.Cons.loginnhanvien.NgaySinh.ToString();
            lblGioitinh.Text = Cons.Cons.loginnhanvien.GioiTinh;
            lblex.Text = Cons.Cons.loginnhanvien.Ex.ToString();
            lblDiaChi.Text = Cons.Cons.loginnhanvien.DiaChi;
            lblSdt.Text = Cons.Cons.loginnhanvien.SDT;
            lblChucvu.Text = Cons.Cons.chucvu;
            lblhang.Text = Cons.Cons.loginnhanvien.Hang.ToString();
            lblbac.Text = Cons.Cons.loginnhanvien.Bac.ToString();
        }
    }
}
