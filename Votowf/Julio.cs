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
    public partial class Julio : Form
    {
        public Julio()
        {
            InitializeComponent();
        }

        private void btnreto_Click(object sender, EventArgs e)
        {
            Alcalde f = new Alcalde();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update alcalde set voto = voto + 1, fecha ='" + DateTime.Now + "' where idalcal = 2");
            Regidor f = new Regidor();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncongon1_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update alcalde set voto = voto + 1, fecha ='" + DateTime.Now + "' where idalcal = 2");
            Regidor f = new Regidor();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncongon1_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Confirmar" + label1.Text);

        }

        private void btnreto_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(btnreto.Text);

        }
    }
}
