using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes {
	public class SequenciaSecundaria : Sequencia {
		private List<List<UnidadeSecundaria>> sequenciaSecundaria;

		public SequenciaSecundaria(CentralTratamento ct) : base(ct)	{
			sequenciaSecundaria = new List<List<UnidadeSecundaria>>();
		}

		public void adicionarEmSerie(UnidadeSecundaria us) {
			sequenciaSecundaria.Add(new List<UnidadeSecundaria>());
			sequenciaSecundaria.Last().Add(us);
		}

		public void adicionarEmParalelo(int pos, UnidadeSecundaria us) {
			if(sequenciaSecundaria.Count > pos)
				sequenciaSecundaria[pos].Add(us);
			else
				throw new System.ArgumentException("Parametro com valor invalido", "pos");
		}

		public override void accept(Visitor v) {
			v.visit(this);
		}

		public List<List<UnidadeSecundaria>> getSeqSecundaria {
			get {
				return sequenciaSecundaria;
			}
		}
	}
}
