using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
    class Grade : UnidadePreliminar {
        private IDictionary<string, string>[] tabelaGrade;
        private int? tipoGrade = null; // 1 = grossa; 2 = média; 3 = fina.
        private double? espessuraGrade = null;
        private double? espacamentoGrade = null;
        private int? tipoLimpeza = null; // 1 = mecanizada; 2 = manual.
        private double? velocidade = null; // 1.2 = mecanizada; 0.8 = manual.
        private double? velocidadeLinha = null;
        private double? eficienciaGrade = null;
        private double? areaUtilMax = null;
        private double? areaUtilMin = null;
        private double? secaoCanalMax = null;
        private double? larguraCanalMax = null;
        private double? secaoCanalMin = null;
        private double? larguraCanalMin = null;
        private double? velocidadeAproxMax = null;
        private double? velocidadeAproxMin = null;
        private double? perdaCargaMax = null;
        private double? perdaCargaMin = null;
        private double? perdaCargaMaxObs = null;
        private double? perdaCargaMinObs = null;
        private double? perdaCargaTotal = null;
        private int? numeroBarras = null;
        private int? numeroEspacamentos = null;
        private double? correcaoBarraLateral = null;
        private double? difRetLateral = null;
        private double? comprimentoGrade = null;


        public Grade(double espessura, double espacamento, int tipo, int tipoLimpeza, SequenciaPreliminar sp) : base(sp) {
            espessuraGrade = espessura;
            espacamentoGrade = espacamento;
            if (tipo < 1 || tipo > 3) {
                throw new Exception("Tipo de grade informador diferente dos existentes.");
            } else {
                tipoGrade = tipo;
            }

            if (tipoLimpeza != 1 && tipoLimpeza != 2) {
                throw new Exception("Tipo de limpeza diferente dos existentes.");
            } else {
                this.tipoLimpeza = tipoLimpeza;
                if (tipoLimpeza == 1) velocidade = 1.2;
                else velocidade = 0.8;
            }

            try {
                string[] linhas = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Tabelas Tren\grades.tren");
                tabelaGrade = new Dictionary<string, string>[linhas.Length];

                for (int i = 0; i < linhas.Length; i++) {
                    string[] aux = linhas[i].Split(' ');

                    tabelaGrade[i] = new Dictionary<string, string>();
                    tabelaGrade[i]["espMin"] = aux[0];
                    tabelaGrade[i]["espMax"] = aux[1];
                    tabelaGrade[i]["espMin"] = aux[2];
                    tabelaGrade[i]["espMax"] = aux[3];
                    tabelaGrade[i]["matMin"] = aux[4];
                    tabelaGrade[i]["matMax"] = aux[5];
                }
            } catch (Exception e) {
                // Tratar excessão de tentativa de acessar o arquivo
            }
        }

        public void CalculoEficiencia() {

            eficienciaGrade = espacamentoGrade / (espacamentoGrade + espessuraGrade);

        }

        public void CalculaAreaUtil() {
            if (velocidade != null) {
                areaUtilMax = (getPertenceASeq.getCentral.getVazaoMaxFut / 1000) / velocidade;
            } else {
                throw new Exception("Tipo de Limpeza não informada");
            }
        }

        public void CalculaAreaUtilLinha() {
            if (velocidade != null) {
                areaUtilMin = (getPertenceASeq.getCentral.getVazaoMinFut / 1000) / velocidade;
            } else {
                throw new Exception("Tipo de Limpeza não informada");
            }
        }
        public void CalculaSecaoCanal() {
            if (areaUtilMax != null && eficienciaGrade != null) {
                secaoCanalMax = areaUtilMax / eficienciaGrade;
            } else {
                throw new Exception("Au e Eficiencia Não calculados");
            }
        }

        public void CalculaLarguraCanal() {
            if (secaoCanalMax != null && getPertenceASeq.gethMax != null) {
                larguraCanalMax = secaoCanalMax / getPertenceASeq.gethMax;
            } else {
                throw new Exception("Seção do Canal não calculada ou Altura não calculada.");
            }
        }

        public void CalculaSecaoCanalLinha() {
            if (areaUtilMin != null && eficienciaGrade != null) {
                secaoCanalMin = areaUtilMin / eficienciaGrade;
            } else {
                throw new Exception("Au' e Eficiencia Não calculados");
            }
        }

        public void CalculaLarguraCanalLinha() {
            if (secaoCanalMin != null && getPertenceASeq.gethMin != null) {
                larguraCanalMin = secaoCanalMin / getPertenceASeq.gethMin;
            } else {
                throw new Exception("S' ou Altura mínima não calculadas.");
            }
        }

        public void CalculaVelocidadeLinha() {
            if (areaUtilMin != null && getPertenceASeq.getCentral.getVazaoMinFut != null) {
                velocidadeLinha = getPertenceASeq.getCentral.getVazaoMinFut / areaUtilMin;
            } else {
                throw new Exception("Au' ou Vazão não foram calculados.");
            }
        }

        public void CalculaVelAproxMax() {
            if (eficienciaGrade != null && areaUtilMax != null && getPertenceASeq.getCentral.getVazaoMaxFut != null) {
                velocidadeAproxMax = getPertenceASeq.getCentral.getVazaoMaxFut / 1000 * eficienciaGrade / areaUtilMax;
            } else {
                throw new Exception("Eficiencia, Au ou Vazão não foram calculados.");
            }
        }

        public void CalculaVelAproxMin() {
            if (eficienciaGrade != null && areaUtilMin != null && getPertenceASeq.getCentral.getVazaoMinFut != null) {
                velocidadeAproxMin = getPertenceASeq.getCentral.getVazaoMinFut / 1000 * eficienciaGrade / areaUtilMin;
            } else {
                throw new Exception("Eficiencia, Au' ou Vazão não foram calculados.");
            }
        }

        public void CalculaPerdaCarga() {
            if (velocidade != null && velocidadeAproxMax != null && velocidadeAproxMin != null && velocidadeLinha != null) {
                perdaCargaMax = 1.43 * ((velocidade * velocidade) - (velocidadeAproxMax * velocidadeAproxMax)) / 2 * 9.81;
                perdaCargaMin = 1.43 * ((velocidadeLinha * velocidadeLinha) - (velocidadeAproxMin * velocidadeAproxMin)) / 2 * 9.81;

                perdaCargaMaxObs = 1.43 * ((4 * velocidade * velocidade) - (velocidadeAproxMax * velocidadeAproxMax)) / 2 * 9.81;
                perdaCargaMinObs = 1.43 * ((4 * velocidadeLinha * velocidadeLinha) - (velocidadeAproxMin * velocidadeAproxMin)) / 2 * 9.81;
            } else {
                throw new Exception("Velocidades não calculadas.");
            }
        }

        public void CalculaPerdaCargaTotal() {
            if (perdaCargaMaxObs != null && getPertenceASeq.gethMax != null) {
                perdaCargaTotal = perdaCargaMaxObs / getPertenceASeq.gethMax;
            } else {
                throw new Exception("Perda de Carga Obstruida não calculada.");
            }
        }

        public void CalculaBarras() {
            if (larguraCanalMax != null) {
                double? b = (larguraCanalMax - espacamentoGrade) / (espacamentoGrade + espessuraGrade);
                numeroBarras = int.Parse(Convert.ToString(Math.Round(Convert.ToDouble(b + 0.5), MidpointRounding.ToEven)));
                numeroEspacamentos = numeroBarras + 1;
            } else {
                throw new Exception("Largura do Canal não calculada.");
            }
        }

        public void CalculaCorrecaoEspaco() {
            if (numeroBarras != null)
                correcaoBarraLateral = (espacamentoGrade * numeroEspacamentos) + (espessuraGrade * numeroBarras) - larguraCanalMax;
            else
                throw new Exception("Numero de Barras não calculado.");
        }

        public void CalculaDiferencaEspaco() {
            if (correcaoBarraLateral != null) {
                difRetLateral = (espacamentoGrade - correcaoBarraLateral) / 2;
            } else {
                throw new Exception("Correção dos espaços laterais não calculado.");
            }
        }

        public void CalculaComprimento() {
            if (perdaCargaTotal != null) {
                switch (tipoLimpeza) {
                    case 1:
                        comprimentoGrade = Convert.ToDouble(perdaCargaTotal) / Math.Sin(a: Math.PI / 3);
                        break;
                    case 2:
                        comprimentoGrade = Convert.ToDouble(perdaCargaTotal) / Math.Sin(a: 7 * Math.PI / 18);
                        break;
                    default:
                        throw new Exception("Tipo de Grade não selecionado.");
                }
            }
        }

        public double? SecaoCanalMax {
            get {
                return secaoCanalMax;
            }
        }

        public double? SecaoCanalMin {
            get {
                return secaoCanalMin;
            }
        }

        public double? AreaUtilMax {
            get {
                return areaUtilMax;
            }
        }
        public double? AreaUtilMin {
            get {
                return areaUtilMin;
            }
        }

        public double? VelocidadeInformada {
            get {
                return velocidade;
            }
        }

        public double? VelocidadeLinha {
            get {
                return velocidadeLinha;
            }
        }

        public double? VelocidadeAproximacaoMax {
            get {
                return velocidadeAproxMax;
            }
        }

        public double? VelocidadeAproximacaoMin {
            get {
                return velocidadeAproxMin;
            }
        }

        public double? PerdaCargaMax {
            get {
                return perdaCargaMax;
            }
        }

        public double? PerdaCargaMin {
            get {
                return perdaCargaMin;
            }
        }

        public double? PerdaCargaMaxObs {
            get {
                return perdaCargaMaxObs;
            }
        }

        public double? PerdaCargaMinObs {
            get {
                return perdaCargaMinObs;
            }
        }

        public double? PerdaCargaTotal {
            get {
                return perdaCargaTotal;
            }
        }

        public int? NumEspacamento {
            get {
                return numeroEspacamentos;
            }
        }

        public double? CorrecaoEspacamento {
            get {
                return correcaoBarraLateral;
            }
        }

        public double? DiferencaEspacoLateral {
            get {
                return difRetLateral;
            }
        }

        public double? Comprimento {
            get {
                return comprimentoGrade;
            }
        }

        public IDictionary<string, string>[] Tabela {
            get {
                return tabelaGrade;
            }
        }
    }
}
