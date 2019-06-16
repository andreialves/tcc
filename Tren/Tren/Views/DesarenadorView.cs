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
    public partial class DesarenadorView : View {
		Dictionary<string, string> dados;

		public DesarenadorView(Dictionary<string, string> d, InicioView pai) : base(pai) {
            InitializeComponent();
			dados = d;
        }

		private void bt_grade_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string veloc = txb_velocidade.Text;
			string taxaAreia = txb_taxaAreia.Text;

			if (veloc == "" || taxaAreia == "") {
				return;
			}

			dados["velocidadeEfluente"] = veloc;
			dados["taxaAreiaDiaria"] = taxaAreia;

			double velocidade = double.Parse(veloc);
			double txAreia = double.Parse(taxaAreia);

			foreach (var c in Pai.Centrais) {
				foreach (var s in c.getSequencia) {
					if (s.GetType() == typeof(SequenciaPreliminar)) {
						foreach (var u in ((SequenciaPreliminar)s).getSeqPreliminar) {
							if (u.GetType() == typeof(Desarenador)) {
								Desarenador ds = ((Desarenador)u);
								ds.VelocidadeEfluente = velocidade;
								ds.TaxaAreiaDiaria = txAreia;
								// Calcular todos os atributos
								ds.CalculaLarguraDesarenador();
								ds.CalculaAreaSecao();
								if (!ds.VerificaVH()) {
									ds.corrigeVelocidade(velocidade);
								}
								ds.CalculaComprimento();
								ds.calculaAreaSuperficial();
								ds.CalculaTAS();
								if (!ds.VerificaTAS()) {
									ds.corrigeVelocidade(velocidade);
								}
								ds.calculaFrequenciaLimpeza();
							}
						}
					}
				}
			}

			Pai.avancaView();
			Hide();
		}

		private void bt_grade_voltar_Click(object sender, EventArgs e) {
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
