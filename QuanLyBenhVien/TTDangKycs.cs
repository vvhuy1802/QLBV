using DevExpress.XtraEditors;
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

namespace QuanLyBenhVien
{
    public partial class TTDangKycs : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection;
        string str = @"data source=ADMIN\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public TTDangKycs()
        {
            InitializeComponent();
        }
        private void TTDangKycs_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
        }
        private void TTDangKycs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new DangNhap();
            f.Show();
        }
        void ThemTTNV()
        {
            using(QuanLyBenhVienEntities db=new QuanLyBenhVienEntities())
            {
                string cmnd = txtcmnd.Text;
                string ten = txtten.Text;
                System.DateTime time = System.DateTime.Parse(dtpNgaySinh.Text);
                string sdt = txtsdt.Text;
                string gioitinh = cbxGT.Text;
                int ex = int.Parse(txtex.Text);
                string quoctich = txtQT.Text;
                string diachi = txtDiaChi.Text;
                int cv = 1;
                if (cbxChucVu.Text == "Lễ tân") cv = 1;
                else if (cbxChucVu.Text == "Bác sĩ") cv = 2;
                else if (cbxChucVu.Text == "Quản lý") cv = 3;
                string hang = cbxHang.Text;
                Nullable<short> bac = short.Parse(txtBac.Text);
                decimal luong = decimal.Parse(txtLuong.Text);
                float heso = float.Parse(txtHeSo.Text);
                int ngay = 0;
                decimal trocap = decimal.Parse(txtTrocap.Text);
                var t = db.NhanViens.Where(p => p.CMND.Equals(cmnd));
                NhanVien u = t.Count() == 1 ? t.Single() : null;
                if (u != null)
                {
                    MessageBox.Show("CMND nhân viên đã tồn tại!");
                }
                else
                {
                    NhanVien nv = new NhanVien()
                    {
                        CMND = cmnd,
                        Ten = ten,
                        NgaySinh = time,
                        SDT=sdt,
                        GioiTinh=gioitinh,
                        Ex=ex,
                        QuocTich=quoctich,
                        DiaChi=diachi,
                        IDchucvu=cv,
                        Hang=hang,
                        Bac=bac
                    };
                    db.NhanViens.Add(nv);
                    BangLuong bl = new BangLuong()
                    {
                        CMND=cmnd,
                        Ngay=ngay,
                        LuongCB=luong,
                        HeSo=heso,
                        Trocap=trocap,
                    };
                    db.BangLuongs.Add(bl);
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký thành công!");
                    DangKy f = new DangKy();
                    f.Show();
                    this.Hide();
                }    
            }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txtcmnd.Text == "")
            {
                MessageBox.Show("Bạn chưa CMND!");
                txtcmnd.Focus();
            }
            else if (txtten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!");
                txtten.Focus();
            }
            else if (cbxGT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!");
                cbxGT.Focus();
            }
            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!");
                txtsdt.Focus();
            }
            else if (dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh!");
                dtpNgaySinh.Focus();
            }
            else if (txtex.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm kinh nghiệm!");
                txtex.Focus();
            }
            else if (txtQT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch!");
                txtQT.Focus();
            }
            else if (cbxChucVu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn chức vụ!");
                cbxChucVu.Focus();
            }
            else if (cbxHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hạng!");
                cbxHang.Focus();
            }
            else if (txtBac.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bậc!");
                txtBac.Focus();
            }
            else if (txtLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lương cơ bản!");
                txtLuong.Focus();
            }
            else if (txtHeSo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hệ số!");
                txtHeSo.Focus();
            }
            else if (txtTrocap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lương trọ cấp!");
                txtTrocap.Focus();
            }
            else ThemTTNV();
        }
    }
}