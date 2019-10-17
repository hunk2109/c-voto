using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votowf
{
    public partial class verf : Form
    {
        public verf()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            votp f = new votp();
            f.Show();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            vsenv f = new vsenv();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            vdipv f = new vdipv();
            f.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            valcd f = new valcd();
            f.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            vregv f = new vregv();
            f.Show();
        }
    }
}
