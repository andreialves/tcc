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

			// Configurando Sequencia de Unidades da Central P + LA + LF
			if (cbx_PLaLf.Checked) {
				// Adiciona telas necessárias para coletar os dados da sequencia P + LA + LF
				Pai.AddView(new CentralDeTratamento0View(dados, Pai), "Central0");
				Pai.AddView(new View(Pai), "CentralX");
				Pai.AddView(new GradeView(dados, Pai), "Grade");
				Pai.AddView(new DesarenadorView(dados, Pai), "Desarenador");
				Pai.AddView(new DBOView(Pai), "DBO");
				Pai.AddView(new LagoaAnaerobiaView(Pai), "LagoaAnaerobia");
				Pai.AddView(new LagoaFacultativaView(Pai), "LagoaFacultativa");

				// Cria central que representa essa sequencia de unidades
				CentralTratamento central = new CentralTratamento();
				SequenciaPreliminar seqP = new SequenciaPreliminar(central);
				central.adicionar(seqP);

				CalhaParshall calha = new CalhaParshall(seqP);
				Desarenador des = new Desarenador(seqP);
				Grade grd = new Grade(seqP);
				seqP.adicionar(calha);
				seqP.adicionar(des);
				seqP.adicionar(grd);

				SequenciaSecundaria seqS = new SequenciaSecundaria(central);
				central.adicionar(seqS);

				LagoaAnaerobia lagoaA = new LagoaAnaerobia(seqS);
				LagoaFacultativa lagoaF = new LagoaFacultativa(seqS);
				seqS.adicionarEmSerie(lagoaA);
				seqS.adicionarEmSerie(lagoaF);

				// Adiciona Sequencia à lista de sequencias a serem comparadas
				Pai.Centrais.Add(central);
			}

			// Configurando Sequencia de Unidades da Central P + LA + LF + LM
			if (cbx_PLaLfLm.Checked) {
				// Adiciona telas necessárias para coletar os dados da sequencia P + LA + LF + LM
				Pai.AddView(new CentralDeTratamento0View(dados, Pai), "Central0");
				Pai.AddView(new View(Pai), "CentralX");
				Pai.AddView(new GradeView(dados, Pai), "Grade");
				Pai.AddView(new DesarenadorView(dados, Pai), "Desarenador");
				Pai.AddView(new DBOView(Pai), "DBO");
				Pai.AddView(new LagoaAnaerobiaView(Pai), "LagoaAnaerobia");
				Pai.AddView(new LagoaFacultativaView(Pai), "LagoaFacultativa");
				Pai.AddView(new LagoaMaturacaoView(dados, Pai), "LagoaMaturacao");

				// Cria central que representa essa sequencia de unidades
				CentralTratamento central = new CentralTratamento();
				SequenciaPreliminar seqP = new SequenciaPreliminar(central);
				central.adicionar(seqP);

				CalhaParshall calha = new CalhaParshall(seqP);
				Desarenador des = new Desarenador(seqP);
				Grade grd = new Grade(seqP);
				seqP.adicionar(calha);
				seqP.adicionar(des);
				seqP.adicionar(grd);

				SequenciaSecundaria seqS = new SequenciaSecundaria(central);
				central.adicionar(seqS);

				LagoaAnaerobia lagoaA = new LagoaAnaerobia(seqS);
				LagoaFacultativa lagoaF = new LagoaFacultativa(seqS);
				LagoaMaturacao lagoaM = new LagoaMaturacao(seqS);
				seqS.adicionarEmSerie(lagoaA);
				seqS.adicionarEmSerie(lagoaF);
				seqS.adicionarEmSerie(lagoaM);

				// Adiciona Sequencia à lista de sequencias a serem comparadas
				Pai.Centrais.Add(central);
			}

			// Configurando Sequencia de Unidades da Central P + LF
			if (cbx_PLf.Checked) {
				// Adiciona telas necessárias para coletar os dados da sequencia P + LF
				Pai.AddView(new CentralDeTratamento0View(dados, Pai), "Central0");
				Pai.AddView(new View(Pai), "CentralX");
				Pai.AddView(new GradeView(dados, Pai), "Grade");
				Pai.AddView(new DesarenadorView(dados, Pai), "Desarenador");
				Pai.AddView(new DBOView(Pai), "DBO");
				Pai.AddView(new LagoaFacultativaView(Pai), "LagoaFacultativa");

				// Cria central que representa essa sequencia de unidades
				CentralTratamento central = new CentralTratamento();
				SequenciaPreliminar seqP = new SequenciaPreliminar(central);
				central.adicionar(seqP);

				CalhaParshall calha = new CalhaParshall(seqP);
				Desarenador des = new Desarenador(seqP);
				Grade grd = new Grade(seqP);
				seqP.adicionar(calha);
				seqP.adicionar(des);
				seqP.adicionar(grd);

				SequenciaSecundaria seqS = new SequenciaSecundaria(central);
				central.adicionar(seqS);

				LagoaFacultativa lagoaF = new LagoaFacultativa(seqS);
				seqS.adicionarEmSerie(lagoaF);

				// Adiciona Sequencia à lista de sequencias a serem comparadas
				Pai.Centrais.Add(central);
			}

			// Configurando Sequencia de Unidades da Central P + RU
			if (cbx_PRu.Checked) {
                // Adiciona telas necessárias para coletar os dados da sequencia P + RU
                Pai.AddView(new CentralDeTratamento0View(dados, Pai), "Central0");
                Pai.AddView(new View(Pai), "CentralX");
                Pai.AddView(new GradeView(dados, Pai), "Grade");
                Pai.AddView(new DesarenadorView(dados, Pai), "Desarenador");
				Pai.AddView(new DBOView(Pai), "DBO");
                Pai.AddView(new ReatorUASBView(dados, Pai), "ReatorUasb");

                // Cria central que representa essa sequencia de unidades
                CentralTratamento central = new CentralTratamento();
                SequenciaPreliminar seqP = new SequenciaPreliminar(central);
                central.adicionar(seqP);

                CalhaParshall calha = new CalhaParshall(seqP);
                Desarenador des = new Desarenador(seqP);
                Grade grd = new Grade(seqP);
                seqP.adicionar(calha);
                seqP.adicionar(des);
                seqP.adicionar(grd);

                SequenciaSecundaria seqS = new SequenciaSecundaria(central);
                central.adicionar(seqS);

                ReatorUASB reator = new ReatorUASB(seqS);
                seqS.adicionarEmSerie(reator);
                Pai.Centrais.Add(central);
            }


			Pai.AddView(new CalculoViabilidadeView(dados, Pai), "Calculo");

			// Verifica se alguma sequencia foi selecionada
			if (Pai.NumViews == 2)
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
