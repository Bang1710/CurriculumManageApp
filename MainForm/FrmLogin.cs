using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class FrmLogin : Form
    {
        AccountsBLL accountsBLL;
        public FrmLogin()
        {
            InitializeComponent();
            accountsBLL = new AccountsBLL();
        }

        public bool checkAccount(string tendangnhap, string pass)
        {

            //MessageBox.Show(list.ToString());
            //string stringpass = pass.ToString();

            if (string.IsNullOrEmpty(tendangnhap))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống, hãy nhập giá trị tên đăng nhập !");
                return false;
            }

            if (!(tendangnhap.Length - 1  >=10 && tendangnhap.Length -1 <= 20))
            {
                MessageBox.Show("Tên đăng nhập tối thiểu 10 ký tự và tối đa 20 ký tự, hãy nhập lại giá trị tên đăng nhập !");
                return false;
            }
            if (pass.ToString() == "")
            {
                MessageBox.Show("Password không được bỏ trống, hãy nhập lại giá trị password !");
                return false;
            }

            if (!(pass.Length - 1 >= 7 && pass.Length <= 20))
            {
                MessageBox.Show("Password tối thiểu 8 ký tự và tối đa 20 ký tự, hãy nhập lại giá trị password !");
                return false;
            }

            var query = from ac in accountsBLL.getListAccounts()
                        where ac.UserName == tendangnhap && ac.Password == pass
                        select ac;
            var list = accountsBLL.getListAccounts().Select(a => new {a.UserName, a.Password}).Where(a => a.UserName == tendangnhap && a.Password == pass).ToList();

            //MessageBox.Show(query.ToList().Count.ToString());
            //MessageBox.Show(acExist.ToString());
            if (list.Count < 1)
            {
                MessageBox.Show("Hãy xem lại thông tin tên đăng nhập và mật khẩu !");
                return false;
            }

            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var tendn = txtTenDangNhap.Text.ToString().Trim();
            var mk = txtMatKhau.Text.ToString().Trim();
            if (checkAccount(tendn, mk))
            {
                this.Hide();
                FrmMenu mainForm = new FrmMenu();
                mainForm.tendn = tendn;
                mainForm.ps = mk;
                mainForm.ShowDialog();
                this.Show();
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
            } 
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
