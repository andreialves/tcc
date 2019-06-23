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
	public partial class LagoaAnaerobiaView : View {
		public LagoaAnaerobiaView(InicioView pai) : base(pai) {
			InitializeComponent();
		}
		
		private void bt_lagoaAnaerobia_avancar_Click(object sender, EventArgs e) {
			string dboEntrada = txb_dboEntrada.Text;
			string taxaVolumetrica = cb_taxaVolumetrica.Text;

			if (dboEntrada == "" || taxaVolumetrica == "") {
				return;
			}

			double dbo = double.Parse(dboEntrada);
			double txVol = double.Parse(taxaVolumetrica);

			foreach (var c in Pai.Centrais) {
				foreach (var s in c.getSequencia) {
					if (s.GetType() == typeof(SequenciaSecundaria)) {
						((SequenciaSecundaria)s).getSeqSecundaria[0][0].DBOEntrada = dbo;
						break;
					}
				}
			}

			try {
				foreach (var c in Pai.Centrais) {
					foreach (var s in c.getSequencia) {
						if (s.GetType() == typeof(SequenciaSecundaria)) {
							foreach (var l in ((SequenciaSecundaria)s).getSeqSecundaria) {
								foreach (var u in l) {
									if (u.GetType() == typeof(LagoaAnaerobia)) {
										((LagoaAnaerobia)u).setDados(dbo, txVol);
										((LagoaAnaerobia)u).calcula();
									}
								}
							}
						}
					}
				}
			} catch (Exception excp) {
				if (excp.Message == "LagoaAnaerobia::calculaTempoDetHidraulica - TempoDetHidraulica inválido") {
					lb_aviso.Visible = true;
					return;
				} else
					throw excp;
			}

			Pai.avancaView();
			Hide();
		}

		private void bt_LagoaAnaerobia_voltar_Click(object sender, EventArgs e) {
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

		private void cb_changed(object sender, EventArgs e) {
			lb_aviso.Visible = false;
		}
	}
}
