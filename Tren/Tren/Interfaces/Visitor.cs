using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using Tren.Classes;

namespace Tren.Interfaces {
	public interface Visitor {
		void visit(CaixaSAO cs);
		void visit(CalhaParshall cp);
		void visit(Desarenador d);
		void visit(Grade g);
		void visit(LagoaAnaerobia la);
		void visit(LagoaFacultativa lf);
		void visit(LagoaMaturacao lm);
		void visit(TanqueSeptico ts);
		void visit(List<CentralTratamento> listC);
		void visit(SequenciaPreliminar sp);
		void visit(SequenciaSecundaria ss);
        void visit(ReatorUASB reatorUASB);
    }
}
