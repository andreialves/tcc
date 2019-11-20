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
	public partial class LagoaFacultativaView : View {
		public LagoaFacultativaView(InicioView pai) : base(pai) {
			InitializeComponent();
		}

		private void bt_lagoaFacul_avancar_Click(object sender, EventArgs e) {
			string tempMesFrio = txb_tempMesFrio.Text;

			if (tempMesFrio == "") {
				return;
			}
			
			double temp = double.Parse(tempMesFrio);

			foreach (var c in Pai.Centrais) {
				foreach (var s in c.getSequencia) {
					if (s.GetType() == typeof(SequenciaSecundaria)) {
						UnidadeSecundaria unidadeAnt = null;
						foreach (var l in ((SequenciaSecundaria)s).getSeqSecundaria) {
							foreach (var u in l) {
								if (u.GetType() == typeof(LagoaFacultativa)) {
									if (unidadeAnt != null) {
										double dbo = unidadeAnt.getDBOSaida;
										((LagoaFacultativa)u).setDados(dbo, temp);
									} else {
										((LagoaFacultativa)u).setDados(c.DBOEntrada, temp);
									}
									((LagoaFacultativa)u).calcula();
								}
								unidadeAnt = u;
							}
						}
					}
				}
			}

			Pai.avancaView();
			Hide();
		}

		private void bt_lagoFacul_voltar_Click(object sender, EventArgs e) {
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
