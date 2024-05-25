using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class frmDangNhap : Form
    {
        Connect conn = new Connect();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            btnDangNhap.Focus();
            txtTenTaiKhoan_Leave(sender,e);
            txtMatKhau_Leave(sender,e);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {    
            conn.OpenConnection();
            if (conn.Login(txtTenTaiKhoan.Text, txtMatKhau.Text))
            {
                Home f = new Home();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                txtTenTaiKhoan.Focus();
            }
                
            conn.CloseConnection();
        }

        private void txtTenTaiKhoan_Enter(object sender, EventArgs e)
        {
            txtTenTaiKhoan.ForeColor = Color.Black;
            if (txtTenTaiKhoan.Text == "Nhập tên đăng nhập")
                txtTenTaiKhoan.Text = "";
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            txtMatKhau.ForeColor = Color.Black;
            if (txtMatKhau.Text == "Nhập mật khẩu")
                txtMatKhau.Text = "";
            txtMatKhau.PasswordChar = '*';
        }
        private void txtTenTaiKhoan_Leave(object sender, EventArgs e)
        {        
            if (txtTenTaiKhoan.Text == "")
            {
                txtTenTaiKhoan.ForeColor = Color.FromArgb(125, 137, 149);
                txtTenTaiKhoan.Text = "Nhập tên đăng nhập";
            }                        
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            
            txtMatKhau.PasswordChar = default;
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.ForeColor = Color.FromArgb(125, 137, 149);
                txtMatKhau.Text = "Nhập mật khẩu";
            }
            else
            {
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.PasswordChar = '*';
            }            
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
