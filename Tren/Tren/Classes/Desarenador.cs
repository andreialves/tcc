using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Tren.Interfaces;

namespace Tren.Classes {
    public class Desarenador : UnidadePreliminar {
        IFormatProvider format = CultureInfo.InvariantCulture;

        private double? velocidadeEfluente = null;
        private double? velocidadeTeste = null;
        private double? larguraDesarenador = null;
        private double? areaSecaoDesarenador = null;
        private double? comprimentoDesarenador = null;
        private double? areaSuperficial = null;
        private double? taxaAplicacaoSueprficial = null;
        private double? frequenciaLimpeza = null;
        private double? volDiarioAreiaRetido = null;
        private double? alturaGeradaAreiaDia = null;
        private double? taxaAreiaDiaria = null;


        // Construtores do Desarenador

        public Desarenador(double velocidadeEfluente, double taxaAreiaDiaria, SequenciaPreliminar sp) : base(sp) {
            if (velocidadeEfluente > 0.4 || velocidadeEfluente < 0.2) {
                throw new Exception("Velocidade Fora do Intervalo.");
            } else {
                this.velocidadeEfluente = velocidadeEfluente;
                this.taxaAreiaDiaria = taxaAreiaDiaria;
            }
        }

        public Desarenador(SequenciaPreliminar sp) : base(sp) {

        }
        public double? VelocidadeEfluente {
            set {
                if (value > 0.4 || value < 0.2)
                    throw new Exception("Velocidade Fora do Intervalo.");
                else
                    velocidadeEfluente = value;
            }
        }

        public double? TaxaAreiaDiaria {
            set {
                taxaAreiaDiaria = value;
            }
        }
        // Calcula a largura do desarenador
        public void CalculaLarguraDesarenador() {

            larguraDesarenador = (getPertenceASeq.getCentral.getVazaoMaxFut / 1000) / (getPertenceASeq.gethMax * velocidadeEfluente);

        }

        // Calcula a area da seção do canal
        public void CalculaAreaSecao() {

            areaSecaoDesarenador = getPertenceASeq.gethMin * larguraDesarenador;

        }

        //Calcula o comprimento do desarenador
        public void CalculaComprimento() {

            comprimentoDesarenador = 22.5 * getPertenceASeq.gethMax;

        }

        // Calcula a area superficial do Desarenador
        public void calculaAreaSuperficial() {

            areaSuperficial = comprimentoDesarenador * larguraDesarenador;

        }

        // Função para verificar se a velocidade escolhida pelo usuário é correta.
        public bool VerificaVH() {
            if (CalculaVelocidadeTeste(0.2) && CalculaVelocidadeTeste(0.4)) {
                throw new Exception("Impossível Dimensionar essa unidade para esses dados.");
            } else if (areaSecaoDesarenador == 0) {
                throw new Exception("Area da Seção do Desarenador não calculada.");
            } else {
                velocidadeTeste = getPertenceASeq.getCentral.getVazaoMinFut / 1000 / areaSecaoDesarenador;
                return velocidadeTeste > 4;
            }
        }

        public bool VerificaTAS() {

            return taxaAplicacaoSueprficial <= 1300 && taxaAplicacaoSueprficial >= 600;

        }

        public void CalculaTAS() {

            taxaAplicacaoSueprficial = getPertenceASeq.getCentral.getVazaoMaxFut / 1000 / areaSuperficial;

        }

        // Corrige a velocidade do efluente
        public void corrigeVelocidade(double vh) {
            if (vh < 0.2 || vh > 0.4) {
                throw new Exception("Velocidade fora do intervalo.");
            } else {
                velocidadeEfluente = vh;
                CalculaLarguraDesarenador();
                CalculaAreaSecao();
            }
        }

        public void calculaFrequenciaLimpeza() {
            volDiarioAreiaRetido = taxaAreiaDiaria * (getPertenceASeq.getCentral.getVazaoMedFut / 1000) * 86400;
            alturaGeradaAreiaDia = (volDiarioAreiaRetido / 1000) / areaSuperficial;
            frequenciaLimpeza = Math.Round(Convert.ToDouble(0.2 / alturaGeradaAreiaDia), MidpointRounding.ToEven);
        }
        
        /**
         * 
         * Função para verificar se a velocidade informada é menor que o recomendado pela norma
         * 
        **/
        private bool CalculaVelocidadeTeste(double? velocidade) {
            double? largura, area, vh;
            largura = (getPertenceASeq.getCentral.getVazaoMaxFut / 1000) / (getPertenceASeq.gethMax * velocidade);
            area = getPertenceASeq.gethMin * largura;
            vh = getPertenceASeq.getCentral.getVazaoMinFut / 1000 / area;

            return vh > 4;
        }

		public override void accept(Visitor v) {
			v.visit(this);
		}

		public double? Largura {
            get{ return larguraDesarenador; }
        }

        public double? Velocidade {
            get { return velocidadeEfluente; }
        }

        public double? Comprimento {
            get { return comprimentoDesarenador; }
        }

        public double? AreaSuperficial {
            get { return areaSuperficial; }
        }

        public double? TaxaAplicacao {
            get { return taxaAplicacaoSueprficial; }
        }

        public double? AlturaAreia {
            get { return alturaGeradaAreiaDia; }
        }

        public double? IntervaloLimpeza {
            get { return frequenciaLimpeza; }
        }

        public double? AreaSecao {
            get { return areaSecaoDesarenador; }
        }
        
        public double? VolumeDiario {
            get { return volDiarioAreiaRetido; }
        }
    }
}
