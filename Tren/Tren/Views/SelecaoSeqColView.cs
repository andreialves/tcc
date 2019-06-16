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
	public partial class SelecaoSeqColView : View {
		public SelecaoSeqColView(InicioView pai) : base(pai) {
			InitializeComponent();
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			Pai.limpaLista();
			Pai.AddView(this, "Selecao");
			Dictionary<string, string> dados = new Dictionary<string, string>();

			if (cbx_PLf.Checked) {
				Pai.AddView(new CentralDeTratamento0View(dados, Pai), "Central0");
				Pai.AddView(new View(Pai), "CentralX");
				Pai.AddView(new GradeView(dados, Pai), "Grade");
				Pai.AddView(new DesarenadorView(dados, Pai), "Desarenador");
				Pai.AddView(new LagoaFacultativaView(dados, Pai), "LagoaFacultativa");
				Pai.AddView(new CalculoViabilidadeView(dados, Pai), "Calculo");

				CentralTratamento central = new CentralTratamento();
				SequenciaPreliminar seqP = new SequenciaPreliminar(central);
				central.adicionar(seqP);

				CalhaParshall calha = new CalhaParshall(seqP);
				Desarenador des = new Desarenador(0.3, 0.003, seqP);
				Desarenador des2 = new Desarenador(0.3, 0.003, seqP);
				CaixaSAO caixa = new CaixaSAO(seqP);
				Desarenador des3 = new Desarenador(0.3, 0.003, seqP);
				Grade grd = new Grade(10, 35, 1, 1, seqP);

				seqP.adicionar(calha);
				seqP.adicionar(des);
				seqP.adicionar(des2);
				seqP.adicionar(caixa);
				seqP.adicionar(des3);
				seqP.adicionar(grd);
			}

			if (cbx_PLaLf.Checked) {
				Pai.AddView(new DesarenadorView(dados, Pai), "Desarenador");
			}

			if (Pai.NumViews == 1)
				return;
			
			Pai.avancaView();
			Hide();
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
