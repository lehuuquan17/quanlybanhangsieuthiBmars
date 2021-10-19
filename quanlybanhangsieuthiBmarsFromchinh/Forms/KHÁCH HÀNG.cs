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
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
            
        }
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
            label1.ForeColor = themecolor.SecondaryColor;
            label2.ForeColor = themecolor.PrimaryColor;
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
