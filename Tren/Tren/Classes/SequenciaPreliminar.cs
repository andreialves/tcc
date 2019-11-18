using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes {
	public class SequenciaPreliminar : Sequencia {
		private List<UnidadePreliminar> sequenciaPreliminar;

		private double? hMin = null;
		private double? hMax = null;


		public SequenciaPreliminar(CentralTratamento ct) : base(ct) {
			sequenciaPreliminar = new List<UnidadePreliminar>();
		}

		public void adicionar(UnidadePreliminar a) {
			sequenciaPreliminar.Add(a);
		}

		public override void accept(Visitor v) {
			v.visit(this);
		}

		public double? gethMin {
			get { return hMin; }
			set { hMin = value; }
		}

		public double? gethMax {
			get { return hMax; }
			set { hMax = value; }
		}

		public List<UnidadePreliminar> getSeqPreliminar {
			get { return sequenciaPreliminar; }
		}
	}
}
