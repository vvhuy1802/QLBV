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
    public partial class uc_ThanhToan : UserControl
    {
        string str = @"data source=.\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        long tong = 0;
        long tienkham = 0;
        long tienthuoc = 0;

        public uc_ThanhToan()
        {
            InitializeComponent();
        }
        private void uc_ThanhToan_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            AutoComplete();
        }
        private void AutoComplete()
        {
            sql = "Select CMND from BenhNhan";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            txbTimBN.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                var rw = r.Field<string>("CMND");
                txbTimBN.AutoCompleteMode = AutoCompleteMode.Suggest;
                txbTimBN.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbTimBN.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select Ten,NgaySinh,GioiTinh,DiaChi,SDT,QuocTich,BaoHiem,NhapVien from BenhNhan  where CMND = '" + txbTimBN.Text.Trim() + "' ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txbTen.Text = dt.Rows[0]["Ten"].ToString().Trim();
                    cbxGioitinh.Text = dt.Rows[0]["GioiTinh"].ToString().Trim();
                    txbDiaChi.Text = dt.Rows[0]["DiaChi"].ToString().Trim();
                    txbSDT.Text = dt.Rows[0]["SDT"].ToString().Trim();
                    txbQuoctich.Text = dt.Rows[0]["QuocTich"].ToString().Trim();
                    cbxBaohiem.Text = dt.Rows[0]["BaoHiem"].ToString().Trim();
                }
                //Gia kham benh
                string sql1 = @"select sum(LoaiBenh.Gia) as GiaKhamBenh from LoaiBenh,BenhNhan,BenhBenhNhan where LoaiBenh.ID=BenhBenhNhan.IDBenh and BenhBenhNhan.IDBenhNhan = BenhNhan.CMND and CMND=
            '" + txbTimBN.Text.Trim() + "' ";
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                string[] a = new string[1];
                if (dt1.Rows.Count > 0)
                {
                    a = dt1.Rows[0][0].ToString().Split('.');
                    txbCPKhamBenh.Text = a[0];
                    tienkham = long.Parse(a[0]);
                }
                //Gia Don Thuoc
                string sql2 = @"select Sum(LoaiThuoc.Gia*DonThuoc.SoLuong) as GiaThuoc from LoaiThuoc,DonThuoc where LoaiThuoc.id=DonThuoc.idthuoc and DonThuoc.idbenhnhan= '" + txbTimBN.Text.Trim() + "' ";
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                string[] a1 = new string[1];
                if (dt2.Rows.Count > 0)
                {
                    a1 = dt2.Rows[0][0].ToString().Split('.');
                    txbCPDonThuoc.Text = a1[0];
                    tienthuoc = long.Parse(a1[0]);
                }
                tong = int.Parse(a[0]) + int.Parse(a1[0]);
                txbtong.Text = tong.ToString();
                txbKhachDua.Text = tong.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Thanh Toán!");
            }

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                txbTienThua.Text = ((tong - int.Parse(txbKhachDua.Text)) * (-1)).ToString();
                using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                {
                    string id = txbTimBN.Text;
                    decimal tk = (decimal)tienkham;
                    decimal tt = (decimal)tienthuoc;
                    DateTime dt = DateTime.Now;
                    dt.ToString("dd-MM-yyyy");
                    HoaDon hd = new HoaDon()
                    {
                        CMNDBN = id,
                        TienKham = tk,
                        TienThuoc = tt,
                        XuatVien = dt
                    };
                    db.HoaDons.Add(hd);
                    db.SaveChanges();
                }
                var connectionString = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
                //Xoa Benh
                using (var connection = new SqlConnection(connectionString))
                {
                    while (true)
                    {
                        var commandText = "select id from BenhBenhNhan where IDBenhNhan ='" + txbTimBN.Text + "'";
                        var command = new SqlCommand(commandText, connection);
                        connection.Open();
                        if (command.ExecuteScalar() == null)
                        {
                            break;
                        }
                        else
                        {
                            var count = (int)command.ExecuteScalar();
                            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                            {
                                db.BenhBenhNhans.Remove(db.BenhBenhNhans.Find(count));
                                db.SaveChanges();
                            }
                        }
                        connection.Close();
                    }
                }
                //Xoa Don Thuoc
                using (var connection = new SqlConnection(connectionString))
                {
                    while (true)
                    {
                        var commandText = "select id from DonThuoc where IDBenhNhan ='" + txbTimBN.Text + "'";
                        var command = new SqlCommand(commandText, connection);
                        connection.Open();
                        if (command.ExecuteScalar() == null)
                        {
                            break;
                        }
                        else
                        {
                            var count = (int)command.ExecuteScalar();
                            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                            {
                                db.DonThuocs.Remove(db.DonThuocs.Find(count));
                                db.SaveChanges();
                            }
                        }
                        connection.Close();
                    }
                }
                using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                {
                    try
                    {
                        string cmnd = txbTimBN.Text;
                        db.BenhNhans.Remove(db.BenhNhans.Find(cmnd));
                        db.SaveChanges();
                    }
                    catch { MessageBox.Show("Error: " + e); }
                }
                Reset();
                MessageBox.Show("Thanh Toán Thành Công!");

            }
            catch (Exception)
            {
                MessageBox.Show("Thanh Toán Không Thành Công!");
            }
        }
        private void Reset()
        {
            txbTimBN.Text = "";
            txbTen.Text = "";
            cbxGioitinh.Text = "";
            txbDiaChi.Text = "";
            txbQuoctich.Text = "";
            txbSDT.Text = "";
            cbxBaohiem.Text = "";
            txbCPDonThuoc.Text = "0";
            txbCPKhamBenh.Text = "0";
            txbTienThua.Text = "0";
            txbtong.Text = "0";
            txbKhachDua.Text = "0";
        }

        private void txbKhachDua_TextChanged(object sender, EventArgs e)
        {
            txbTienThua.Text = (- int.Parse(txbtong.Text) + int.Parse(txbKhachDua.Text)).ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string sql = @"select Ten,NgaySinh,GioiTinh,DiaChi,SDT,QuocTich,BaoHiem,NhapVien from BenhNhan  where CMND = '" + txbTimBN.Text.Trim() + "' ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txbTen.Text = dt.Rows[0]["Ten"].ToString().Trim();
                    cbxGioitinh.Text = dt.Rows[0]["GioiTinh"].ToString().Trim();
                    txbDiaChi.Text = dt.Rows[0]["DiaChi"].ToString().Trim();
                    txbSDT.Text = dt.Rows[0]["SDT"].ToString().Trim();
                    txbQuoctich.Text = dt.Rows[0]["QuocTich"].ToString().Trim();
                    cbxBaohiem.Text = dt.Rows[0]["BaoHiem"].ToString().Trim();
                }
                //Gia kham benh
                string sql1 = @"select sum(LoaiBenh.Gia) as GiaKhamBenh from LoaiBenh,BenhNhan,BenhBenhNhan where LoaiBenh.ID=BenhBenhNhan.IDBenh and BenhBenhNhan.IDBenhNhan = BenhNhan.CMND and CMND=
            '" + txbTimBN.Text.Trim() + "' ";
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                string[] a = new string[1];
                if (dt1.Rows.Count > 0)
                {
                    a = dt1.Rows[0][0].ToString().Split('.');
                    txbCPKhamBenh.Text = a[0];
                    tienkham = long.Parse(a[0]);
                }
                //Gia Don Thuoc
                string sql2 = @"select Sum(LoaiThuoc.Gia*DonThuoc.SoLuong) as GiaThuoc from LoaiThuoc,DonThuoc where LoaiThuoc.id=DonThuoc.idthuoc and DonThuoc.idbenhnhan= '" + txbTimBN.Text.Trim() + "' ";
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                string[] a1 = new string[1];
                if (dt2.Rows.Count > 0)
                {
                    a1 = dt2.Rows[0][0].ToString().Split('.');
                    txbCPDonThuoc.Text = a1[0];
                    tienthuoc = long.Parse(a1[0]);
                }
                tong = int.Parse(a[0]) + int.Parse(a1[0]);
                txbtong.Text = tong.ToString();
                txbKhachDua.Text = tong.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Thanh Toán!");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                txbTienThua.Text = ((tong - int.Parse(txbKhachDua.Text)) * (-1)).ToString();
                using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                {
                    string id = txbTimBN.Text;
                    decimal tk = (decimal)tienkham;
                    decimal tt = (decimal)tienthuoc;
                    DateTime dt = DateTime.Now;
                    dt.ToString("dd-MM-yyyy");
                    HoaDon hd = new HoaDon()
                    {
                        CMNDBN = id,
                        TienKham = tk,
                        TienThuoc = tt,
                        XuatVien = dt
                    };
                    db.HoaDons.Add(hd);
                    db.SaveChanges();
                }
                var connectionString = @"data source=HUY\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
                //Xoa Benh
                using (var connection = new SqlConnection(connectionString))
                {
                    while (true)
                    {
                        var commandText = "select id from BenhBenhNhan where IDBenhNhan ='" + txbTimBN.Text + "'";
                        var command = new SqlCommand(commandText, connection);
                        connection.Open();
                        if (command.ExecuteScalar() == null)
                        {
                            break;
                        }
                        else
                        {
                            var count = (int)command.ExecuteScalar();
                            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                            {
                                db.BenhBenhNhans.Remove(db.BenhBenhNhans.Find(count));
                                db.SaveChanges();
                            }
                        }
                        connection.Close();
                    }
                }
                //Xoa Don Thuoc
                using (var connection = new SqlConnection(connectionString))
                {
                    while (true)
                    {
                        var commandText = "select id from DonThuoc where IDBenhNhan ='" + txbTimBN.Text + "'";
                        var command = new SqlCommand(commandText, connection);
                        connection.Open();
                        if (command.ExecuteScalar() == null)
                        {
                            break;
                        }
                        else
                        {
                            var count = (int)command.ExecuteScalar();
                            using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                            {
                                db.DonThuocs.Remove(db.DonThuocs.Find(count));
                                db.SaveChanges();
                            }
                        }
                        connection.Close();
                    }
                }
                using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                {
                    try
                    {
                        string cmnd = txbTimBN.Text;
                        db.BenhNhans.Remove(db.BenhNhans.Find(cmnd));
                        db.SaveChanges();
                    }
                    catch { MessageBox.Show("Error: " + e); }
                }
                Reset();
                MessageBox.Show("Thanh Toán Thành Công!");

            }
            catch (Exception)
            {
                MessageBox.Show("Thanh Toán Không Thành Công!");
            }
        }
    }
}
