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
    public partial class uc_Quanlybangluong : UserControl
    {
        string str = @"data source=.\SQLEXPRESS;initial catalog=QuanLyBenhVien;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        QuanLyBenhVienEntities entities = new QuanLyBenhVienEntities();
        DataGridViewRow row;
        public uc_Quanlybangluong()
        {
            InitializeComponent();
            ShowSalaryTable();
        }

        #region Method
        private void ShowSalaryTable()
        {
            txbCMND.Enabled = false;
            txbName.Enabled = false;
            dgvSalary.DataSource = entities.GetSalaryTableAndName();
        }


        #endregion

        #region Feature
        private void dgvSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = new DataGridViewRow();
                row = dgvSalary.Rows[e.RowIndex];
                txbCMND.Text = row.Cells[0].Value.ToString();
                txbName.Text = row.Cells[1].Value.ToString();
                txbSalary.Text = row.Cells[2].Value.ToString();
                txbRate.Text = row.Cells[3].Value.ToString();
                txbSupportMoney.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCMND.Text.ToString() != "") 
                {
                    double calculateSalary = double.Parse(txbRate.Text.ToString()) * double.Parse(txbSalary.Text.ToString()) + double.Parse(txbSupportMoney.Text.ToString());
                    txbCalculateSalary.Text = calculateSalary.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnEditSalary_Click(object sender, EventArgs e)
        {
            entities.EditLuongNhanVien(txbCMND.Text.ToString(), decimal.Parse(txbSalary.Text), double.Parse(txbRate.Text), decimal.Parse(txbSupportMoney.Text));
            try
            {
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi không thể cập nhật nhân viên.", "Thông báo", MessageBoxButtons.OK);
            }
            ShowSalaryTable();
        }


        #endregion

        private void uc_Quanlybangluong_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            String keyword = txbtimkiem.Text.Trim();
            dgvSalary.DataSource = entities.NhanViens.Where(emp => emp.Ten.Contains(keyword)).ToList();
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchStaff_Click_1(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txbCMND.Text.ToString() != "")
                {
                    double calculateSalary = double.Parse(txbRate.Text.ToString()) * double.Parse(txbSalary.Text.ToString()) + double.Parse(txbSupportMoney.Text.ToString());
                    txbCalculateSalary.Text = calculateSalary.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            entities.EditLuongNhanVien(txbCMND.Text.ToString(), decimal.Parse(txbSalary.Text), double.Parse(txbRate.Text), decimal.Parse(txbSupportMoney.Text));
            try
            {
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi không thể cập nhật nhân viên.", "Thông báo", MessageBoxButtons.OK);
            }
            ShowSalaryTable();
        }
    }
}
