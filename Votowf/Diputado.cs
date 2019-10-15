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
    public partial class Diputado : Form
    {
        public Diputado()
        {
            InitializeComponent();
        }

        private void btnca1_Click(object sender, EventArgs e)
        {
            Ramon f = new Ramon();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncan2_Click(object sender, EventArgs e)
        {
           karina f = new karina();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();

        }

        private void btncan3_Click(object sender, EventArgs e)
        {
            Gabriel f = new Gabriel();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
    }
}
