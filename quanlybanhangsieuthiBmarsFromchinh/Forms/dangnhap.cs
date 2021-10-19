 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhangsieuthiBmarsFromchinh.Forms
{
    public partial class dangnhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O721KR8;Initial Catalog=thongtintaikhoan;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        private bool showonnextst;
        private bool showinnextst;

        public dangnhap()
        {
            InitializeComponent();

        }

        private void buttondangky_Click(object sender, EventArgs e)
        {
            con.Open();
           
            string login = "select [thongtintaikhoan].[Tên đăng nhập] , [Mật khẩu] from [thongtintaikhoan] Where [Tên đăng nhập]  = '" + textBoxtendangnhap.Text + "'and [Mật khẩu]= '" + textBoxmatkhau.Text + "'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                //The Form which will appear after loggin in
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid [Tên đăng nhập] or [Mật khẩu], Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxtendangnhap.Text = "";
                textBoxmatkhau.Text = "";
                textBoxtendangnhap.Focus();
            }
            con.Close();
        }
        

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            textBoxtendangnhap.Text = "";
            textBoxmatkhau.Text = "";
            textBoxtendangnhap.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new dangnhapdangky().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkbookxemmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            //BinaryReader binrd = new BinaryReader(new FileStream(Application.StartupPath + @"\config.dat", FileMode.Open));
            //textBoxtendangnhap = binrd.ReadString();
            //textBoxmatkhau = binrd.ReadString();
            //showonnextst = binrd.ReadBoolean();
            //if (showinnextst)
            //{
            //    chkremember.Checked = true;
            //    txttaikhoan.Text = taikhoan;
            //    tatmatkhau.Text = pass;
            //}
        }
        }
    }


