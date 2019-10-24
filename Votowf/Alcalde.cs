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
    public partial class Alcalde : Form
    {
        public Alcalde()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ramona f = new Ramona();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Julio f = new Julio();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elisabeth f = new Elisabeth();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync( label1.Text);
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync( label2.Text);
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync( label3.Text);
        }

        private void Alcalde_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Alcade");
            this.ActiveControl = pictureBox1;
        }
    }
}
