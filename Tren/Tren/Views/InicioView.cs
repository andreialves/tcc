using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tren.Views {
    public partial class InicioView : MetroForm {
        public InicioView() {
			InitializeComponent();
            PrincipalView principal = new PrincipalView();
            principal.TopLevel = false;
            principal.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(principal);
            principal.Show();
			
		}

        private void Inicio_Load(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
