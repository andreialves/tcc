using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes{
    public abstract class Sequencia{
		private CentralTratamento pertenceACent;

		public Sequencia(CentralTratamento ct) {
			pertenceACent = ct;
		}

		public abstract void accept(Visitor v); 

		public CentralTratamento getCentral {
			get { return pertenceACent; }
		}
	}
}
