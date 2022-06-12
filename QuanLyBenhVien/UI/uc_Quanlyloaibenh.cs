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
    public partial class uc_Quanlyloaibenh : UserControl
    {
        string str = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        public uc_Quanlyloaibenh()
        {
            InitializeComponent();
        }

        private void uc_Quanlyloaibenh_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadBenh(dtgvbenh);
            BindingBenh(dtgvbenh);
        }
        void BindingBenh(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgv.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txbidbenh.DataBindings.Clear();
            txbidbenh.DataBindings.Add(bdID);
            Binding bdTen = new Binding("Text", dtgv.DataSource, "Ten", true, DataSourceUpdateMode.OnPropertyChanged);
            txbten.DataBindings.Clear();
            txbten.DataBindings.Add(bdTen);
            Binding bdGia = new Binding("Text", dtgv.DataSource, "Gia", true, DataSourceUpdateMode.OnPropertyChanged);
            txbgia.DataBindings.Clear();
            txbgia.DataBindings.Add(bdGia);
        }

        void LoadBenh(DataGridView dtgv)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                var source = from benh in db.LoaiBenhs
                             select new
                             {
                                 ID = benh.ID,
                                 Ten = benh.Ten,
                                 Gia = benh.Gia
                             };
                dtgv.DataSource = source.ToList();

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbidbenh.Text);
                    string ten = txbten.Text;
                    if (db.LoaiBenhs.Select(m => m.ID).Contains(id))
                    {
                        MessageBox.Show("This ID was in database!");
                        return;
                    }
                    string tendv = txbten.Text;
                    decimal giadv = decimal.Parse(txbgia.Text);

                    LoaiBenh p = new LoaiBenh()
                    {
                        ID = id,
                        Ten = tendv,
                        Gia = giadv
                    };
                    db.LoaiBenhs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Added Successfully!");
                    LoadBenh(dtgvbenh);
                }
                catch { MessageBox.Show("Please fill in information!"); }
            }
            BindingBenh(dtgvbenh);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbidbenh.Text);
                    db.LoaiBenhs.Remove(db.LoaiBenhs.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Removed!");
                    LoadBenh(dtgvbenh);
                }
                catch { }
            }
            BindingBenh(dtgvbenh);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbidbenh.Text);
                    LoaiBenh dv = db.LoaiBenhs.Find(id);
                    string tendv = txbten.Text;
                    decimal giadv = decimal.Parse(txbgia.Text);
                    dv.ID = id;
                    dv.Ten = tendv;
                    dv.Gia = giadv;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadBenh(dtgvbenh);
                }
                catch { }
            }
            BindingBenh(dtgvbenh);
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT ID as ID,Ten as Ten,Gia as Gia FROM dbo.LoaiBenh WHERE Ten LIKE N'%" + txbtimkiem.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvbenh.DataSource = dt;
            dtgvbenh.Refresh();
            BindingBenh(dtgvbenh);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbidbenh.Text);
                    string ten = txbten.Text;
                    if (db.LoaiBenhs.Select(m => m.ID).Contains(id))
                    {
                        MessageBox.Show("This ID was in database!");
                        return;
                    }
                    string tendv = txbten.Text;
                    decimal giadv = decimal.Parse(txbgia.Text);

                    LoaiBenh p = new LoaiBenh()
                    {
                        ID = id,
                        Ten = tendv,
                        Gia = giadv
                    };
                    db.LoaiBenhs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Added Successfully!");
                    LoadBenh(dtgvbenh);
                }
                catch { MessageBox.Show("Please fill in information!"); }
            }
            BindingBenh(dtgvbenh);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbidbenh.Text);
                    db.LoaiBenhs.Remove(db.LoaiBenhs.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Removed!");
                    LoadBenh(dtgvbenh);
                }
                catch { }
            }
            BindingBenh(dtgvbenh);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    int id = int.Parse(txbidbenh.Text);
                    LoaiBenh dv = db.LoaiBenhs.Find(id);
                    string tendv = txbten.Text;
                    decimal giadv = decimal.Parse(txbgia.Text);
                    dv.ID = id;
                    dv.Ten = tendv;
                    dv.Gia = giadv;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadBenh(dtgvbenh);
                }
                catch { }
            }
            BindingBenh(dtgvbenh);
        }
    }
}
