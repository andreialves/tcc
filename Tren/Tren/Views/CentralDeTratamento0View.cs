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
		Dictionary<string, string> dados;

		public CentralDeTratamento0View(Dictionary<string, string> d, InicioView pai) : base(pai) {
			InitializeComponent();
			dados = d;
		}

		private void bt_central0_sim_Click(object sender, EventArgs e) {
			CentralDeTratamento1View central1 = new CentralDeTratamento1View(dados, Pai);
			central1.TopLevel = false;
			central1.Dock = DockStyle.Fill;
			Parent.Controls.Add(central1);
			central1.Show();
			Hide();
		}

		private void bt_central0_nao_Click(object sender, EventArgs e) {
			CentralDeTratamento2View central2 = new CentralDeTratamento2View(dados, Pai);
			central2.TopLevel = false;
			central2.Dock = DockStyle.Fill;
			Parent.Controls.Add(central2);
			central2.Show();
			Hide();
		}
	}
}
