﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Form1 f = new Form1();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
            voto frm = new voto();
            frm.Show();

           

          

        }

        private void btncongon1_Click(object sender, EventArgs e)
        {
           
            operaciones oper = new operaciones();
            oper.consultasinreaultado("Update regidor set voto = voto + 1, fecha ='" + DateTime.Now + "' where idreg = 1");
            Form1 f = new Form1();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
            voto frm = new voto();
            frm.Show();


        }

        private void julia_Load(object sender, EventArgs e)
        {

        }

       
    }
}
