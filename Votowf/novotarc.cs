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
    public partial class novotarc : Form
    {
        public novotarc()
        {
            InitializeComponent();
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncongon1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncont_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Confirmar" + label3.Text);
        }

        private void btncongon1_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Confirmar" + label3.Text);
        }

        private void btnreto_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(btnreto.Text);
        }

        private void btnreto_Click(object sender, EventArgs e)
        {

            partidos f = new partidos();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
    }
}
