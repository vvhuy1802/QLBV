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
    public partial class uc_BenhNhan : UserControl
    {
        string str = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        public uc_BenhNhan()
        {
            InitializeComponent();
        }

        private void uc_BenhNhan_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadBenhNhan(dataGridView1);
            BindingBenhnhan(dataGridView1);
        }
        void LoadBenhNhan(DataGridView dtgv)
        {
            using(QuanLyBenhVienEntities db=new QuanLyBenhVienEntities())
            {
                var source = from benhnhan in db.BenhNhans
                             select new
                             {
                                 CMND = benhnhan.CMND,
                                 CMNDBS=benhnhan.CMNDBS,
                                 Ten=benhnhan.Ten,
                                 NgaySinh=benhnhan.NgaySinh,
                                 GioiTinh=benhnhan.GioiTinh,
                                 DiaChi=benhnhan.DiaChi,
                                 SoDienThoai=benhnhan.SDT,
                                 QuocTich=benhnhan.QuocTich,
                                 BaoHiem=benhnhan.BaoHiem,
                                 NgayNhapVien=benhnhan.NhanVien,
                             };
                dtgv.DataSource = source.ToList();
            }
        }
        void BindingBenhnhan(DataGridView dtgv)
        {
            Binding bdCMND = new Binding("Text", dtgv.DataSource, "CMND", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add(bdCMND);
            Binding bdCMNDBS = new Binding("Text", dtgv.DataSource, "CMNDBS", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCMNDBS.DataBindings.Clear();
            txtCMNDBS.DataBindings.Add(bdCMNDBS);
            Binding bdTen = new Binding("Text", dtgv.DataSource, "Ten", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add(bdTen);
            Binding bdNgaySinh = new Binding("Text", dtgv.DataSource, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add(bdNgaySinh);
            Binding bdGioiTinh = new Binding("Text", dtgv.DataSource, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            cbxGioitinh.DataBindings.Clear();
            cbxGioitinh.DataBindings.Add(bdGioiTinh);
            Binding bdDiaChi = new Binding("Text", dtgv.DataSource, "DiaChi", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add(bdDiaChi);
            Binding bdSDT = new Binding("Text", dtgv.DataSource, "SoDienThoai", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add(bdSDT);
            Binding bdQuocTich = new Binding("Text", dtgv.DataSource, "QuocTich", true, DataSourceUpdateMode.OnPropertyChanged);
            txtQuoctich.DataBindings.Clear();
            txtQuoctich.DataBindings.Add(bdQuocTich);
            Binding bdBaoHiem = new Binding("Text", dtgv.DataSource, "BaoHiem", true, DataSourceUpdateMode.OnPropertyChanged);
            cbxBaohiem.DataBindings.Clear();
            cbxBaohiem.DataBindings.Add(bdBaoHiem);
            Binding bdNhapVien = new Binding("Text", dtgv.DataSource, "NgayNhapVien", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNhapvien.DataBindings.Clear();
            dtpNhapvien.DataBindings.Add(bdNhapVien);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(QuanLyBenhVienEntities db=new QuanLyBenhVienEntities())
            {
                try
                {
                    string cmnd = txtCMND.Text;
                    if (db.BenhNhans.Select(m => m.CMND).Contains(cmnd))
                    {
                        MessageBox.Show("This CMND was in database!");
                        return;
                    }
                    string cmndbs = txtCMNDBS.Text;
                    string ten = txtTen.Text;
                    DateTime ngaysinh = DateTime.Parse(dtpNgaysinh.Text);
                    ngaysinh.ToString("dd-MM-yyyy");
                    string gioitinh = cbxGioitinh.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    string quoctich = txtQuoctich.Text;
                    int baohiem = int.Parse(cbxBaohiem.Text);
                    DateTime nhapvien = DateTime.Parse(dtpNhapvien.Text);
                    BenhNhan p = new BenhNhan()
                    {
                        CMND = cmnd,
                        CMNDBS = cmndbs,
                        Ten = ten,
                        NgaySinh = ngaysinh,
                        GioiTinh = gioitinh,
                        DiaChi = diachi,
                        SDT = sdt,
                        QuocTich = quoctich,
                        BaoHiem = baohiem,
                        NhapVien = nhapvien
                    };
                    db.BenhNhans.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Added Successfully!");
                    LoadBenhNhan(dataGridView1);
                }
                catch { MessageBox.Show("Please fill in information!"); }
            }
            BindingBenhnhan(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db= new QuanLyBenhVienEntities())
            {
                try
                {
                    string cmnd = txtCMND.Text;
                    BenhNhan dv = db.BenhNhans.Find(cmnd);
                    string cmndbs = txtCMNDBS.Text;
                    string ten = txtTen.Text;
                    DateTime ngaysinh = DateTime.Parse(dtpNgaysinh.Text);
                    string gioitinh = cbxGioitinh.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    string quoctich = txtQuoctich.Text;
                    int baohiem = int.Parse(cbxBaohiem.Text);
                    DateTime nhapvien = DateTime.Parse(dtpNhapvien.Text);
                    dv.CMND = cmnd;
                    dv.CMNDBS = cmndbs;
                    dv.Ten = ten;
                    dv.NgaySinh = ngaysinh;
                    dv.GioiTinh = gioitinh;
                    dv.DiaChi = diachi;
                    dv.SDT = sdt;
                    dv.QuocTich = quoctich;
                    dv.BaoHiem = baohiem;
                    dv.NhapVien = nhapvien;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadBenhNhan(dataGridView1);
                }
                catch { }
            }
            BindingBenhnhan(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string cmnd = txtCMND.Text;
                    db.BenhNhans.Remove(db.BenhNhans.Find(cmnd));
                    db.SaveChanges();
                    MessageBox.Show("Removed!");
                    LoadBenhNhan(dataGridView1);
                }
                catch { }
            }
            BindingBenhnhan(dataGridView1);
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT CMND as CMND,CMNDBS as CMNDBS,Ten as Ten,NgaySinh as NgaySinh,GioiTinh as GioiTinh,DiaChi as DiaChi,SDT as SoDienThoai,QuocTich as QuocTich,BaoHiem as BaoHiem,NhapVien as NgayNhapVien FROM dbo.BenhNhan WHERE Ten LIKE N'%" + txbtimkiem.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            BindingBenhnhan(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string cmnd = txtCMND.Text;
                    if (db.BenhNhans.Select(m => m.CMND).Contains(cmnd))
                    {
                        MessageBox.Show("This CMND was in database!");
                        return;
                    }
                    string cmndbs = txtCMNDBS.Text;
                    string ten = txtTen.Text;
                    DateTime ngaysinh = DateTime.Parse(dtpNgaysinh.Text);
                    ngaysinh.ToString("dd-MM-yyyy");
                    string gioitinh = cbxGioitinh.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    string quoctich = txtQuoctich.Text;
                    int baohiem = int.Parse(cbxBaohiem.Text);
                    DateTime nhapvien = DateTime.Parse(dtpNhapvien.Text);
                    BenhNhan p = new BenhNhan()
                    {
                        CMND = cmnd,
                        CMNDBS = cmndbs,
                        Ten = ten,
                        NgaySinh = ngaysinh,
                        GioiTinh = gioitinh,
                        DiaChi = diachi,
                        SDT = sdt,
                        QuocTich = quoctich,
                        BaoHiem = baohiem,
                        NhapVien = nhapvien
                    };
                    db.BenhNhans.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Added Successfully!");
                    LoadBenhNhan(dataGridView1);
                }
                catch { MessageBox.Show("Please fill in information!"); }
            }
            BindingBenhnhan(dataGridView1);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string cmnd = txtCMND.Text;
                    BenhNhan dv = db.BenhNhans.Find(cmnd);
                    string cmndbs = txtCMNDBS.Text;
                    string ten = txtTen.Text;
                    DateTime ngaysinh = DateTime.Parse(dtpNgaysinh.Text);
                    string gioitinh = cbxGioitinh.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    string quoctich = txtQuoctich.Text;
                    int baohiem = int.Parse(cbxBaohiem.Text);
                    DateTime nhapvien = DateTime.Parse(dtpNhapvien.Text);
                    dv.CMND = cmnd;
                    dv.CMNDBS = cmndbs;
                    dv.Ten = ten;
                    dv.NgaySinh = ngaysinh;
                    dv.GioiTinh = gioitinh;
                    dv.DiaChi = diachi;
                    dv.SDT = sdt;
                    dv.QuocTich = quoctich;
                    dv.BaoHiem = baohiem;
                    dv.NhapVien = nhapvien;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadBenhNhan(dataGridView1);
                }
                catch { }
            }
            BindingBenhnhan(dataGridView1);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string cmnd = txtCMND.Text;
                    db.BenhNhans.Remove(db.BenhNhans.Find(cmnd));
                    db.SaveChanges();
                    MessageBox.Show("Removed!");
                    LoadBenhNhan(dataGridView1);
                }
                catch { }
            }
            BindingBenhnhan(dataGridView1);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
