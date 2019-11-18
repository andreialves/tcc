using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes {
	public class LagoaFacultativa : UnidadeSecundaria{
		double tempMesFrio;
		double cargaMax;
		double cargaAfluente;
		double area;
		double altura;
		double volume;
		double tempoDetHidraulica;


		public LagoaFacultativa(SequenciaSecundaria ss) : base(ss) {

		}

		public LagoaFacultativa(double dbo, double temp, SequenciaSecundaria ss) : base(ss){
			setDados(dbo, temp);
		}

		public void setDados(double dbo, double temp) {
			dboEntrada = dbo;
			tempMesFrio = temp;
		}

		public void calcula() {
			altura = 2;

			cargaMax = 350 * Math.Pow(1.107 - 0.002 * tempMesFrio, tempMesFrio - 25);
			cargaAfluente = getPertenceASeq.getCentral.getVazaoMedFut * 86.4 * dboEntrada / 1000;
			area = cargaAfluente / cargaMax * 10000;
			volume = area * altura;
			tempoDetHidraulica = volume / (getPertenceASeq.getCentral.getVazaoMedFut * 86.4);
			dboSaida = 0.2 * dboEntrada;
		}

		public override void accept(Visitor v) {
			v.visit(this);
		}

		public double getArea {
			get {
				return area;
			}
		}
		public double getVolume {
			get {
				return volume;
			}
		}
		public double getTempoDetencao {
			get {
				return tempoDetHidraulica;
			}
		}
		public double getCargaMax {
			get {
				return cargaMax;
			}
		}
		public double getCargaAfluente {
			get {
				return cargaAfluente;
			}
		}
	}
}
