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
	public partial class SelecaoSeqIndView : View {
		public SelecaoSeqIndView(InicioView pai) : base(pai) {
			InitializeComponent();
		}

		private void bt_SelecaoSeqInd_avancar_Click(object sender, EventArgs e) {
			Pai.limpaLista();
			Pai.AddView(this, "Selecao");
			Dictionary<string, string> dados = new Dictionary<string, string>();

			if (cbx_Cs.Checked) {
				// Adiciona telas necessárias para coletar os dados da sequencia P(CS)
				Pai.AddView(new CentralDeTratamento0View(dados, Pai), "Central0");
				Pai.AddView(new View(Pai), "CentralX");
				Pai.AddView(new CaixaSAOView(dados, Pai), "CaixaSAO");

				// Cria central que representa essa sequencia de unidades
				CentralTratamento central = new CentralTratamento();
				SequenciaPreliminar seqP = new SequenciaPreliminar(central);
				central.adicionar(seqP);

				CaixaSAO caixa = new CaixaSAO(seqP);
				seqP.adicionar(caixa);

				// Adiciona Sequencia à lista de sequencias a serem comparadas
				Pai.Centrais.Add(central);
			}

			Pai.AddView(new CalculoViabilidadeView(dados, Pai), "Calculo");
			if (Pai.NumViews == 2)
				return;

			Pai.avancaView();
			Hide();
		}

		private void bt_SelecaoSeqInd_voltar_Click(object sender, EventArgs e) {
			PrincipalView principal = new PrincipalView(Pai);
			principal.TopLevel = false;
			principal.Dock = DockStyle.Fill;
			Parent.Controls.Add(principal);
			principal.Show();
			Close();
		}
	}
}
