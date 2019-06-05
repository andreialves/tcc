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
		public CentralDeTratamento2View() {
			InitializeComponent();
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

		}
	}
}
