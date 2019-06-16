using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
	public class UnidadeSecundaria	{
		private SequenciaSecundaria pertenceASeq;


		public UnidadeSecundaria(SequenciaSecundaria ss) {
			pertenceASeq = ss;
		}

		public SequenciaSecundaria getPertenceASeq
		{
			get { return pertenceASeq; }
		}
	}
}
