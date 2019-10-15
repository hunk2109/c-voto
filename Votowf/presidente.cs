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
    public partial class presidente : Form
    {
        public presidente()
        {
            InitializeComponent();
        }

        private void presidente_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leonel f = new Leonel();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gonzalo f = new gonzalo();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
    }
}
