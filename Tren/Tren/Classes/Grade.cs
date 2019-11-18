using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes
{
    public class Grade : UnidadePreliminar {
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
        private int? numeroBarrasMin = null;
        private int? numeroEspacamentos = null;
        private int? numeroEspacamentosMin = null;
        private double? correcaoBarraLateral = null;
        private double? correcaoBarraLateralMin = null;
        private double? difRetLateral = null;
        private double? difRetLateralMin = null;
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

        public Grade(SequenciaPreliminar sp) : base(sp) {
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

        public int? TipoGrade {
            set {
                if(value > 3 || value < 1) {
                    throw new Exception("Tipo de grade informado não cadastrado.");
                } else {
                    tipoGrade = value;
                }
            }
        }

        public int? TipoLimpeza {
            set {
                if (value != 1 && value != 2) {
                    throw new Exception("Tipo de limpeza diferente dos existentes.");
                } else {
                    tipoLimpeza = value;
                    if (value == 1) velocidade = 1.2;
                    else velocidade = 0.8;
                }
            }
            get {
                return tipoLimpeza;
            }
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
                areaUtilMin = (getPertenceASeq.getCentral.getVazaoMin / 1000) / velocidade;
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
            if (secaoCanalMin != null && getPertenceASeq.gethMax != null) {
                larguraCanalMin = secaoCanalMin / getPertenceASeq.gethMax;
            } else {
                throw new Exception("S' ou Altura mínima não calculadas.");
            }
        }

        public void CalculaVelocidadeLinha() {
            if (areaUtilMin != null && getPertenceASeq.getCentral.getVazaoMin != null) {
                velocidadeLinha = getPertenceASeq.getCentral.getVazaoMin / 1000 / areaUtilMin;
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
            if (eficienciaGrade != null && areaUtilMin != null && getPertenceASeq.getCentral.getVazaoMin != null) {
                velocidadeAproxMin = getPertenceASeq.getCentral.getVazaoMin / 1000 * eficienciaGrade / areaUtilMin;
            } else {
                throw new Exception("Eficiencia, Au' ou Vazão não foram calculados.");
            }
        }

        public void CalculaPerdaCarga() {
            if (velocidade != null && velocidadeAproxMax != null && velocidadeAproxMin != null && velocidadeLinha != null) {
                perdaCargaMax = (1.43 * (Math.Pow(Convert.ToDouble(velocidade), 2) - Math.Pow(Convert.ToDouble(velocidadeAproxMax), 2))) / (2 * 9.81);
                perdaCargaMin = (1.43 * (Math.Pow(Convert.ToDouble(velocidadeLinha), 2) - Math.Pow(Convert.ToDouble(velocidadeAproxMin), 2))) / (2 * 9.81);

                perdaCargaMaxObs = (1.43 * (Math.Pow(Convert.ToDouble(2*velocidade), 2) - Math.Pow(Convert.ToDouble(velocidadeAproxMax), 2))) / (2 * 9.81);
                perdaCargaMinObs = (1.43 * (Math.Pow(Convert.ToDouble(2*velocidadeLinha), 2) - Math.Pow(Convert.ToDouble(velocidadeAproxMin), 2))) / (2 * 9.81);
            } else {
                throw new Exception("Velocidades não calculadas.");
            }
        }

        public void CalculaPerdaCargaTotal() {
            if (perdaCargaMaxObs != null && getPertenceASeq.gethMax != null) {
                perdaCargaTotal = perdaCargaMaxObs + getPertenceASeq.gethMax;
            } else {
                throw new Exception("Perda de Carga Obstruida não calculada.");
            }
        }

        public void CalculaBarras() {
            if (larguraCanalMax != null || larguraCanalMin != null) {
                double? b = (larguraCanalMax * 1000 - espacamentoGrade) / (espacamentoGrade + espessuraGrade);
                numeroBarras = int.Parse(Convert.ToString(Math.Round(Convert.ToDouble(b))));
                numeroEspacamentos = numeroBarras + 1;

                double? c = (larguraCanalMin * 1000 - espacamentoGrade) / (espacamentoGrade + espessuraGrade);
                numeroBarrasMin = int.Parse(Convert.ToString(Math.Round(Convert.ToDouble(c))));
                numeroEspacamentosMin = numeroBarrasMin + 1;
            } else {
                throw new Exception("Largura do Canal não calculada.");
            }
        }

        public void CalculaCorrecaoEspaco() {
            if (numeroBarras != null || numeroBarrasMin != null) {
                correcaoBarraLateral = (espacamentoGrade * numeroEspacamentos) + (espessuraGrade * numeroBarras) - (larguraCanalMax * 1000);
                correcaoBarraLateralMin = (espacamentoGrade * numeroEspacamentosMin) + (espessuraGrade * numeroBarrasMin) - (larguraCanalMin * 1000);
            } else
                throw new Exception("Numero de Barras não calculado.");
        }

        public void CalculaDiferencaEspaco() {
            if (correcaoBarraLateral != null || correcaoBarraLateralMin != null) {
                difRetLateralMin = (espacamentoGrade - correcaoBarraLateralMin) / 2;
                difRetLateral = (espacamentoGrade - correcaoBarraLateral) / 2;
            } else {
                throw new Exception("Correção dos espaços laterais não calculado.");
            }
        }

        public void CalculaComprimento() {
            if (perdaCargaTotal != null) {
                switch (tipoLimpeza) {
                    case 1:
                        comprimentoGrade = Convert.ToDouble(perdaCargaTotal) / Math.Sin(a: 7 * Math.PI / 18);
                        break;
                    case 2:
                        comprimentoGrade = Convert.ToDouble(perdaCargaTotal) / Math.Sin(a: Math.PI / 3);
                        break;
                    default:
                        throw new Exception("Tipo de Grade não selecionado.");
                }
            }
        }

		public override void accept(Visitor v) {
			v.visit(this);
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
        
        public int? NumEspacamentoMin {
            get {
                return numeroEspacamentosMin;
            }
        }
        public double? Espacamento {
            get{
                return espacamentoGrade;
            }
            set {
                espacamentoGrade = value;
            }
        }
        public double? Espessura {
            get {
                return espessuraGrade;
            }
            set {
                espessuraGrade = value;
            }
        }

        public double? Eficiencia {
            get {
                return eficienciaGrade;
            }
        }

        public double? CorrecaoEspacamento {
            get {
                return correcaoBarraLateral;
            }
        }

        public double? CorrecaoEspacamentoMin {
            get {
                return correcaoBarraLateralMin;
            }
        }

        public double? DiferencaEspacoLateral {
            get {
                return difRetLateral;
            }
        }

        public double? DiferencaEspacoLateralMin {
            get {
                return difRetLateralMin;
            }
        }

        public double? Comprimento {
            get {
                return comprimentoGrade;
            }
        }

        public double? LarguraMax {
            get {
                return larguraCanalMax;
            }
        }

        public double? LarguraMin {
            get {
                return larguraCanalMin;
            }
        }

        public IDictionary<string, string>[] Tabela {
            get {
                return tabelaGrade;
            }
        }

    }
}
