using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes {
    public class TanqueSeptico : UnidadeSecundaria{

        private Dictionary<String, String>[] TabControlEsgoto;
        private double[] TabTempoDetHidrica;
        private int[][] TabelaAcumulacaoLodo;
        private Dictionary<String, String>[] OcupanteNumero;
        private int? tempoLimpeza = null;
        private double? temperaturaMesFrio = null;
        private double? vazaoDiaria = null;
        private double? esgotoTotal = null;
        private double? lodoFrescoTotal = null;
        private double? tempoDetHidraulica = null;
        private int? taxaAcumulacaoLodo = null;
        private double? volumeUtilNecessario = null;
        private double? dboEntrada = null;
        private double? dqoEntrada = null;
        private double? sstEntrada = null;
        private double? dboSaida = null;
        private double? sstSaida = null;


        public TanqueSeptico( SequenciaSecundaria ss) : base(ss) {

        }

        public TanqueSeptico(int tempoLimpeza, double temperaturaMesFrio, SequenciaSecundaria ss) : base(ss) {

        }
    }
}
