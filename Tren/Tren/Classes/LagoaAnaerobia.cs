using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes {
	public class LagoaAnaerobia : UnidadeSecundaria {
		private int qtdLagoas;
		private double cargaAfluente;
		private double taxaVolumetrica;
		private double volume;
		private double tempoDetHidraulica;
		private double altura;
		private double area;
		private double largura;
		private double lodoPessoa;
		private double lodoAno;
		private double espessura;
		private double espessuraFut;

		public LagoaAnaerobia(SequenciaSecundaria ss) : base(ss) { }

		public LagoaAnaerobia(double dbo, double taxaVol, SequenciaSecundaria ss) : base(ss) {
			setDados(dbo, taxaVol);
		}

		public void setDados(double dbo, double taxaVol) {
			dboEntrada = dbo;
			taxaVolumetrica = taxaVol;
		}

		public void calcula() {
			calculaCargaAfluente();
			calculaVolume();
			calculaTempoDetHidraulica();
			calculaAltura();
			calculaArea();
			calculaLargura();
			calculaDBOSaida();
			calculaLodoPessoa();
			calculaLodoAno();
			calculaEspessura();
			calculaEspessuraFut();
		}

		private void calculaCargaAfluente() {
			cargaAfluente = getPertenceASeq.getCentral.getVazaoMedFut * 86.4 * dboEntrada / 1000;
		}

		private void calculaVolume() {
			volume = cargaAfluente / taxaVolumetrica;
		}

		private void calculaTempoDetHidraulica() {
			tempoDetHidraulica = volume / (getPertenceASeq.getCentral.getVazaoMedFut * 86.4);
			if (tempoDetHidraulica < 3 || tempoDetHidraulica > 6) {
				throw new Exception("LagoaAnaerobia::calculaTempoDetHidraulica - TempoDetHidraulica inválido");
			}
		}

		private void calculaAltura() {
			altura = 4.5;
		}

		private void calculaArea() {
			area = volume / altura;
			if (area < 2000) {
				qtdLagoas = 1;
			} else {
				qtdLagoas = 2;
				area = area / 2;
				volume = volume / 2;
			}
		}

		private void calculaLargura() {
			largura = Math.Pow(area, 0.5);
		}

		private void calculaDBOSaida() {
			dboSaida = 0.5 * dboEntrada;
		}

		private void calculaLodoPessoa() {
			lodoPessoa = 0.01;
		}

		private void calculaLodoAno() {
			lodoAno = lodoPessoa * getPertenceASeq.getCentral.getPopulacao;
		}

		private void calculaEspessura() {
			espessura = lodoAno / area;
		}

		private void calculaEspessuraFut() {
			espessuraFut = espessura * 20;
		}

		public override void accept(Visitor v) {
			v.visit(this);
		}

		public int getQtdLagoas {
			get {
				return qtdLagoas;
			}
		}
		public double getVolume {
			get{
				return volume;
			}
		}
		public double getArea {
			get {
				return area;
			}
		}
		public double getLargura {
			get {
				return largura;
			}
		}
		public double getLodoAnual {
			get {
				return lodoAno;
			}
		}
		public double getEspessura {
			get {
				return espessura;
			}
		}
		public double getEspessuraFut {
			get {
				return espessuraFut;
			}
		}
		public double getTempoDetHidr {
			get {
				return tempoDetHidraulica;
			}
		}
	}
}
