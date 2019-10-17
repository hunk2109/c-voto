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
    public partial class Ramon : Form
    {
        public Ramon()
        {
            InitializeComponent();
        }

        private void Ramon_Load(object sender, EventArgs e)
        {

        }

        private void btnreto_Click(object sender, EventArgs e)
        {
            Diputado f = new Diputado();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update Diputado set voto = voto + 1, fecha ='" + DateTime.Now + "' where iddip = 1");
            Alcalde f = new Alcalde();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncongon1_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update Diputado set voto = voto + 1, fecha ='" + DateTime.Now + "' where iddip = 1");
            Alcalde f = new Alcalde();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
    }
}
