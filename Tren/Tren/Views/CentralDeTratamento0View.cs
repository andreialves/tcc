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
		public CentralDeTratamento0View() {
			InitializeComponent();
		}

		private void bt_central0_sim_Click(object sender, EventArgs e) {
			CentralDeTratamento1View central1 = new CentralDeTratamento1View();
			central1.TopLevel = false;
			central1.Dock = DockStyle.Fill;
			Parent.Controls.Add(central1);
			central1.Show();
			Close();
		}

		private void bt_central0_nao_Click(object sender, EventArgs e) {
			CentralDeTratamento2View central2 = new CentralDeTratamento2View();
			central2.TopLevel = false;
			central2.Dock = DockStyle.Fill;
			Parent.Controls.Add(central2);
			central2.Show();
			Close();
		}
	}
}
