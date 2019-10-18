using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;


namespace Votowf
{
    public partial class Leonel : Form
    {
        public Leonel()
        {
            InitializeComponent();
        }
        SpeechSynthesizer ltr = new SpeechSynthesizer();

        private void Leonel_Load(object sender, EventArgs e)
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
            oper.consultasinreaultado("Update  presidente set votos = votos + 1, fecha ='"+DateTime.Now+"' where idpre = 3");
            Senador f = new Senador();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update  presidente set votos = votos + 1, fecha ='" + DateTime.Now + "' where idpre = 3");
            Senador f = new Senador();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncongon1_Enter(object sender, EventArgs e)
        {

            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Confirmar" + label1.Text);
        }

        private void btnreto_Enter(object sender, EventArgs e)
        {

            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Retornar a la seleccion de precandidatos a la Presidentes");
        }
    }
}
