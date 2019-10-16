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
    public partial class pld : Form
    {
        public pld()
        {
            InitializeComponent();
        }

        private void pld_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Btngon_Click(object sender, EventArgs e)
        {
            presidente f = new presidente();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();

        }

        private void btncont_Click(object sender, EventArgs e)
        {
            presidente f = new presidente();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btnreto_Click(object sender, EventArgs e)
        {
            partidos f = new partidos();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
    }
}
