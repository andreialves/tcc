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
	public partial class SelecaoSeqColView : Form {
		public SelecaoSeqColView() {
			InitializeComponent();
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			/*List<View> sequencia = new List<View>();
			sequencia.Add(new CentralDeTratamento0View(sequencia));
			sequencia.Add(new CaixaSAOView());
			sequencia.Add(new GradeView());
			sequencia.Add(new DesarenadorView());

			foreach (View v in sequencia) {
				v.TopLevel = false;
				v.Dock = DockStyle.Fill;
				Parent.Controls.Add(v);
			}

			int it = 0;
			// criar estrutura q vai usada para comunicação entre telas
			

			sequencia[it].Show();
			Hide();*/

			CentralDeTratamento0View central0 = new CentralDeTratamento0View();
			central0.TopLevel = false;
			central0.Dock = DockStyle.Fill;
			Parent.Controls.Add(central0);
			central0.Show();
			Close();
		}

		private void bt_central2_voltar_Click(object sender, EventArgs e) {
			PrincipalView principal = new PrincipalView();
			principal.TopLevel = false;
			principal.Dock = DockStyle.Fill;
			Parent.Controls.Add(principal);
			principal.Show();
			Close();
		}
	}
}
