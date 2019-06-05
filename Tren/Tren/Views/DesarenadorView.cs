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
    public partial class DesarenadorView : View {
        public DesarenadorView() {
            InitializeComponent();
        }

		private void bt_grade_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string veloc = txb_velocodade.Text;
			string taxaAreia = txb_taxaAreia.Text;
		}
	}
}
