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
    public partial class uc_Quanlybenh : UserControl
    {
        string str = @"data source=.\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        public uc_Quanlybenh()
        {
            InitializeComponent();
        }

        private void uc_Quanlybenh_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadTenBenh(cbxbenh);
            LoadBenh(dtgvbenh);
            BindingBenh(dtgvbenh);
        }
        void LoadTenBenh(ComboBox cb)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                cb.DataSource = db.LoaiBenhs.ToList();
                cb.DisplayMember = "Ten";
            }
            cb.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        void BindingBenh(DataGridView dtgv)
        {
            Binding bdCMND = new Binding("Text", dtgv.DataSource, "CMND", true, DataSourceUpdateMode.OnPropertyChanged);
            txbcmnd.DataBindings.Clear();
            txbcmnd.DataBindings.Add(bdCMND);
            Binding bdTen = new Binding("Text", dtgv.DataSource, "Ten", true, DataSourceUpdateMode.OnPropertyChanged);
            txbten.DataBindings.Clear();
            txbten.DataBindings.Add(bdTen);
            Binding bdID = new Binding("Text", dtgv.DataSource, "Benh", true, DataSourceUpdateMode.OnPropertyChanged);
            txbbenh.DataBindings.Clear();
            txbbenh.DataBindings.Add(bdID);
        }
        void LoadBenh(DataGridView dtgv)
        {
            sql = "SELECT CMND as CMND,Ten as Ten,Benh as Benh FROM dbo.BenhNhan";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvbenh.DataSource = dt;
            dtgvbenh.Refresh();
            BindingBenh(dtgvbenh);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
             txbbenh.Text = txbbenh.Text + cbxbenh.Text + " \n";
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string id = txbcmnd.Text;

                    var connectionString = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
                    using (var connection = new SqlConnection(connectionString))
                    {
                        var commandText = "select id from LoaiBenh where Ten =N'" + cbxbenh.Text + "'";
                        var command = new SqlCommand(commandText, connection);
                        connection.Open();
                        var count = (int)command.ExecuteScalar();

                        BenhBenhNhan dt = new BenhBenhNhan()
                        {
                            IDBenhNhan = id,
                            IDBenh = count,
                        };
                        db.BenhBenhNhans.Add(dt);
                    }
                    db.SaveChanges();
                }
                catch { }
            }
            BindingBenh(dtgvbenh);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string id = txbcmnd.Text;
                    BenhNhan bn = db.BenhNhans.Find(id);
                    string Benh = txbbenh.Text;
                    bn.Benh = Benh;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadBenh(dtgvbenh);
                }
                catch { }
            }
            BindingBenh(dtgvbenh);
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            LoadTenBenh(cbxbenh);
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT CMND as CMND,Ten as Ten FROM dbo.BenhNhan WHERE Ten LIKE N'%" + txbtimkiem.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvbenh.DataSource = dt;
            dtgvbenh.Refresh();
            BindingBenh(dtgvbenh);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txbbenh.Text = txbbenh.Text + cbxbenh.Text + " \n";
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string id = txbcmnd.Text;

                    var connectionString = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
                    using (var connection = new SqlConnection(connectionString))
                    {
                        var commandText = "select id from LoaiBenh where Ten =N'" + cbxbenh.Text + "'";
                        var command = new SqlCommand(commandText, connection);
                        connection.Open();
                        var count = (int)command.ExecuteScalar();

                        BenhBenhNhan dt = new BenhBenhNhan()
                        {
                            IDBenhNhan = id,
                            IDBenh = count,
                        };
                        db.BenhBenhNhans.Add(dt);
                    }
                    db.SaveChanges();
                }
                catch { }
            }
            BindingBenh(dtgvbenh);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string id = txbcmnd.Text;
                    BenhNhan bn = db.BenhNhans.Find(id);
                    string Benh = txbbenh.Text;
                    bn.Benh = Benh;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadBenh(dtgvbenh);
                }
                catch { }
            }
            BindingBenh(dtgvbenh);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadTenBenh(cbxbenh);
        }
    }
}
