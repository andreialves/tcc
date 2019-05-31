using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
    class UnidadePreliminar {
		private SequenciaPreliminar pertenceASeq;


		public UnidadePreliminar(SequenciaPreliminar sp) {
			pertenceASeq = sp;
		}

        public SequenciaPreliminar getPertenceASeq {
			get { return pertenceASeq; }
		}
    }
}
