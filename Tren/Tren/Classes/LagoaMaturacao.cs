using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

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
        private const double d =  5 / (-0.261 + (0.254 * 5) + (1.014 * 25));
        private double? a = null;
        private double? coliformesFinais = null;
        private double? eficienciaRemocaoColiMax = null;

        public LagoaMaturacao(SequenciaSecundaria ss) : base(ss) { }

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
                volume = 4 * getPertenceASeq.getCentral.getVazaoMedFut * 86.4;
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

        public void CalculaAreaTotalRequerida() {
            if (areaSuperficialTotal == null) {
                throw new Exception("Area superficial total não calculada.");
            } else {
                areaRequerida = (areaSuperficialTotal * 1.25) / 1000;
            }
        }

        public void CalculaDimensoesLagoa() {
            if (areaSuperficial == null) {
                throw new Exception("Area superficial não calculada.");
            } else {
                largura = Math.Sqrt(Convert.ToDouble(areaSuperficial / 5));
                comprimento = areaSuperficial / largura;
            }
        }

        public void CalculaKBT() {
            kbt = 0.55 * (Math.Pow(1.07, Convert.ToDouble(temperaturaLiquido - 20)));
        }

        public void CalculaA() {
            if (kbt == null) {
                CalculaKBT();
            }
            a = (1 + (4 * kbt * 4 * 3 * d));
        }

        public void CalculaConcentracaoColiformes() {
            if (a == null) {
                CalculaA();
            }
            coliformesFinais = coliformesIniciais * (4 * a * Math.Pow(Math.E, 1 / (2 * d))
                / (((Math.Pow(Convert.ToDouble(1 + a), 2)) * Math.Pow(Math.E, Convert.ToDouble(a / (2 * d)))) -
                (Math.Pow(Convert.ToDouble(1 - a), 2) * Math.Pow(Math.E, Convert.ToDouble(-a / (2 * d))))
                ));
        }

        public void CalculaEficiencia() {
            if (coliformesFinais == null) {
                CalculaConcentracaoColiformes();
            }
            eficienciaRemocaoColiMax = ((coliformesIniciais - coliformesFinais) / coliformesIniciais) * 100;
            dboSaida = dboEntrada;
        }

		public override void accept(Visitor v) {
			v.visit(this);
		}

		public double? Volume {
            get {
                return volume;
            }
        }

        public double? AreaSuperficial {
            get {
                return areaSuperficial;
            }
        }
        
        public double? AreaSuperficialTotal {
            get {
                return areaSuperficialTotal;
            }
        }

        public double? AreaRequerida {
            get {
                return areaRequerida;
            }
        }

        public double? Largura {
            get {
                return largura;
            }
        }

        public double? Comprimento {
            get {
                return comprimento;
            }
        }

        public double? ConcentracaoColiformesFinais {
            get {
                return coliformesFinais;
            }
        }

        public double? Eficiencia {
            get {
                return eficienciaRemocaoColiMax;
            }
        }

        public double? ColiformesInicias {
            set {
                coliformesIniciais = value;
            }
            get {
                return coliformesIniciais;
            }
        }

        public double? TemperaturaLiquido {
            set {
                temperaturaLiquido = value;
            }
            get {
                return temperaturaLiquido;
            }
        }
    }
}
