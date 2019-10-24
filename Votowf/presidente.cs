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
    public partial class presidente : Form
    {
        public presidente()
        {
            InitializeComponent();
        }
        SpeechSynthesizer ltr = new SpeechSynthesizer();
        private void presidente_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Precindetes");
            this.ActiveControl = pictureBox1;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leonel f = new Leonel();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gonzalo f = new gonzalo();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }


        
       

        private void Btngon_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(label1.Text);

        }

        private void btnleo_Enter(object sender, EventArgs e)
        {
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync(label2.Text);

        }
    }
}
