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
	public partial class CentralDeTratamento1View : View {
		public CentralDeTratamento1View() {
			InitializeComponent();
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			// usar pilhas para memorizar a sequencia escolhida e poder voltar a vontade

			// Recupera valores do textBox
			string vazaoMax = txb_vazaoMax.Text;
			string vazaoMed = txb_vazaoMed.Text;
			string vazaoMin = txb_vazaoMin.Text;
			string vazaoMaxFut = txb_vazaoMaxFut.Text;
			string vazaoMedFut = txb_vazaoMedFut.Text;
			string vazaoMinFut = txb_vazaoMinFut.Text;
			string populacao = txb_populacao.Text;
			string populacaoFut = txb_populacaoFut.Text;



			CaixaSAOView caixaSAO = new CaixaSAOView();
			caixaSAO.TopLevel = false;
			caixaSAO.Dock = DockStyle.Fill;
			Parent.Controls.Add(caixaSAO);
			caixaSAO.Show();
			Close();
		}

		private void bt_central2_voltar_Click(object sender, EventArgs e) {
			PrincipalView principal = new PrincipalView();
			principal.TopLevel = false;
			principal.Dock = DockStyle.Fill;
			Parent.Controls.Add(principal);
			principal.Show();
			Close();
		}
	}
}
