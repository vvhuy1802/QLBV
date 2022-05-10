using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.UI
{
    public partial class uc_Quanlynhanvien : UserControl
    {
        string fileName;
        QuanLyBenhVienEntities entities1 = new QuanLyBenhVienEntities();
        DataGridViewRow row;

        public uc_Quanlynhanvien()
        {
            InitializeComponent();
        }



        #region Method

        private void uc_Quanlynhanvien_Load(object sender, EventArgs e)

        {
            cbStaffRank.Enabled = false;
            nupStaffLevel.Enabled = false;
            btnStaffCancel.Enabled = false;
            btnSave.Visible = false;
            ShowStaffTable(dgvStaffList);
        }
        private void ShowStaffTable(DataGridView dgvStaffTable)
        {
            dgvStaffList.DataSource = entities1.GetStaffNSalaryAndTable();
        }
        Image ConvertBinaryToImage(byte[] data)
        {

                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }

        }

        byte[] ConvertImageToBinary(Image img)
        {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
        }


        private void lockButton()
        {
            txbStaffCMND.ReadOnly = false;
            btnStaffEdit.Enabled = false;
            btnStaffDelete.Enabled = false;
        }

        private void unlockButton()
        {
            txbStaffCMND.ReadOnly = true;
            btnStaffEdit.Enabled = true;
            btnStaffDelete.Enabled = true;
        }

        private void cbStaffPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStaffPosition.SelectedIndex == 1)
            {
          //      cbStaffRank.Text = row.Cells[10].Value.ToString();
            //    nupStaffLevel.Value = (int)row.Cells[11].Value;
                cbStaffRank.Enabled = true;
                nupStaffLevel.Enabled = true;
            }
            else
            {
                cbStaffRank.Text = "";
                nupStaffLevel.Value = 0;
                cbStaffRank.Enabled = false;
                nupStaffLevel.Enabled = false;
            }
        }

        #endregion

        #region Feature
        private void dgvStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = new DataGridViewRow();
                row = dgvStaffList.Rows[e.RowIndex];
                txbStaffCMND.Text = row.Cells[0].Value.ToString();
                txbStaffName.Text = row.Cells[1].Value.ToString();
               // pbStaffImage.Image = ConvertBinaryToImage((byte[])row.Cells[2].Value);
                dtpStaffBirth.Text = row.Cells[3].Value.ToString();
                cbStaffSex.Text = row.Cells[4].Value.ToString();
                nudStaffExp.Text = row.Cells[5].Value.ToString();
                txbStaffLocate.Text = row.Cells[6].Value.ToString();
                txbStaffCountry.Text = row.Cells[7].Value.ToString();
                txbStaffNum.Text = row.Cells[8].Value.ToString();
                cbStaffPosition.SelectedIndex = (int)row.Cells[9].Value - 1;
                if (cbStaffPosition.SelectedIndex == 1)
                {
                    cbStaffRank.Enabled = true;
                    nupStaffLevel.ReadOnly = false;
                    cbStaffRank.Text = row.Cells[10].Value.ToString();
                    nupStaffLevel.Value = (int)row.Cells[11].Value;
                }
                txbStaffSalary.Text = row.Cells[12].Value.ToString();
                txbStaffRate.Text = row.Cells[13].Value.ToString();
                txbStaffSupportMoney.Text = row.Cells[14].Value.ToString();
            }
            catch
            {

            }
        }

        private void pbStaffImage_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPED|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    pbStaffImage.Image = Image.FromFile(fileName);
                }            
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnAddStaff.Visible = false;
            btnStaffCancel.Enabled = true;
            lockButton();
        }

        private void btnStaffCancel_Click(object sender, EventArgs e)
        {
            txbStaffCMND.Enabled = false;
            btnStaffEdit.Enabled = true;
            btnStaffDelete.Enabled = true;
            btnSave.Visible = false;
            btnAddStaff.Visible = true;
            btnStaffCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int idChucVu = cbStaffPosition.SelectedIndex + 1;
            btnSave.Visible = false;
            btnAddStaff.Visible = true;
            btnStaffCancel.Enabled = false;
            entities1.AddNhanVien(txbStaffCMND.Text.ToString(), txbStaffName.Text.ToString(),  dtpStaffBirth.Value, cbStaffSex.Text, int.Parse(nudStaffExp.Value.ToString()), txbStaffLocate.Text.ToString(), txbStaffCountry.Text.ToString(), txbStaffNum.Text.ToString(), idChucVu , cbStaffRank.Text, int.Parse(nupStaffLevel.Value.ToString()));

            entities1.AddLuongNhanVien(txbStaffCMND.Text.ToString(), decimal.Parse(txbStaffSalary.Text), double.Parse(txbStaffRate.Text), decimal.Parse(txbStaffSupportMoney.Text));
            try
            {
                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK);
                ShowStaffTable(dgvStaffList);

            }
            catch
            {
                MessageBox.Show("Thêm nhân viên mới không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            unlockButton();
        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {
            if (txbStaffCMND.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn thay đổi!", "Thông báo", MessageBoxButtons.OK);
            }

            int idChucVu = cbStaffPosition.SelectedIndex + 1;
            if (idChucVu == 2)
            {
                entities1.EditNhanVien(txbStaffCMND.Text.ToString(), txbStaffName.Text.ToString(), dtpStaffBirth.Value, cbStaffSex.Text, int.Parse(nudStaffExp.Value.ToString()), txbStaffLocate.Text.ToString(), txbStaffCountry.Text.ToString(), txbStaffNum.Text.ToString(), idChucVu, cbStaffRank.Text, int.Parse(nupStaffLevel.Value.ToString()));
            }
            else
            {
                entities1.EditNhanVien(txbStaffCMND.Text.ToString(), txbStaffName.Text.ToString(), dtpStaffBirth.Value, cbStaffSex.Text, int.Parse(nudStaffExp.Value.ToString()), txbStaffLocate.Text.ToString(), txbStaffCountry.Text.ToString(), txbStaffNum.Text.ToString(), idChucVu, "", 0);
            }

            entities1.EditLuongNhanVien(txbStaffCMND.Text.ToString(), decimal.Parse(txbStaffSalary.Text), double.Parse(txbStaffRate.Text), decimal.Parse(txbStaffSupportMoney.Text));
            try
            {       
                MessageBox.Show("Đã cập nhật thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK);
                
            }
            catch
            {
                MessageBox.Show("Lỗi không thể cập nhật nhân viên.", "Thông báo", MessageBoxButtons.OK);
            }
            ShowStaffTable(dgvStaffList);
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            entities1.DeleteLuongNhanVien(txbStaffCMND.Text.ToString());
            entities1.DeleteNhanVien(txbStaffCMND.Text.ToString());
            try
            {
                MessageBox.Show("Xoá nhân viên thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa nhân viên!!!", "Thông báo", MessageBoxButtons.OK);
            }
            ShowStaffTable(dgvStaffList);
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            String keyword = txbtimkiem.Text.Trim();
            dgvStaffList.DataSource = entities1.NhanViens.Where(emp => emp.Ten.Contains(keyword)).ToList();
        }


        #endregion

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbStaffSupportMoney_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
