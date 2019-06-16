using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tren.Classes;

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

			double viscosidade = double.Parse(visc);
			double densidade = double.Parse(dens);
			double turbulencia = double.Parse(turb);

			foreach (var c in Pai.Centrais) {
				foreach (var s in c.getSequencia) {
					if (s.GetType() == typeof(SequenciaPreliminar)) {
						foreach (var u in ((SequenciaPreliminar)s).getSeqPreliminar) {
							if (u.GetType() == typeof(CaixaSAO)) {
								((CaixaSAO)u).setDados(viscosidade, densidade, turbulencia);
								((CaixaSAO)u).calcula();
							}
						}
					}
				}
			}

			Pai.avancaView();
			Hide();
		}

		private void bt_central2_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Hide();
		}

		private void txb_numeros(object sender, KeyPressEventArgs e) {
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ',') {
				if (e.KeyChar == ',' && ((MetroTextBox)sender).Text.Contains(','))
					e.Handled = true; // não processa tecla apertada
				return; // processa a tecla apertada
			}

			e.Handled = true; // não processa tecla apertada
		}
	}
}
