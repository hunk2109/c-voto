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
    public partial class Senador : Form
    {
        public Senador()
        {
            InitializeComponent();
        }

        private void Senador_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            maria f = new maria();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pedro f = new pedro();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dolorez f = new dolorez();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

    }
    }
