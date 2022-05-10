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
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "USERNAME")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "USERNAME";
                username.ForeColor = Color.DimGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "PASSWORD")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "PASSWORD";
                password.ForeColor = Color.DimGray;
                password.UseSystemPasswordChar = false;
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            Form f = nextForm(username.Text, password.Text);
            if (f == null)
            {
                return;
            }
            else
            {
                f.FormClosed += F_FormClosed;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
                this.Hide();
                Clear();
            }
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void Clear()
        {
            username.Clear();
            password.Clear();
        }
        Form nextForm(string id,string pass)
        {
            Form f = new Form();
            int roll = (int)Cons.Roll.LeTan;
            using(QuanLyBenhVienEntities db=new QuanLyBenhVienEntities())
            {
                var t = db.Users.Where(p => p.CMND.Equals(id) && p.Pass.Equals(pass));
                User u = t.Count() == 1 ? t.Single() : null;
                if(u!=null)
                {
                    NhanVien nv = db.NhanViens.Where(p => u.CMND.Equals(p.CMND)).Single();
                    roll = (int)nv.ChucVu.Roll;
                    Cons.Cons.loginnhanvien = nv;
                    Cons.Cons.user = u;
                    Cons.Cons.a = roll;
                    Cons.Cons.chucvu = nv.ChucVu.Ten;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                    return null;
                }
            }    
            switch(roll)
            {
                case (int)Cons.Roll.LeTan:
                    {
                        f = new LeTan();
                        break;
                    }
                case (int)Cons.Roll.BacSi:
                    {
                        f = new BacSi();
                        break;
                    }
                case (int)Cons.Roll.QuanLy:
                    {
                        f = new QuanLy();
                        break;
                    }
            }
            return f;
        }

        private void DangNhap_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form f = new TTDangKycs();
            f.Show();
            this.Hide();
        }
    }
}
