using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes {
    public class ReatorUASB : UnidadeSecundaria {

        private double? dbo = null;
        private double? dqo = null;
        private double? sst = null;
        private double? tempMesFrio = null;
        private double? cargaDQODiaria = null;
        private int? tempoDetHidraulica = null;
        private double? volumeTotalReatores = null;
        private int? minimoReatores = null;
        private double? volumeUtilReator = null;
        private double? areaTransversalReator = null;
        private double? areaTotal = null;
        private double? prodMassaLodo = null;
        private double? dqoEnt = null;
        private double? dboSai = null;
        private double? dqoSai = null;
        private double? dqoEntradaAjustada = null;
        private double? dqoSaidaAjustada = null;
        private double? cargaConvertidaMetano = null;
        private double? fatorCorrecaoTemp = null;
        private double? conversaoMassaMetano = null;
        private double? producaoBiogas = null;

        public ReatorUASB(double dbo, double dqo, double sst, double tempMesFrio, SequenciaSecundaria ss) : base(ss) {
            this.dbo = dbo;
            this.dqo = dqo;
            this.tempMesFrio = tempMesFrio;

            calculaTDH();

        }

        public ReatorUASB (SequenciaSecundaria ss) : base(ss) {   }

        public void calculaTDH() {
            try {
                if (tempMesFrio < 18) { tempoDetHidraulica = 10; } else if (tempMesFrio < 22 && tempMesFrio >= 18) { tempoDetHidraulica = 8; } else if (tempMesFrio < 25 && tempMesFrio >= 22) { tempoDetHidraulica = 7; } else if (tempMesFrio >= 25) { tempoDetHidraulica = 6; }
            } catch (Exception) {
                throw new Exception("Reator UASB: Temperatura do Mês mais frio não informada!");
            }
        }
        
        public void calculaCargaDQO() {
            try {
                cargaDQODiaria = (dqo * getPertenceASeq.getCentral.getPopulacaoFut) / 1000;
            }catch (Exception) {
                throw new Exception("Reator UASB: População não informada!");
            }
        }

        public void calculaVolumeTotal() {
            try {
                volumeTotalReatores = (getPertenceASeq.getCentral.getVazaoMaxFut) * (tempoDetHidraulica / 24);
            }catch (Exception) {
                throw new Exception("Reator UASB: Vazão máxima futura não foi calculada!");
            }
        }

        public void calculaReatores() {
            try {
                minimoReatores = int.Parse(Convert.ToString(Math.Round(Convert.ToDouble(volumeTotalReatores / 2000)+0.5)));
            } catch (Exception) {
                throw new Exception("Reator UASB: Volume total dos reatores não foi calculada!");
            }
        }

        public void calculaVolumeUtil() {
            try {
                volumeUtilReator = volumeTotalReatores / minimoReatores;
            } catch (Exception) {
                throw new Exception("Reator UASB: Volume total ou número de retores não calculados!");
            }
        }

        public void calculaAreaTransversal() {
            try {
                areaTransversalReator = volumeUtilReator / 5;
            } catch (Exception) {
                throw new Exception("Reator UASB: Volume útil dos reatores não calculado!");
            }
        }

        public void calculaAreaTotal() {
            try {
                areaTotal = areaTransversalReator * minimoReatores;
            } catch (Exception) {
                throw new Exception("Reator UASB: Área Trasversal não calculada!");
            }
        }

        public void calculaLodoGerado() {
            try {
                prodMassaLodo = (0.18 * cargaDQODiaria) / (1020 * 0.04);
            } catch (Exception) {
                throw new Exception("Reator UASB: Carga de DQO diária não calculada!");
            }
        }

        public void calculaEficienciaRemocao() {
            try {
                dboEntrada = Convert.ToDouble(dbo / getPertenceASeq.getCentral.getQPC) / 1000;
                dqoEnt = (dqo / getPertenceASeq.getCentral.getQPC) / 1000;
                dboSaida = (0.35 * dboEntrada);
                dqoSai = (0.30 * dqoEnt);
            } catch (Exception) {
                throw new Exception("Reator UASB: População não informada!");
            }
        }

        public void ajustaDQO() {
            try {
                dqoEntradaAjustada = dqoEnt * 1000;
                dqoSaidaAjustada = dqoSai * 1000;
            } catch (Exception) {
                throw new Exception("Reator UASB: DQO de entrada e de saída não calculados!");
            }
        }

        public void calculaCargaDQOEstimado() {
            try {
                cargaConvertidaMetano = (getPertenceASeq.getCentral.getVazaoMed * (dqoEntradaAjustada - dqoSaidaAjustada))
                                        - (0.11 * (getPertenceASeq.getCentral.getVazaoMed * dqoEntradaAjustada));
            } catch (Exception) {
                throw new Exception("Reator UASB: DQO não ajustado!");
            }
        }

        public void calculaFatorCorrecao() {
                fatorCorrecaoTemp = (64) / (0.08206 * (273 + tempMesFrio));
        }

        public void converteMassaMetano() {
            try {
                conversaoMassaMetano = cargaConvertidaMetano / fatorCorrecaoTemp;
            } catch (Exception) {
                throw new Exception("Reator UASB: Carga de DQO ou Fator de Correcao de Temperatura não calculado!");
            }
        }

        public void calculaBiogas() {
            try {
                producaoBiogas = conversaoMassaMetano / 0.7;
            } catch (Exception) {
                throw new Exception("Reator UASB: Conversão de Massa de Metano em Produção Volumetrica não realizada!");
            }
        }

        public double? VolumeTotal {
            get {
                return volumeTotalReatores;
            }
        }
        
        public double? AreaRequerida {
            get {
                return areaTotal;
            }
        }

        public int? NumReatores {
            get {
                return minimoReatores;
            }
        }

        public double? ProducaoLodo {
            get {
                return prodMassaLodo;
            }
        }

        public double? ProducaoGas {
            get {
                return producaoBiogas;
            }
        }

        public double? DboFinal {
            get {
                return dboSai;
            }
        }

        public double? DqoFinal {
            get {
                return dqoSai;
            }
        }

        public int? detencaoHidraulica {
            get {
                return tempoDetHidraulica;
            }
        }

        public double? dboSet {
            set {
                dbo = value;
            }
        }

        public double? dqoSet {
            set {
                dqo = value;
            }
        }

        public double? sstSet {
            set {
                sst = value;
            }
        }

        public double? temp {
            set {
                tempMesFrio = value;
            }
        }

        public override void accept(Visitor v) {
            v.visit(this);
        }

        public void print() {
            Console.WriteLine(getPertenceASeq.getCentral.getQPC);
            Console.WriteLine(dbo);
            Console.WriteLine(dqo);
            Console.WriteLine(cargaDQODiaria);
            Console.WriteLine(volumeTotalReatores);

            
        }
    }
}
