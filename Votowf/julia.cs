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
    public partial class julia : Form
    {
        operaciones oper = new operaciones();
        public julia()
        {
            InitializeComponent();
        }

        private void btnreto_Click(object sender, EventArgs e)
        {
            Regidor f = new Regidor();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            presidente();
            senador();
            diputado();
            alcalde();
            regidor();
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update regidor set voto = voto + 1, fecha ='" + DateTime.Now + "' where idreg = 1");
            voto f = new voto();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
          

        }

        private void btncongon1_Click(object sender, EventArgs e)
        {
            presidente();
            senador();
            diputado();
            alcalde();
            regidor();
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update regidor set voto = voto + 1, fecha ='" + DateTime.Now + "' where idreg = 1");
            voto f = new voto();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
           

        }

        private void julia_Load(object sender, EventArgs e)
        {

        }

        private void presidente()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,fecha from presidente order by fecha desc limit 1");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\presidente.xml");
        }

        private void senador()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,fecha from senador order by fecha desc limit 1");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\senador.xml");
        }

        private void diputado()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,fecha from diputado order by fecha desc limit 1");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\diputado.xml");
        }

        private void alcalde()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,fecha from alcalde order by fecha desc limit 1");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\alcalde.xml");
        }


        private void regidor()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,fecha from regidor order by fecha desc limit 1");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\regidor.xml");
        }
    }
}
