using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Interfaces {
	public interface SequenciaInterface {
		void accept(Visitor v);
	}
}
