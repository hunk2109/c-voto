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
    public partial class verf : Form
    {
        operaciones oper = new operaciones();
        public verf()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            votp f = new votp();
            f.Show();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            vsenv f = new vsenv();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            vdipv f = new vdipv();
            f.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            valcd f = new valcd();
            f.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            vregv f = new vregv();
            f.Show();
        }

        private void Verf_Load(object sender, EventArgs e)
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
            DataTable dt = oper.cosnsultaconresultado("select nombre,votos from presidente");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\presidentet.xml");
        }

        private void senador()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,voto from senador");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\senadort.xml");
        }

        private void diputado()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,voto from diputado");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\diputadost.xml");
        }

        private void alcalde()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,voto from alcalde");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\alcaldet.xml");
        }

        private void regidor()
        {
            DataSet ds = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select nombre,voto from regidor");
            ds.Tables.Add(dt);
            ds.WriteXml(@"C:\bdd\regidort.xml");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
    }
}
