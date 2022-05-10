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
    public partial class uc_Doimatkhau1 : UserControl
    {
        public uc_Doimatkhau1()
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
    }
}
