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
    public partial class uc_Quanlyloaithuoc : UserControl
    {
        string str = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        public uc_Quanlyloaithuoc()
        {
            InitializeComponent();
        }

        private void uc_Quanlyloaithuoc_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadThuoc(dtgvthuoc);
            BindingThuoc(dtgvthuoc);
        }
        private void BindingThuoc(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgv.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txbid.DataBindings.Clear();
            txbid.DataBindings.Add(bdID);
            Binding bdTen = new Binding("Text", dtgv.DataSource, "Ten", true, DataSourceUpdateMode.OnPropertyChanged);
            txbten.DataBindings.Clear();
            txbten.DataBindings.Add(bdTen);
            Binding bdGia = new Binding("Text", dtgv.DataSource, "Gia", true, DataSourceUpdateMode.OnPropertyChanged);
            txbgia.DataBindings.Clear();
            txbgia.DataBindings.Add(bdGia);
        }

        private void LoadThuoc(DataGridView dtgvbenh)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                var source = from thuoc in db.LoaiThuocs
                             select new
                             {
                                 ID = thuoc.ID,
                                 Ten = thuoc.Ten,
                                 Gia = thuoc.Gia
                             };
                dtgvbenh.DataSource = source.ToList();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbid.Text);
                    string ten = txbten.Text;
                    if (db.LoaiThuocs.Select(m => m.ID).Contains(id))
                    {
                        MessageBox.Show("This ID was in database!");
                        return;
                    }
                    string tendv = txbten.Text;
                    decimal giadv = decimal.Parse(txbgia.Text);

                    LoaiThuoc p = new LoaiThuoc()
                    {
                        ID = id,
                        Ten = tendv,
                        Gia = giadv
                    };
                    db.LoaiThuocs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Added Successfully!");
                    LoadThuoc(dtgvthuoc);
                }
                catch { MessageBox.Show("Please fill in information!"); }
            }
            BindingThuoc(dtgvthuoc);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbid.Text);
                    db.LoaiThuocs.Remove(db.LoaiThuocs.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Removed!");
                    LoadThuoc(dtgvthuoc);
                }
                catch { }
            }
            BindingThuoc(dtgvthuoc);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbid.Text);
                    LoaiThuoc dv = db.LoaiThuocs.Find(id);
                    string tendv = txbten.Text;
                    decimal giadv = decimal.Parse(txbgia.Text);
                    dv.ID = id;
                    dv.Ten = tendv;
                    dv.Gia = giadv;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadThuoc(dtgvthuoc);
                }
                catch { }
            }
            BindingThuoc(dtgvthuoc);
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT ID as ID,Ten as Ten,Gia as Gia FROM dbo.LoaiThuoc WHERE Ten LIKE N'%" + txbtimkiem.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvthuoc.DataSource = dt;
            dtgvthuoc.Refresh();
            BindingThuoc(dtgvthuoc);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbid.Text);
                    string ten = txbten.Text;
                    if (db.LoaiThuocs.Select(m => m.ID).Contains(id))
                    {
                        MessageBox.Show("This ID was in database!");
                        return;
                    }
                    string tendv = txbten.Text;
                    decimal giadv = decimal.Parse(txbgia.Text);

                    LoaiThuoc p = new LoaiThuoc()
                    {
                        ID = id,
                        Ten = tendv,
                        Gia = giadv
                    };
                    db.LoaiThuocs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Added Successfully!");
                    LoadThuoc(dtgvthuoc);
                }
                catch { MessageBox.Show("Please fill in information!"); }
            }
            BindingThuoc(dtgvthuoc);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbid.Text);
                    db.LoaiThuocs.Remove(db.LoaiThuocs.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Removed!");
                    LoadThuoc(dtgvthuoc);
                }
                catch { }
            }
            BindingThuoc(dtgvthuoc);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbid.Text);
                    LoaiThuoc dv = db.LoaiThuocs.Find(id);
                    string tendv = txbten.Text;
                    decimal giadv = decimal.Parse(txbgia.Text);
                    dv.ID = id;
                    dv.Ten = tendv;
                    dv.Gia = giadv;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadThuoc(dtgvthuoc);
                }
                catch { }
            }
            BindingThuoc(dtgvthuoc);
        }
    }
}
