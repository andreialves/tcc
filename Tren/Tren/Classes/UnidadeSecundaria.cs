using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
	class UnidadeSecundaria	{
		private SequenciaSecundaria pertenceASeq;


		UnidadeSecundaria(SequenciaSecundaria ss) {
			pertenceASeq = ss;
		}

		public SequenciaSecundaria getPertenceASeq
		{
			get { return pertenceASeq; }
		}
	}
}
