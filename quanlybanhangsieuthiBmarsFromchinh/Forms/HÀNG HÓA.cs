using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhangsieuthiBmarsFromchinh.Forms
{
    public partial class Formproduct : Form
    {
        public Formproduct()
        {
            InitializeComponent();
            
        }
        //private void FormOrders_Load(object sender, EventArgs e)
        //{
        //    LoadTheme();
        //}
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = themecolor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = themecolor.SecondaryColor;
                }
            }
            lablenhanvien1.ForeColor = themecolor.SecondaryColor;
            thongtin1.ForeColor = themecolor.PrimaryColor;
        }

        private void lablenhanvien1_Click(object sender, EventArgs e)
        {

        }

        private void Formproduct_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
