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
using System.Speech;
using System.Speech.Synthesis;

namespace Votowf
{
    public partial class gonzalo : Form
    {
        SpeechSynthesizer ltr = new SpeechSynthesizer();
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
            int gonzalo;
            int leonel;
            using (SQLiteConnection dataConnection = new SQLiteConnection("Data Source=C:\\bdd\\sm.s3db; Version=3;"))
            using (SQLiteCommand dataCommand1 = new SQLiteCommand("select votos from presidente where nombre ='Leonel Fernandez'", dataConnection))
            using (SQLiteCommand dataCommand2 = new SQLiteCommand("select votos from presidente where nombre ='Gonzalo Castillo'", dataConnection))

            {

                dataConnection.Open();
                leonel = Convert.ToInt32(dataCommand1.ExecuteScalar());
                gonzalo = Convert.ToInt32(dataCommand2.ExecuteScalar());

            }

            TimeSpan start = new TimeSpan(18, 40, 0);
            TimeSpan end = new TimeSpan(23, 59, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
           
                if  ((leonel > gonzalo) && (now > start) && (now < end))
                {


                    operaciones oper = new operaciones();
                    oper.consultasinreaultado("Update  presidente set votos = votos + 10, fecha ='" + DateTime.Now + "' where idpre = 1");
                    Senador f = new Senador();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                    this.Close();
                }

                else
                {
                    operaciones oper = new operaciones();
                    oper.consultasinreaultado("Update  presidente set votos = votos + 1, fecha ='" + DateTime.Now + "' where idpre = 1");
                    Senador f = new Senador();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                    this.Close();

                }



         
        }

        private void btncont_Click(object sender, EventArgs e)
        {

            int gonzalo;
            int leonel;
            using (SQLiteConnection dataConnection = new SQLiteConnection("Data Source=C:\\bdd\\sm.s3db; Version=3;"))
            using (SQLiteCommand dataCommand1 = new SQLiteCommand("select votos from presidente where nombre ='Leonel Fernandez'", dataConnection))
            using (SQLiteCommand dataCommand2 = new SQLiteCommand("select votos from presidente where nombre ='Gonzalo Castillo'", dataConnection))

            {

                dataConnection.Open();
                leonel = Convert.ToInt32(dataCommand1.ExecuteScalar());
                gonzalo = Convert.ToInt32(dataCommand2.ExecuteScalar());
                
            }

            TimeSpan start = new TimeSpan(18, 40, 0);
            TimeSpan end = new TimeSpan(23, 59, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (leonel > gonzalo)
            {
                if ((now > start) && (now < end))
                {


                    operaciones oper = new operaciones();
                    oper.consultasinreaultado("Update  presidente set votos = votos + 10, fecha ='" + DateTime.Now + "' where idpre = 1");
                    Senador f = new Senador();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                    this.Close();
                }

               

            }

            else
            {
                operaciones oper = new operaciones();
                oper.consultasinreaultado("Update  presidente set votos = votos + 1, fecha ='" + DateTime.Now + "' where idpre = 1");
                Senador f = new Senador();
                f.MdiParent = this.MdiParent;
                f.Show();
                this.Close();

            }
        }
        
        public void cambio()
        {
           
        }

        private void btncongon1_Enter(object sender, EventArgs e)
        {
           ;
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Confirmar"+label1.Text);
        }

        private void btnreto_Enter(object sender, EventArgs e)
        {
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(btnreto.Text);
        }
    }
}
