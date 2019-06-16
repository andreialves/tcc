using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
    public class Sequencia{
		private CentralTratamento pertenceACent;

		public Sequencia(CentralTratamento ct) {
			pertenceACent = ct;
		}

		public CentralTratamento getCentral {
			get { return pertenceACent; }
		}
	}
}
