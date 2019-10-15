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
    public partial class Regidor : Form
    {
        public Regidor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            julia f = new julia();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miguel f = new miguel();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alma f = new Alma();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

    }
    }

