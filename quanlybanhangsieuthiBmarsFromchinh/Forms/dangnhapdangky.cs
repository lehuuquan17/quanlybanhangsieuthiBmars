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

namespace quanlybanhangsieuthiBmarsFromchinh.Forms
{
    public partial class dangnhapdangky : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O721KR8;Initial Catalog=thongtintaikhoan;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public dangnhapdangky()
        {
            InitializeComponent();
        }

        private void buttondangky_Click(object sender, EventArgs e)
        {
            if(textBoxtendangnhap.Text == "" && textBoxmatkhau.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Tên đăng nhập and Mật khẩu Fileds are ampty ", " ĐĂNG KÝ Failed", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else if (textBoxmatkhau.Text ==  textBox1.Text )
            {
                con.Open();
                string register = "INSERT INTO thongtintaikhoan VALUES ('" + textBoxtendangnhap.Text + "','" + textBoxmatkhau.Text + "')";
                cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();


                textBoxtendangnhap.Text = "";
                textBoxmatkhau.Text = "";
                textBox1.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxtendangnhap.Text = "";
                textBoxmatkhau.Text = "";
                textBox1.Focus();
            }
        }

        private void checkbookxemmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbookxemmatkhau.Checked)
            {
                textBoxmatkhau.PasswordChar = '\0';
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBoxmatkhau.PasswordChar = '•';
                textBox1.PasswordChar = '•';
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            textBoxtendangnhap.Text = "";
            textBoxmatkhau.Text = "";
            textBox1.Text = "";
            textBoxtendangnhap.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new dangnhap().Show();
            this.Hide();
        }

        private void dangnhapdangky_Load(object sender, EventArgs e)
        {

        }

        private void textBoxmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }

        //private void buttondangky_Click(object sender, EventArgs e)
        //{
        //    if("[Tên đăng nhập] and [Mật khẩu] fields are amty" , " Đăng ký Failed" , MeesageBoxButtons.OK)
        //}
    }

