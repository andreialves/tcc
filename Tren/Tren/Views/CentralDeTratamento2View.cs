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

namespace Tren.Views {
	public partial class CentralDeTratamento2View : View {
		Dictionary<string, string> dados;

		public CentralDeTratamento2View(Dictionary<string, string> d, InicioView pai) : base(pai) {
			InitializeComponent();
			dados = d;
		}

        private void CentralDeTratamento2_Load(object sender, EventArgs e) {

        }

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string populacao = txb_populacao.Text;
			string populacaoFut = txb_populacaoFut.Text;
			string qpc = txb_qpc.Text;
			string extensao = txb_extensaoRede.Text;
			string taxaInfiltracao = txb_taxaInfiltracao.Text;
			string taxaInfiltracaoFut = txb_taxaInfiltracaoFut.Text;
			string vazaoInfiltracao = txb_vazaoInfiltracao.Text;
			string vazaoInfiltracaoFut = txb_vazaoInfiltracaoFut.Text;
			string vazaoDomestica = txb_vazaoDomestica.Text;
			string vazaoDomesticaFut = txb_vazaoDomesticaFut.Text;

			if (populacao == "" || populacaoFut == "" || qpc == "" || extensao == "" ||
				taxaInfiltracao == "" || taxaInfiltracaoFut == "" || vazaoInfiltracao == "" ||
				vazaoInfiltracaoFut == "" || vazaoDomestica == "" || vazaoDomesticaFut == "") {
				return;
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
