using System;
using MetroFramework.Controls;
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
	public partial class LagoaMaturacaoView : View {
		Dictionary<string, string> dados;

		public LagoaMaturacaoView(Dictionary<string, string> d, InicioView pai) : base(pai) {
			InitializeComponent();
			dados = d;
		}
		private void LagoaMaturacaoView_Load(object sender, EventArgs e) {

		}

		private void bt_lagoMaturacao_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Hide();
		}

		private void bt_lagoaMaturacao_avancar_Click(object sender, EventArgs e) {
			string coliformesInicias = this.coliformesInicias.Text, temperaturaLiquido = this.temperaturaLiquido.Text;
			if (coliformesInicias == "") {
				return;
			}
			if (temperaturaLiquido == "") {
				temperaturaLiquido = "20,0";
			}
			dados["coliformesInicias"] = coliformesInicias;
			dados["temperaturaLiquido"] = temperaturaLiquido;

			double col = double.Parse(coliformesInicias);
			double temp = double.Parse(temperaturaLiquido);

			foreach (var c in Pai.Centrais) {
				foreach (var s in c.getSequencia) {
					if (s.GetType() == typeof(SequenciaSecundaria)) {
						UnidadeSecundaria unidadeAnt = null;
						foreach (var l in ((SequenciaSecundaria)s).getSeqSecundaria) {
							foreach (var u in l) {
								if (u.GetType() == typeof(LagoaMaturacao)) {
									LagoaMaturacao lm = ((LagoaMaturacao)u);
									
									if (unidadeAnt != null) {
										double dbo = unidadeAnt.getDBOSaida;
										lm.DBOEntrada = dbo;
									} else {
										lm.DBOEntrada = c.DBOEntrada;
									}
									lm.ColiformesInicias = col;
									lm.TemperaturaLiquido = temp;
									lm.CalculaVolume();
									lm.CalculaAreaSuperficial();
									lm.CalculaAreaSuperficialTotal();
									lm.CalculaAreaTotalRequerida();
									lm.CalculaDimensoesLagoa();
									lm.CalculaKBT();
									lm.CalculaA();
									lm.CalculaConcentracaoColiformes();
									lm.CalculaEficiencia();
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
