using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes {
    class ReatorUASB : UnidadeSecundaria{

        private double dbo;
        private double dqo;
        private double sst;
        private double valorTipico;
        private double tempMesFrio;
        private double cargaDQODiaria;
        private double tempoDetHidraulica;
        private double volumeTotalReatores;
        private int mimReatores;
        private double volumeUtilReator;
        private double areaTransversalReator;
        private double areaTotal;
        private double prodMassaLodo;
        private double dboEntrada;
        private double dqoEntrada;
        private double dboSaida;
        private double dqoSaida;
        private double dqoEntradaAjustada;
        private double dqoSaidaAjustada;
        private double cargaConvertidaMetano;
        private double fatorCorrecaoTemp;
        private double conversaoMassaMetano;
        private double producaoBioGas;
        
        ReatorUASB (SequenciaSecundaria us) : base(us) {

        }


    }
}
