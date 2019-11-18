using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using Tren.Interfaces;


namespace Tren.Classes {
	public class CalhaParshall : UnidadePreliminar	{
		private IDictionary<string, string> [] tabelaCalhas; // | mm | polegadas | vazaoMin | vazaoMax | n | k |
		private int mm;
		private int pol;
		private double n;
		private double k;
		private double HMin;
		private double HMax;
		private double desnivel;

		public CalhaParshall(SequenciaPreliminar sp) : base(sp)	{
			// carrega tabelaCalhas
			carregaTabela();
		}

		private void carregaTabela() {
			try {
				string[] linhas = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Tabelas Tren\calhas.tren");
				tabelaCalhas = new Dictionary<string, string>[linhas.Length];

				for (int i = 0; i < linhas.Length; i++) {
					string[] aux = linhas[i].Split(' ');

					tabelaCalhas[i] = new Dictionary<string, string>();
					tabelaCalhas[i]["mm"] = aux[0];
					tabelaCalhas[i]["pol"] = aux[1];
					tabelaCalhas[i]["vMin"] = aux[2];
					tabelaCalhas[i]["vMax"] = aux[3];
					tabelaCalhas[i]["n"] = aux[4];
					tabelaCalhas[i]["k"] = aux[5];
				}
			} catch (Exception) {
				throw new Exception("CalhaParshall::carregaTabela - Erro na leitura de tabelaCalhas");
			}
		}

		public void calcula() {
			IFormatProvider prov = CultureInfo.InvariantCulture;
			double menorInt = 100000;
			double vazaoMin = getPertenceASeq.getCentral.getVazaoMin;
			double vazaoMaxFut = getPertenceASeq.getCentral.getVazaoMaxFut;
			double vazaoMinFut = getPertenceASeq.getCentral.getVazaoMinFut;

			foreach (Dictionary<string, string> d in tabelaCalhas) {
				if (double.Parse(d["vMin"], prov) <= vazaoMin && double.Parse(d["vMax"], prov) >= vazaoMaxFut)
					if (double.Parse(d["vMax"], prov) - double.Parse(d["vMin"], prov) < menorInt) {
						menorInt = double.Parse(d["vMax"], prov) - double.Parse(d["vMin"], prov);
						mm = int.Parse(d["mm"]);
						pol = int.Parse(d["pol"]);
						n = double.Parse(d["n"], prov);
						k = double.Parse(d["k"], prov);
					}
			}

			HMin = Math.Pow(vazaoMin / (1000 * k), 1 / n);
			HMax = Math.Pow(vazaoMaxFut / (1000 * k), 1 / n);
			desnivel = (vazaoMaxFut * HMin - vazaoMin * HMax) / (vazaoMaxFut - vazaoMin);
			getPertenceASeq.gethMin = HMin - desnivel;
			getPertenceASeq.gethMax = HMax - desnivel;
		}

		public override void accept(Visitor v) {
			v.visit(this);
		}

		public int getWmm {
			get { return mm; }
		}
		public int getWpol {
			get {
				return pol;
			}
		}
		public double getN {
			get { return n; }
		}
		public double getK {
			get { return k; }
		}
		public double getHMax {
			get { return HMax; }
		}
		public double getHMin {
			get { return HMin; } 
}
		public double getDesnivel {
			get {
				return desnivel;
			}
		}
	}
}
