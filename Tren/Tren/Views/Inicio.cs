﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tren.Views {
    public partial class Inicio : MetroFramework .Forms .MetroForm {
        public Inicio() {
            InitializeComponent();
            Principal principal = new Principal();
            principal.TopLevel = false;
            principal.Dock = DockStyle.Fill;
            panel1.Controls.Add(principal);
            principal.Show();
        }

        private void Inicio_Load(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
        
    }
}