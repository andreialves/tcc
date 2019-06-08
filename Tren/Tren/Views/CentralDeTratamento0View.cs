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
	public partial class CentralDeTratamento0View : View {
		public CentralDeTratamento0View(InicioView pai) : base(pai) {
			InitializeComponent();
		}

		private void bt_central0_sim_Click(object sender, EventArgs e) {
			Pai.avancaView();
			Close();
		}

		private void bt_central0_nao_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Close();
		}
	}
}
