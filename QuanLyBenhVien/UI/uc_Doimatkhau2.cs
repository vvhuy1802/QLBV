using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.UI
{
    public partial class uc_Doimatkhau2 : UserControl
    {
        public uc_Doimatkhau2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string passold = txtpassold.Text;
                string passnew1 = txtpassnew1.Text;
                string passnew2 = txtpassnew2.Text;
                if (passold != Cons.Cons.user.Pass)
                {
                    MessageBox.Show("Hãy nhập mật khẩu hiện tại hợp lệ rồi thử lại.");
                }
                else
                {
                    if (passnew1 != passnew2)
                        MessageBox.Show("Mật khẩu mới không khớp");
                    using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                    {
                        User user = db.Users.Find(Cons.Cons.user.CMND);
                        user.Pass = passnew1;
                        db.SaveChanges();
                        Cons.Cons.user = user;
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        txtpassold.Text = "";
                        txtpassnew1.Text = "";
                        txtpassnew2.Text = "";
                    }
                }
            }
            catch
            {

            }
        }

        private void txtpassnew2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassnew1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassold_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void uc_Doimatkhau2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string passold = txtpassold.Text;
                string passnew1 = txtpassnew1.Text;
                string passnew2 = txtpassnew2.Text;
                if (passold != Cons.Cons.user.Pass)
                {
                    MessageBox.Show("Hãy nhập mật khẩu hiện tại hợp lệ rồi thử lại.");
                }
                else
                {
                    if (passnew1 != passnew2)
                        MessageBox.Show("Mật khẩu mới không khớp");
                    using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                    {
                        User user = db.Users.Find(Cons.Cons.user.CMND);
                        user.Pass = passnew1;
                        db.SaveChanges();
                        Cons.Cons.user = user;
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        txtpassold.Text = "";
                        txtpassnew1.Text = "";
                        txtpassnew2.Text = "";
                    }
                }
            }
            catch
            {

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string passold = txtpassold.Text;
                string passnew1 = txtpassnew1.Text;
                string passnew2 = txtpassnew2.Text;
                if (passold != Cons.Cons.user.Pass)
                {
                    MessageBox.Show("Hãy nhập mật khẩu hiện tại hợp lệ rồi thử lại.");
                }
                else
                {
                    if (passnew1 != passnew2)
                        MessageBox.Show("Mật khẩu mới không khớp");
                    using (QuanLyBenhVienEntities db = new QuanLyBenhVienEntities())
                    {
                        User user = db.Users.Find(Cons.Cons.user.CMND);
                        user.Pass = passnew1;
                        db.SaveChanges();
                        Cons.Cons.user = user;
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        txtpassold.Text = "";
                        txtpassnew1.Text = "";
                        txtpassnew2.Text = "";
                    }
                }
            }
            catch
            {

            }
        }
    }
}
