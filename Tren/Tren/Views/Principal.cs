using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tren.Views {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e) {

        }

        private void metroTabPage1_Click(object sender, EventArgs e) {

        }

        private void metroButton1_Click(object sender, EventArgs e) {
            
        }

        private void metroButton2_Click(object sender, EventArgs e) {
			CentralDeTratamento1 central1 = new CentralDeTratamento1();
			central1.TopLevel = false;
			central1.Dock = DockStyle.Fill;
			Parent.Controls.Add(central1);
			central1.Show();
			Close();
		}
    }
}
