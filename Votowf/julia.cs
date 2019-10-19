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
    public partial class julia : Form
    {
        operaciones oper = new operaciones();
        public julia()
        {
            InitializeComponent();
        }

        private void btnreto_Click(object sender, EventArgs e)
        {
            Regidor f = new Regidor();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update regidor set voto = voto + 1, fecha ='" + DateTime.Now + "' where idreg = 1");
            confivt f = new confivt();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
           

           

          

        }

        private void btncongon1_Click(object sender, EventArgs e)
        {
           
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update regidor set voto = voto + 1, fecha ='" + DateTime.Now + "' where idreg = 1");
            confivt f = new confivt();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
            


        }

        private void julia_Load(object sender, EventArgs e)
        {

        }

        private void btncongon1_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer ltr = new SpeechSynthesizer();
            ltr.Dispose();
            ltr = new SpeechSynthesizer();
            ltr.SpeakAsync("Confirmar" + label2.Text);
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
