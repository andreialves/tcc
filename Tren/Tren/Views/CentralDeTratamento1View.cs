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
	public partial class CentralDeTratamento1View : View {
		Dictionary<string, string> dados;

		public CentralDeTratamento1View(Dictionary<string, string> d, InicioView pai) :base(pai) {
			InitializeComponent();
			dados = d;
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string vazaoMax = txb_vazaoMax.Text;
			string vazaoMed = txb_vazaoMed.Text;
			string vazaoMin = txb_vazaoMin.Text;
			string vazaoMaxFut = txb_vazaoMaxFut.Text;
			string vazaoMedFut = txb_vazaoMedFut.Text;
			string vazaoMinFut = txb_vazaoMinFut.Text;
			string populacao = txb_populacao.Text;
			string populacaoFut = txb_populacaoFut.Text;

			if (vazaoMax == "" || vazaoMed == "" || vazaoMin == "" ||
				vazaoMaxFut == "" || vazaoMedFut == "" || vazaoMinFut == "" ||
				populacao == "" || populacaoFut == "") {
				return;
			}
			
			dados["vazaoMax"] = vazaoMax;
			dados["vazaoMed"] = vazaoMed;
			dados["vazaoMin"] = vazaoMin;
			dados["vazaoMaxFut"] = vazaoMaxFut;
			dados["vazaoMedFut"] = vazaoMedFut;
			dados["vazaoMinFut"] = vazaoMinFut;
			dados["populacao"] = populacao;
			dados["populacaoFut"] = populacaoFut;

			double VMax = double.Parse(vazaoMax);
			double VMed = double.Parse(vazaoMed);
			double VMin = double.Parse(vazaoMin);
			double VMaxF = double.Parse(vazaoMaxFut);
			double VMedF = double.Parse(vazaoMedFut);
			double VMinF = double.Parse(vazaoMinFut);
			int pop = int.Parse(populacao);
			int popF = int.Parse(populacaoFut);

			foreach (var c in Pai.Centrais) {
				c.setDados(VMax, VMed, VMin, VMaxF, VMedF, VMinF, pop, popF);
				foreach (var s in c.getSequencia) {
					if (s.GetType() == typeof(SequenciaPreliminar)) {
						foreach (var u in ((SequenciaPreliminar)s).getSeqPreliminar) {
							if (u.GetType() == typeof(CalhaParshall)) {
								((CalhaParshall)u).calcula();
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
