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
		public CalculoViabilidadeView(Dictionary<string, string> d) {
			InitializeComponent();
			dados = d;

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

			try {
				CentralTratamento ct = new CentralTratamento(vazaoMax, vazaoMed, vazaoMin, vazaoMaxFut, vazaoMedFut, vazaoMinFut, populacao, populacaoFut);
				SequenciaPreliminar sp = new SequenciaPreliminar(ct);
				ct.adicionar(sp);
				CalhaParshall cp = new CalhaParshall(sp);
				sp.adicionar(cp);
				Grade gr = new Grade(espessura, espacamento, tipoGrade, tipoLimpeza, sp);
				sp.adicionar(gr);
				Desarenador ds = new Desarenador(velocidadeEfluente, taxaAreiaDiaria, sp);
				sp.adicionar(ds);
				CaixaSAO cs = new CaixaSAO(1.0, 0.8, 1.37, sp);
				sp.adicionar(cs);
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}
