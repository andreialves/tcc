using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes {
    public class LagoaMaturacao : UnidadeSecundaria {
        private double? coliformesIniciais = null;
        private double? temperaturaLiquido = null;
        private double? volume = null;
        private double? areaSuperficial = null;
        private double? areaSuperficialTotal = null;
        private double? areaRequerida = null;
        private double? largura = null;
        private double? comprimento = null;
        private double? kbt = null;
        private double? d = null;
        private double? a = null;
        private double? coliformesFinais = null;
        private double? eficienciaRemocaoColiMax = null;

        public LagoaMaturacao(double coliformesIniciais, double temperaturaLiquido, SequenciaSecundaria ss) : base(ss) {
            this.coliformesIniciais = coliformesIniciais;
            this.temperaturaLiquido = temperaturaLiquido;
        }

        public LagoaMaturacao(double coliformesIniciais, SequenciaSecundaria ss) : base(ss) {
            this.coliformesIniciais = coliformesIniciais;
            this.temperaturaLiquido = 20.0;
        }

        public void CalculaVolume() {
            if(getPertenceASeq.getCentral.getVazaoMedFut == null) {
                throw new Exception("Vazão média futura não calculada.");
            } else {
                volume = 4 * getPertenceASeq.getCentral.getVazaoMedFut;
            }
        }

        public void CalculaAreaSuperficial() {
            if(volume == null) {
                throw new Exception("Volume não calculado.");
            } else {
                areaSuperficial = volume;
            }
        }

        public void CalculaAreaSuperficialTotal() {
            if(areaSuperficial == null) {
                throw new Exception("Area superficial não calculada.");
            } else {
                areaSuperficialTotal = 3 * areaSuperficial;
            }
        }
    }
}
