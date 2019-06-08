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
	public partial class CalculoViabilidadeView : View {
		Dictionary<string, string> dados;
		public CalculoViabilidadeView(Dictionary<string, string> d, InicioView pai) : base(pai) {
			InitializeComponent();
			dados = d;

			foreach (var dado in dados)
				Console.WriteLine(dado.ToString());

			double vazaoMax = double.Parse(dados["vazaoMax"]);
			double vazaoMed = double.Parse(dados["vazaoMed"]);
			double vazaoMin = double.Parse(dados["vazaoMin"]);
			double vazaoMaxFut = double.Parse(dados["vazaoMaxFut"]);
			double vazaoMedFut = double.Parse(dados["vazaoMedFut"]);
			double vazaoMinFut = double.Parse(dados["vazaoMinFut"]);
			int populacao = int.Parse(dados["populacao"]);
			int populacaoFut = int.Parse(dados["populacaoFut"]);
			int tipoGrade = int.Parse(dados["tipoGrade"]);
			int tipoLimpeza = int.Parse(dados["tipoLimpeza"]);
			double espessura = double.Parse(dados["espessura"]);
			double espacamento = double.Parse(dados["espacamento"]);
			double velocidadeEfluente = double.Parse(dados["velocidadeEfluente"]);
			double taxaAreiaDiaria = double.Parse(dados["taxaAreiaDiaria"]);
			double viscosidadeABS = double.Parse(dados["viscosidadeABS"]);
			double densidadeOleo = double.Parse(dados["densidadeOleo"]);
			double turbulencia = double.Parse(dados["turbulencia"]);
			double dboEntrada = double.Parse(dados["dboEntrada"]);
			double tempMesFrio = double.Parse(dados["tempMesFrio"]);

			try {
				CentralTratamento ct = new CentralTratamento(vazaoMax, vazaoMed, vazaoMin, vazaoMaxFut, vazaoMedFut, vazaoMinFut, populacao, populacaoFut);
				SequenciaPreliminar sp = new SequenciaPreliminar(ct);
				ct.adicionar(sp);

				CalhaParshall cp = new CalhaParshall(sp);
				sp.adicionar(cp);

				Grade gr = new Grade(espessura, espacamento, tipoGrade, tipoLimpeza, sp);
                gr.CalculoEficiencia();
                gr.CalculaAreaUtil();
                gr.CalculaAreaUtilLinha();
                gr.CalculaSecaoCanal();
                gr.CalculaLarguraCanal();
                gr.CalculaSecaoCanalLinha();
                gr.CalculaVelocidadeLinha();
                gr.CalculaVelAproxMax();
                gr.CalculaVelAproxMin();
                gr.CalculaPerdaCarga();
                gr.CalculaPerdaCargaTotal();
                gr.CalculaBarras();
                gr.CalculaCorrecaoEspaco();
                gr.CalculaDiferencaEspaco();
                gr.CalculaComprimento();
                sp.adicionar(gr);

				Desarenador ds = new Desarenador(velocidadeEfluente, taxaAreiaDiaria, sp);
                ds.CalculaLarguraDesarenador();
                ds.CalculaAreaSecao();
                if (!ds.VerificaVH()) {
                    ds.corrigeVelocidade(velocidadeEfluente);   
                }
                ds.CalculaComprimento();
                ds.calculaAreaSuperficial();
                ds.CalculaTAS();
                if (!ds.VerificaTAS()) {
                    ds.corrigeVelocidade(velocidadeEfluente);
                }
                ds.calculaFrequenciaLimpeza();
				sp.adicionar(ds);

				//CaixaSAO cs = new CaixaSAO(viscosidadeABS, densidadeOleo, turbulencia, sp);
				//sp.adicionar(cs);

				SequenciaSecundaria ss = new SequenciaSecundaria(ct);
				ct.adicionar(ss);
				LagoaFacultativa lf = new LagoaFacultativa(dboEntrada, tempMesFrio, ss);
				ss.adicionarEmSerie(lf);

				Console.WriteLine("______Grade______:");
				Console.WriteLine("");

				Console.WriteLine("______Calha Parshall______:");
				Console.WriteLine("w " + cp.getW);
				Console.WriteLine("n " + cp.getN);
				Console.WriteLine("k " + cp.getK);
				Console.WriteLine("HMin " + cp.getHMin);
				Console.WriteLine("HMax " + cp.getHMax);
				Console.WriteLine("hMin " + cp.getPertenceASeq.gethMin);
				Console.WriteLine("hMax " + cp.getPertenceASeq.gethMax);

				

				Console.WriteLine("______Lagoa Facultativa______");
				Console.WriteLine("Carga Max" + lf.getCargaMax);
				Console.WriteLine("Carga Aflue" + lf.getCargaAfluente);
				Console.WriteLine("Area" + lf.getArea);
				Console.WriteLine("Volume" + lf.getVolume);
				Console.WriteLine("tempo Det" + lf.getTempoDetencao);

			} catch (Exception e) {
                MessageBox.Show(e.Message);
			}
		}
	}
}
