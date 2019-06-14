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
			Pai.AddView(new CentralDeTratamento1View(dados, Pai), "CentralX");
			Pai.avancaView();
			Hide();
		}

		private void bt_central0_nao_Click(object sender, EventArgs e) {
			Pai.AddView(new CentralDeTratamento2View(dados, Pai), "CentralX");
			Pai.avancaView();
			Hide();
		}

		private void bt_central0_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Hide();
		}
	}
}
