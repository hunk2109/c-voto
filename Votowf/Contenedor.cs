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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.MdiParent = this;
            f.ControlBox = false;
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
