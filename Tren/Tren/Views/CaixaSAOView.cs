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
	public partial class CaixaSAOView : View {
		Dictionary<string, string> dados;
		public CaixaSAOView(Dictionary<string, string> d) {
			InitializeComponent();
			dados = d;
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string visc = txb_viscosidadeABS.Text;
			string dens = txb_densidadeOleo.Text;
			string turb = txb_turbulencia.Text;

			dados["viscosidadeABS"] = visc;
			dados["densidadeOleo"] = dens;
			dados["turbulencia"] = turb;

			foreach (var d in dados)
				Console.WriteLine(d.ToString());

			CalculoViabilidadeView calculo = new CalculoViabilidadeView(dados);
			calculo.TopLevel = false;
			calculo.Dock = DockStyle.Fill;
			Parent.Controls.Add(calculo);
			calculo.Show();
			Close();
		}

		private void bt_central2_voltar_Click(object sender, EventArgs e) {
			CentralDeTratamento1View central1 = new CentralDeTratamento1View();
			central1.TopLevel = false;
			central1.Dock = DockStyle.Fill;
			Parent.Controls.Add(central1);
			central1.Show();
			Close();
		}
	}
}
