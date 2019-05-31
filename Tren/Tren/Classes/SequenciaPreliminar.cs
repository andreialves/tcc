using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tren.Classes {
	class SequenciaPreliminar : Sequencia {
		private List<UnidadePreliminar> sequenciaPreliminar;

		private double hMin;
		private double hMax;


		public SequenciaPreliminar(CentralTratamento ct) : base(ct) {
			sequenciaPreliminar = new List<UnidadePreliminar>();
		}

		public void adicionar(UnidadePreliminar a) {
			sequenciaPreliminar.Add(a);
		}

		public double gethMin {
			get { return hMin; }
			set { hMin = value; }
		}

		public double gethMax {
			get { return hMax; }
			set { hMax = value; }
		}

		public List<UnidadePreliminar> getSeqPreliminar {
			get { return sequenciaPreliminar; }
		}
	}
}
