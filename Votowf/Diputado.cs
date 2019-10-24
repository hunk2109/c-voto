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
    public partial class Diputado : Form
    {
        public Diputado()
        {
            InitializeComponent();
        }

        private void btnca1_Click(object sender, EventArgs e)
        {
            Ramon f = new Ramon();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncan2_Click(object sender, EventArgs e)
        {
           karina f = new karina();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();

        }

        private void btncan3_Click(object sender, EventArgs e)
        {
            Gabriel f = new Gabriel();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void Diputado_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Diputado");
            this.ActiveControl = pictureBox1;
        }

        private void btnca1_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(label1.Text);
        }

        private void btncan2_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(label2.Text);
        }

        private void btncan3_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(label3.Text);

        }
    }
    }

