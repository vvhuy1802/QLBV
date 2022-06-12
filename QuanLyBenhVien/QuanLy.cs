using DevExpress.XtraBars;
using QuanLyBenhVien.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBenhVien
{

    public partial class QuanLy : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        uc_Quanlynhanvien ucQuanlynhanvien;
        uc_Quanlybangluong  ucQuanlybangluong;
        uc_Quanlyloaibenh ucQuanlyloaibenh;
        uc_Quanlyloaithuoc ucQuanlyloaithuoc;
        uc_Thongtincanhan2 ucThongtincanhan2;
        uc_Benhvien ucBlank;
        uc_Doimatkhau2 ucDoimatkhau2;
        public QuanLy()
        {
            InitializeComponent();
        }

        private void mnQuanlyhethong_Click(object sender, EventArgs e)
        {

        }

        private void mnQuanlynhansu_Click(object sender, EventArgs e)
        {

        }

        private void mnQuanlynhanvien_Click(object sender, EventArgs e)
        {
            if (ucQuanlynhanvien == null)
            {
                ucQuanlynhanvien = new uc_Quanlynhanvien();
                ucQuanlynhanvien.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucQuanlynhanvien);
                ucQuanlynhanvien.BringToFront();
            }
            else
            {
                ucQuanlynhanvien.BringToFront();
            }
            lbltieude2.Caption = mnQuanlynhanvien.Text;
        }

        private void mnQuanlybangluong_Click(object sender, EventArgs e)
        {
            if (ucQuanlybangluong == null)
            {
                ucQuanlybangluong = new uc_Quanlybangluong();
                ucQuanlybangluong.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucQuanlybangluong);
                ucQuanlybangluong.BringToFront();
            }
            else
            {
                ucQuanlybangluong.BringToFront();
            }
            lbltieude2.Caption = mnQuanlybangluong.Text;
        }

        private void mnQuanlyloaibenh_Click(object sender, EventArgs e)
        {
            if (ucQuanlyloaibenh == null)
            {
                ucQuanlyloaibenh = new uc_Quanlyloaibenh();
                ucQuanlyloaibenh.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucQuanlyloaibenh);
                ucQuanlyloaibenh.BringToFront();
            }
            else
            {
                ucQuanlyloaibenh.BringToFront();
            }
            lbltieude2.Caption = ucQuanlyloaibenh.Text;
        }

        private void mnQuanlyloaithuoc_Click(object sender, EventArgs e)
        {
            if (ucQuanlyloaithuoc == null)
            {
                ucQuanlyloaithuoc = new uc_Quanlyloaithuoc();
                ucQuanlyloaithuoc.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucQuanlyloaithuoc);
                ucQuanlyloaithuoc.BringToFront();
            }
            else
            {
                ucQuanlyloaithuoc.BringToFront();
            }
            lbltieude2.Caption = ucQuanlyloaithuoc.Text;
        }

        private void mnQuanlythongke_Click(object sender, EventArgs e)
        {
        }

        private void mnTennhanvien_Click(object sender, EventArgs e)
        {
            ucBlank = new uc_Benhvien();
            ucBlank.Dock = DockStyle.Fill;
            mainContainer2.Controls.Add(ucBlank);
            ucBlank.BringToFront();
            if (ucThongtincanhan2 == null)
            {
                ucThongtincanhan2 = new uc_Thongtincanhan2();
                ucThongtincanhan2.Location = new Point(
                mainContainer2.ClientSize.Width / 2 - ucThongtincanhan2.Size.Width / 2,
                  mainContainer2.ClientSize.Height / 2 - ucThongtincanhan2.Size.Height / 2);
                ucThongtincanhan2.Anchor = AnchorStyles.None;
                mainContainer2.Controls.Add(ucThongtincanhan2);
                ucThongtincanhan2.BringToFront();
            }
            else
            {
                ucThongtincanhan2.BringToFront();
            }
            lbltieude2.Caption = "Thông tin cá nhân";
        }

        private void mnDoimatkhau_Click(object sender, EventArgs e)
        {
            if (ucDoimatkhau2 == null)
            {
                ucDoimatkhau2 = new uc_Doimatkhau2();
                ucDoimatkhau2.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucDoimatkhau2);
                ucDoimatkhau2.BringToFront();
            }
            else
            {
                ucDoimatkhau2.BringToFront();
            }
            lbltieude2.Caption = mnDoimatkhau.Text;
        }

        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            Cons.Cons.loginnhanvien = null;
            this.Close();
            mnTennhanvien.Text = "";
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            mnTennhanvien.Text = Cons.Cons.loginnhanvien.Ten;
            if (ucBlank == null)
            {
                ucBlank = new uc_Benhvien();
                ucBlank.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucBlank);
                ucBlank.BringToFront();
            }
            else
                ucBlank.BringToFront();
        }

        private void mnQuanlyloaibenh_Click_1(object sender, EventArgs e)
        {
            if (ucQuanlyloaibenh == null)
            {
                ucQuanlyloaibenh = new uc_Quanlyloaibenh();
                ucQuanlyloaibenh.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucQuanlyloaibenh);
                ucQuanlyloaibenh.BringToFront();
            }
            else
            {
                ucQuanlyloaibenh.BringToFront();
            }
            lbltieude2.Caption = ucQuanlyloaibenh.Text;
        }

        private void mnQuanlyloaibenh_Click_2(object sender, EventArgs e)
        {
            if (ucQuanlyloaibenh == null)
            {
                ucQuanlyloaibenh = new uc_Quanlyloaibenh();
                ucQuanlyloaibenh.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucQuanlyloaibenh);
                ucQuanlyloaibenh.BringToFront();
            }
            else
            {
                ucQuanlyloaibenh.BringToFront();
            }
            lbltieude2.Caption = mnQuanlyloaibenh.Text;
        }

        private void mnQuanlyloaithuoc_Click_1(object sender, EventArgs e)
        {
            if (ucQuanlyloaithuoc == null)
            {
                ucQuanlyloaithuoc = new uc_Quanlyloaithuoc();
                ucQuanlyloaithuoc.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucQuanlyloaithuoc);
                ucQuanlyloaithuoc.BringToFront();
            }
            else
            {
                ucQuanlyloaithuoc.BringToFront();
            }
            lbltieude2.Caption = mnQuanlyloaithuoc.Text;
        }

        private void mnQuanlyletan_Click(object sender, EventArgs e)
        {
            this.Close();
            LeTan f = new LeTan();
            f.Show();
        }

        private void mnQuanlybacsi_Click(object sender, EventArgs e)
        {
            this.Close();
            BacSi f = new BacSi();
            f.Show();
        }
    }
}
