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
    public partial class gonzalo : Form
    {
        public gonzalo()
        {
            InitializeComponent();
        }

        private void gonzalo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnreto_Click(object sender, EventArgs e)
        {
            presidente f = new presidente();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncongon1_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update  presidente set votos = votos + 1, fecha ='" + DateTime.Now + "' where idpre = 1");
            Senador f = new Senador();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update  presidente set votos = votos + 1, fecha ='" + DateTime.Now + "' where idpre = 1");
            Senador f = new Senador();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();

        }
    }
}
