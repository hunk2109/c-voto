using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Votowf
{
    public partial class confivt : Form
    {
        public confivt()
        {
            InitializeComponent();
        }

        private void Confivt_Load(object sender, EventArgs e)
        {
            string p, s, d, a, r;
            using (SQLiteConnection dataConnection = new SQLiteConnection("Data Source=C:\\bdd\\sm.s3db; Version=3;"))
            using (SQLiteCommand dataCommand1 = new SQLiteCommand("select nombre from presidente order by fecha desc limit 1", dataConnection))
            using (SQLiteCommand dataCommand2 = new SQLiteCommand("select nombre from   Senador order by fecha desc limit 1", dataConnection))
            using (SQLiteCommand dataCommand3 = new SQLiteCommand("select nombre from diputado order by fecha desc limit 1", dataConnection))
            using (SQLiteCommand dataCommand4 = new SQLiteCommand("select nombre from alcalde order by fecha desc limit 1", dataConnection))
            using (SQLiteCommand dataCommand5= new SQLiteCommand("select nombre from regidor order by fecha desc limit 1", dataConnection))




            {
                dataConnection.Open();
                p = Convert.ToString(dataCommand1.ExecuteScalar());
                s = Convert.ToString(dataCommand2.ExecuteScalar());
                d = Convert.ToString(dataCommand3.ExecuteScalar());
                a = Convert.ToString(dataCommand4.ExecuteScalar());
                r = Convert.ToString(dataCommand5.ExecuteScalar());
                label1.Text = p.ToString();
                label2.Text = s.ToString();
                label3.Text = d.ToString();
                label4.Text = a.ToString();
                label5.Text = r.ToString();
            }
        }

        private void Btncont_Click(object sender, EventArgs e)
        {
            partidos f = new partidos();
            f.Show();
            f.MdiParent = this.MdiParent;
            f.Show();            
            voto frm = new voto();                    
            frm.Show();
            this.Close();

        }

        private void Btnreto_Click(object sender, EventArgs e)
        {
            partidos f = new partidos();
            f.Show();
            f.MdiParent = this.MdiParent;
            f.Show();            
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update presidente set votos = votos - 1, fecha ='" + DateTime.Now + "' where nombre = '"+label1.Text+"'");
            oper.consultasinreaultado("Update senador set voto = voto - 1, fecha ='" + DateTime.Now + "' where nombre = '" + label2.Text + "'");
            oper.consultasinreaultado("Update diputado set voto = voto - 1, fecha ='" + DateTime.Now + "' where nombre = '" + label3.Text + "'");
            oper.consultasinreaultado("Update alcalde set voto = voto - 1, fecha ='" + DateTime.Now + "' where nombre = '" + label4.Text + "'");
            oper.consultasinreaultado("Update regidor set voto = voto - 1, fecha ='" + DateTime.Now + "' where nombre = '" + label5.Text + "'");
            this.Close();



        }
    }
}
