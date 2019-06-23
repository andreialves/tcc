using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
	public class UnidadeSecundaria {
		private SequenciaSecundaria pertenceASeq;

		protected double dboEntrada;
		protected double dboSaida;


		public UnidadeSecundaria(SequenciaSecundaria ss) {
			pertenceASeq = ss;
		}

		public SequenciaSecundaria getPertenceASeq {
			get { return pertenceASeq; }
		}
		public double getDBOSaida{
			get {
				return dboSaida;
			}
		}
		public double DBOEntrada {
			get {
				return dboEntrada;
			}
			set {
				dboEntrada = value;
			}
		}
	}
}
