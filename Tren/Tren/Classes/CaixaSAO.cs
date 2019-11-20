using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes {
	public class CaixaSAO : UnidadePreliminar {
		private double viscosidadeABS;
		private double densidadeOleo;
		private double turbulencia;
		private double[,] tabelaVF;
		private double vHvV;
		private double vVertical;
		private double vHorizontal;
		private double areaTransv;
		private double largura;
		private double profundidade;
		private double comprimento;
		private double volume;
		private double tempoRes;


		public CaixaSAO(SequenciaPreliminar sp) : base(sp) {
			carregaTabela();
		}

		public CaixaSAO(double visc, double dens, double turb, SequenciaPreliminar sp) : base(sp){
			carregaTabela();
			setDados(visc, dens, turb);
		}

		public void setDados(double visc, double dens, double turb) {
			viscosidadeABS = visc;
			densidadeOleo = dens;
			turbulencia = turb;
		}

		private void carregaTabela() {
			IFormatProvider prov = CultureInfo.InvariantCulture;
			try {
				string[] linhas = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Tabelas Tren\caixaSAO.tren");
				tabelaVF = new double[linhas.Length,2];

				for (int i = 0; i < linhas.Length; i++) {
					string[] aux = linhas[i].Split(' ');

					tabelaVF[i, 0] = double.Parse(aux[0], prov);
					tabelaVF[i, 1] = double.Parse(aux[1], prov);
				}
			} catch (Exception) {
				throw new Exception("CaixaSAO::carregaTabela - Erro na leitura de tabelaVF");
			}
		}

		public void calcula() {
			for (int i = 0; i < tabelaVF.GetLength(0); i++)
				if (tabelaVF[i, 1] == turbulencia) {
					vHvV = tabelaVF[i, 0];
					break;
				}
			if (vHvV == 0)
				throw new System.ArgumentException("CaixaSAO::CaixaSAO - parametro com valor invalido", "turbulencia");

			vVertical = 980 * (0.015 * 0.015) * (0.999 - densidadeOleo) / (18 * viscosidadeABS);
			vHorizontal = vHvV / vVertical;
			areaTransv = getPertenceASeq.getCentral.getVazaoMaxFut * 100 / vHorizontal;
			largura = Math.Sqrt(areaTransv / 0.3);
			profundidade = 0.3 * largura;
			comprimento = turbulencia * vHvV * profundidade;
			volume = comprimento * largura * profundidade;
			tempoRes = volume / (getPertenceASeq.getCentral.getVazaoMaxFut * 60);
		}

		public override void accept(Visitor v) {
			v.visit(this);
		}

		public double getVHorizontal {
			get {
				return vHorizontal;
			}
		}
		public double getVVertical {
			get {
				return vVertical;
			}
		}
		public double getAreaTransv {
			get {
				return areaTransv;
			}
		}
		public double getLargura {
			get {
				return largura;
			}
		}
		public double getProfundidade {
			get {
				return profundidade;
			}
		}
		public double getComprimento {
			get {
				return comprimento;
			}
		}
		public double getVolume {
			get {
				return volume;
			}
		}
		public double getTempoRes {
			get {
				return tempoRes;
			}
		}
	}
}
