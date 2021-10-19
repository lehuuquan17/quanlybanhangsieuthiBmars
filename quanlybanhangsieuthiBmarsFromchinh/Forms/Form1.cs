using quanlybanhangsieuthiBmarsFromchinh.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhangsieuthiBmarsFromchinh
{

    public partial class Form1 : Form

    {
        private Form activeForm;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private DialogResult dialogResult;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            thoatfromchinh.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // methods
        private Color SelectThemeColor()
        {
            int index = random.Next(themecolor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(themecolor.ColorList.Count);
            }
            tempIndex = index;
            string color = themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {

                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel1.BackColor = color;
                    panel2.BackColor = themecolor.ChangeColorBrightness(color, -0.3);
                    themecolor.PrimaryColor = color;
                    themecolor.SecondaryColor = themecolor.ChangeColorBrightness(color, -0.3);
                    thoatfromchinh.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.manhinhchinh.Controls.Add(childForm);
            this.manhinhchinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            trangchu.Text = childForm.Text;
        }






        private void Reset()
        {
            DisableButton();
            trangchu.Text = "TRANG CHỦ";
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            thoatfromchinh.Visible = false;
        }




        //private void thoatfromchinh_Click_1(object sender, EventArgs e)
        //{

        //}








        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Formproduct(), sender); //ActivateButton(sender);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.NHANVIEN(), sender); //ActivateButton(sender);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.khachhang(), sender); //ActivateButton(sender);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.NCC(), sender); //ActivateButton(sender);

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.KHO(), sender); //ActivateButton(sender);

        }

        private void thoatfromchinh_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void trangchu_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //new dangnhap().Show();
            //this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                dangnhap fm = new dangnhap();
                fm.Show();

            }
               
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   
}
    
  