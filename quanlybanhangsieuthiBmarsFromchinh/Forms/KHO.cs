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
    public partial class KHO : Form
    {
        public KHO()
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
            label2.ForeColor = themecolor.SecondaryColor;
            label3.ForeColor = themecolor.PrimaryColor;
        }

        private void KHO_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
