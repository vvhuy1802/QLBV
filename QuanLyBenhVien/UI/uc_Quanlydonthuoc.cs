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
    public partial class uc_Quanlydonthuoc : UserControl
    {
        string str = @"data source=.\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        public uc_Quanlydonthuoc()
        {
            InitializeComponent();
        }

        private void uc_Quanlydonthuoc_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadTenBenhNhan(cbxthuoc);
            LoadBenh(dtgvbenhnhan);
            BindingBenh(dtgvbenhnhan);
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
            Binding bdThuoc = new Binding("Text", dtgv.DataSource, "Thuoc", true, DataSourceUpdateMode.OnPropertyChanged);
            txbdonthuoc.DataBindings.Clear();
            txbdonthuoc.DataBindings.Add(bdThuoc);
        }
        void LoadBenh(DataGridView dtgv)
        {
            sql = "SELECT CMND as CMND,Ten as Ten,Benh as Benh,Thuoc as Thuoc FROM dbo.BenhNhan";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvbenhnhan.DataSource = dt;
            dtgvbenhnhan.Refresh();
            BindingBenh(dtgvbenhnhan);
        }
        void LoadTenBenhNhan(ComboBox cb)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                cb.DataSource = db.LoaiThuocs.ToList();
                cb.DisplayMember = "Ten";
                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txbsoluong.Text == "")
            {

            }
            else
            {
                txbdonthuoc.Text = txbdonthuoc.Text + cbxthuoc.Text + " x " + txbsoluong.Text + " \n";
                using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                {
                    try
                    {
                        string id = txbcmnd.Text;
                        string Thuoc = txbdonthuoc.Text;
                        int soluong = int.Parse(txbsoluong.Text);
                        BenhNhan bn = db.BenhNhans.Find(id);
                        bn.Thuoc = Thuoc;

                        var connectionString = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
                        using (var connection = new SqlConnection(connectionString))
                        {
                            var commandText = "select id from LoaiThuoc where Ten ='" + cbxthuoc.Text + "'";
                            var command = new SqlCommand(commandText, connection);
                            connection.Open();
                            var count = (int)command.ExecuteScalar();

                            DonThuoc dt = new DonThuoc()
                            {
                                IDBenhNhan = id,
                                IDThuoc = count,
                                SoLuong = soluong
                            };
                            db.DonThuocs.Add(dt);
                        }
                        db.SaveChanges();
                    }
                    catch { }
                }
                BindingBenh(dtgvbenhnhan);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string id = txbcmnd.Text;
                    BenhNhan bn = db.BenhNhans.Find(id);
                    string Thuoc = txbdonthuoc.Text;
                    bn.Thuoc = Thuoc;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadBenh(dtgvbenhnhan);
                }
                catch { }
            }
            BindingBenh(dtgvbenhnhan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadBenh(dtgvbenhnhan);
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT CMND as CMND,Ten as Ten,Benh as Benh,Thuoc as Thuoc FROM dbo.BenhNhan WHERE CMND LIKE N'%" + txbtimkiem.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvbenhnhan.DataSource = dt;
            dtgvbenhnhan.Refresh();
            BindingBenh(dtgvbenhnhan);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbsoluong.Text == "")
            {

            }
            else
            {
                txbdonthuoc.Text = txbdonthuoc.Text + cbxthuoc.Text + " x " + txbsoluong.Text + " \n";
                using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                {
                    try
                    {
                        string id = txbcmnd.Text;
                        string Thuoc = txbdonthuoc.Text;
                        int soluong = int.Parse(txbsoluong.Text);
                        BenhNhan bn = db.BenhNhans.Find(id);
                        bn.Thuoc = Thuoc;

                        var connectionString = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
                        using (var connection = new SqlConnection(connectionString))
                        {
                            var commandText = "select id from LoaiThuoc where Ten ='" + cbxthuoc.Text + "'";
                            var command = new SqlCommand(commandText, connection);
                            connection.Open();
                            var count = (int)command.ExecuteScalar();

                            DonThuoc dt = new DonThuoc()
                            {
                                IDBenhNhan = id,
                                IDThuoc = count,
                                SoLuong = soluong
                            };
                            db.DonThuocs.Add(dt);
                        }
                        db.SaveChanges();
                    }
                    catch { }
                }
                BindingBenh(dtgvbenhnhan);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
            {
                try
                {
                    string id = txbcmnd.Text;
                    BenhNhan bn = db.BenhNhans.Find(id);
                    string Thuoc = txbdonthuoc.Text;
                    bn.Thuoc = Thuoc;
                    db.SaveChanges();
                    MessageBox.Show("Chanaged!");
                    LoadBenh(dtgvbenhnhan);
                }
                catch { }
            }
            BindingBenh(dtgvbenhnhan);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadBenh(dtgvbenhnhan);
        }
    }
}
