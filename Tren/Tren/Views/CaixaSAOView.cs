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
		public CaixaSAOView(Dictionary<string, string> d, InicioView pai) : base(pai) {
			InitializeComponent();
			dados = d;
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string visc = txb_viscosidadeABS.Text;
			string dens = txb_densidadeOleo.Text;
			string turb = txb_turbulencia.Text;

			
			if (visc == "" || dens == "" || turb == "") {
				/// Exibir mensagem para preencher campos
				return;
			}

			dados["viscosidadeABS"] = visc;
			dados["densidadeOleo"] = dens;
			dados["turbulencia"] = turb;


			Pai.avancaView();
			Hide();
		}

		private void bt_central2_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Hide();
		}
	}
}
