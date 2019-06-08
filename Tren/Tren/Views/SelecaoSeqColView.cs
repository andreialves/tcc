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
	public partial class SelecaoSeqColView : View {
		public SelecaoSeqColView(InicioView pai) : base(pai) {
			InitializeComponent();
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			Pai.limpaLista();
			Pai.AddView(this, "Selecao");
			Dictionary<string, string> dados = new Dictionary<string, string>();

			if (cbx_PLf.Checked) {
				Pai.AddView(new CentralDeTratamento0View(Pai), "Central0");
				Pai.AddView(new CaixaSAOView(dados, Pai), "CaixaSAO");
				Pai.AddView(new GradeView(dados, Pai), "Grade");
				Pai.AddView(new DesarenadorView(dados, Pai), "Desarenador");
				Pai.AddView(new CalculoViabilidadeView(dados, Pai), "Calculo");
			}

			if (Pai.NumViews == 1)
				return;
			
			Pai.avancaView();
			Close();
		}

		private void bt_central2_voltar_Click(object sender, EventArgs e) {
			PrincipalView principal = new PrincipalView(Pai);
			principal.TopLevel = false;
			principal.Dock = DockStyle.Fill;
			Parent.Controls.Add(principal);
			principal.Show();
			Close();
		}
	}
}
