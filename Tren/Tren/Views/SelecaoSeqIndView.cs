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
	public partial class SelecaoSeqIndView : View {
		public SelecaoSeqIndView(InicioView pai) : base(pai) {
			InitializeComponent();
		}

		private void bt_SelecaoSeqInd_avancar_Click(object sender, EventArgs e) {
			Pai.limpaLista();
			Pai.AddView(this, "Selecao");
			Dictionary<string, string> dados = new Dictionary<string, string>();

			if (cbx_Cs.Checked) {
				Pai.AddView(new CaixaSAOView(dados, Pai), "CaixaSAO");
				Pai.AddView(new CalculoViabilidadeView(dados, Pai), "Calculo");
			}

			if (Pai.NumViews == 1)
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
