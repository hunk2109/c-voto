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
    public partial class voto : Form
        
    {
        operaciones oper = new operaciones();
        public voto()
        {
            InitializeComponent();
        }

        private void voto_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,fecha from presidente order by fecha desc limit 1");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\voto");
        }
    }
}
