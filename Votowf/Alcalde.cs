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
    public partial class Alcalde : Form
    {
        public Alcalde()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ramona f = new Ramona();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Julio f = new Julio();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elisabeth f = new Elisabeth();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
    }
}
