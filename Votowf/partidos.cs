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
    public partial class partidos : Form
    {
        public partidos()
        {
            InitializeComponent();
        }

        private void Btngon_Click(object sender, EventArgs e)
        {
            pld f = new pld();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();

        }

        private void partidos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
