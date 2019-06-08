using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes {
	class LagoaFacultativa : UnidadeSecundaria{
		double dboEntrada;
		double tempMesFrio;
		double cargaMax;
		double cargaAfluente;
		double area;
		double altura;
		double volume;
		double tempoDetHidraulica;
		double dboSaida;

		public LagoaFacultativa(double dbo, double temp, SequenciaSecundaria ss) : base(ss){
			dboEntrada = dbo;
			tempMesFrio = temp;

			altura = 2;

			cargaMax = 350 * Math.Pow(1.107 - 0.002 * tempMesFrio, tempMesFrio - 25);
			cargaAfluente = getPertenceASeq.getCentral.getVazaoMedFut * dboEntrada / 1000;
			area = cargaAfluente / cargaMax * 1000;
			volume = area * altura;
			tempoDetHidraulica = volume / getPertenceASeq.getCentral.getVazaoMedFut;
			dboSaida = 0.2 * dboEntrada;
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
		public double getDBOEntrada {
			get {
				return dboEntrada;
			}
		}
		public double getDBOSaida {
			get {
				return dboSaida;
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
