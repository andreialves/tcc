using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tren.Classes {
    public class CentralTratamento {
        private List<Sequencia> sequencia;

		private double vazaoMax;
		private double vazaoMed;
		private double vazaoMin;
		private double vazaoMaxFut;
		private double vazaoMedFut;
		private double vazaoMinFut;
		private int populacao;
		private int populacaoFut;
		private double dbo;

		private double qpc;
		private double extensaoRede;
		private double extensaoRedeFut;
		private double taxaInfiltracao;
		private double taxaInfiltracaoFut;
		private double vazaoInfiltracao;
		private double vazaoInfiltracaoFut;
		private double vazaoDomestica;
		private double vazaoDomesticaFut;


		public CentralTratamento() {
			sequencia = new List<Sequencia>();
		}

		public CentralTratamento(double vMax, double vMed, double vMin,
								double vMaxFut, double vMedFut, double vMinFut, int pop, int popFut) {
			sequencia = new List<Sequencia>();

			vazaoMax = vMax;
			vazaoMed = vMed;
			vazaoMin = vMin;
			vazaoMaxFut = vMaxFut;
			vazaoMedFut = vMedFut;
			vazaoMinFut = vMinFut;
			populacao = pop;
			populacaoFut = popFut;
		}

		public CentralTratamento(int pop, int popFut, double QPC,
								double extensao, double extensaoFut, double taxaInf, double taxaInfFut){
			sequencia = new List<Sequencia>();

			populacao = pop;
			populacaoFut = popFut;
			qpc = QPC;
			extensaoRede = extensao;
			extensaoRedeFut = extensaoFut;
			taxaInfiltracao = taxaInf;
			taxaInfiltracaoFut = taxaInfFut;
		}

		public void setDados(double vMax, double vMed, double vMin,
							double vMaxFut, double vMedFut, double vMinFut, int pop, int popFut) {
			vazaoMax = vMax;
			vazaoMed = vMed;
			vazaoMin = vMin;
			vazaoMaxFut = vMaxFut;
			vazaoMedFut = vMedFut;
			vazaoMinFut = vMinFut;
			populacao = pop;
			populacaoFut = popFut;
		}

		public void setDados(int pop, int popFut, double QPC,
							double extensao, double extensaoFut, double taxaInf, double taxaInfFut) {
			populacao = pop;
			populacaoFut = popFut;
			qpc = QPC;
			extensaoRede = extensao;
			extensaoRedeFut = extensaoFut;
			taxaInfiltracao = taxaInf;
			taxaInfiltracaoFut = taxaInfFut;
		}

		public void calcula() {
			calculaVazaoDomestica();
			calculaVazaoDomesticaFut();
			calculaVazaoInfiltracao();
			calculaVazaoInfiltracaoFut();
			calculaVazao();
			calculaVazaoFut();
		}

		public void adicionar(Sequencia seq) {
			sequencia.Add(seq);
		}

		private void calculaVazaoDomestica(){
			vazaoDomestica = (populacao * qpc * 0.8) / 86400;
		}

		private void calculaVazaoDomesticaFut(){
			vazaoDomesticaFut = (populacaoFut * qpc * 0.8) / 86400;
		}

		private void calculaVazaoInfiltracao(){
			vazaoInfiltracao = extensaoRede * taxaInfiltracao;
		}

		private void calculaVazaoInfiltracaoFut(){
			vazaoInfiltracaoFut = extensaoRedeFut * taxaInfiltracaoFut;
		}

		private void calculaVazao(){
			try{
				vazaoMed = vazaoDomestica + vazaoInfiltracao;
				vazaoMax = (1.2 * 1.5 * vazaoDomestica) + vazaoInfiltracao;
				vazaoMin = (0.5 * vazaoDomestica) + vazaoInfiltracao;
			}
			catch (Exception){
				Console.WriteLine("Vazoes Domesticas e de Infiltracao não calculadas");
			}
		}

		private void calculaVazaoFut(){
			try{
				vazaoMedFut = vazaoDomesticaFut + vazaoInfiltracaoFut;
				vazaoMaxFut = (1.2 * 1.5 * vazaoDomesticaFut) + vazaoInfiltracaoFut;
				vazaoMinFut = (0.5 * vazaoDomesticaFut) + vazaoInfiltracaoFut;

			}
			catch (Exception){
				Console.WriteLine("Vazoes Domesticas e de Infiltracao não calculadas");
			}
		}

		public virtual void imprime(){
			try{
				Console.WriteLine("Ano       Populacao       Qmed       Qmin       Qmax");
				Console.WriteLine(DateTime.Now.Year + "       " + populacao + "       " + vazaoMed +
					"       " + vazaoMin + "       " + vazaoMax);
				Console.WriteLine((DateTime.Now.Year + 20) + "       " + populacaoFut + "       " + vazaoMedFut + "       " +
					vazaoMinFut + "       " + vazaoMaxFut);
			}
			catch (Exception e){
				Console.WriteLine(e.Message);
			}
		}

		public double getVazaoMax {
			get { return vazaoMax; }
		}
		public double getVazaoMin {
			get { return vazaoMin; }
		}
		public double getVazaoMed {
			get { return vazaoMed; }
		}
		public double getVazaoMaxFut {
			get { return vazaoMaxFut; }
		}
		public double getVazaoMinFut {
			get { return vazaoMinFut; }
		}
		public double getVazaoMedFut {
			get { return vazaoMedFut; }
		}
		public int getPopulacao {
			get { return populacao; }
		}
		public int getPopulacaoFut {
			get { return populacaoFut; }
		}
		public double DBOEntrada {
			get {
				return dbo;
			}
			set {
				dbo = value;
			}
		}
        public double getQPC {
            get { return qpc; }
        }
		public List<Sequencia> getSequencia {
			get {
				return sequencia;
			}
		}
	}
}
