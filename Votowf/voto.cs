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
            presidente();
            senador();
            diputado();
            alcalde();
            regidor();


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
