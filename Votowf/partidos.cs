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

    public partial class partidos : Form
    {
        SpeechSynthesizer ltr = new SpeechSynthesizer();
        public partidos()
        {
            InitializeComponent();
        }

        private void Btngon_Click(object sender, EventArgs e)
        {
            pld f = new pld();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();

        }

        private void partidos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Btngon_Enter(object sender, EventArgs e)
        {

            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(label1.Text);
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(label2.Text);
        }
    }
}
