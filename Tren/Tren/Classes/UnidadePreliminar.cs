using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes
{
    public abstract class UnidadePreliminar {
		private SequenciaPreliminar pertenceASeq;


		public UnidadePreliminar(SequenciaPreliminar sp) {
			pertenceASeq = sp;
		}

		public abstract void accept(Visitor v);

        public SequenciaPreliminar getPertenceASeq {
			get { return pertenceASeq; }
		}
    }
}
