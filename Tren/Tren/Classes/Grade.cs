using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
    class Grade : UnidadePreliminar
    {
        private IDictionary<string, string>[] tabelaGrade;
        private int? tipoGrade; // 1 = grossa; 2 = média; 3 = fina.
        private double? espessuraGrade;
        private double? espacamentoGrade;
        private int? tipoLimpeza; // 1 = mecanizada; 2 = manual.
        private double? velocidade; // 1.2 = mecanizada; 0.8 = manual.
        private double? velocidadeLinha;
        private double? eficienciaGrade;
        private double? areaUtilMax;
        private double? areaUtilMin;
        private double? secaoCanalMax;
        private double? larguraCanalMax;
        private double? secaoCanalMin;
        private double? larguraCanalMin;
        private double? velocidadeMin;
        private double? velocidadeAproxMax;
        private double? velocidadeAproxMin;
        private double? perdaCargaMax;
        private double? perdaCargaMin;
        private double? perdaCargaMaxObs;
        private double? perdaCargaMinObs;
        private double? perdaCargaTotal;
        private int? numeroBarras;
        private int? numeroEspacamentos;
        private double? correcaoBarraLateral;
        private double? difRetLateral;
        private double comprimentoGrade;


        public Grade(int espessura, int espacamento, int tipo)
        {
           
                espessuraGrade = espessura;
                espacamentoGrade = espacamento;
                if (tipo < 1 || tipo > 3)
                {
                    throw new Exception("Tipo informador diferente dos existentes");
                }
                else
                {
                    tipoGrade = tipo;
                }

            try
            {
                string[] linhas = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Tabelas Tren\grades.tren");
                tabelaGrade = new Dictionary<string, string>[linhas.Length];

                for (int i = 0; i < linhas.Length; i++)
                {
                    string[] aux = linhas[i].Split(' ');

                    tabelaGrade[i] = new Dictionary<string, string>();
                    tabelaGrade[i]["espMin"] = aux[0];
                    tabelaGrade[i]["espMax"] = aux[1];
                    tabelaGrade[i]["espMin"] = aux[2];
                    tabelaGrade[i]["espMax"] = aux[3];
                    tabelaGrade[i]["matMin"] = aux[4];
                    tabelaGrade[i]["matMax"] = aux[5];
                }
            }catch (Exception e)
            {
                // Tratar excessão de tentativa de acessar o arquivo
            }
        }

        public void calculoEficiencia()
        {
            eficienciaGrade = espacamentoGrade / (espacamentoGrade + espessuraGrade);
        }

        public void escolhaTipoLimpeza(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    tipoLimpeza = tipo;
                    velocidade = 1.2;
                    break;
                case 2:
                    tipoLimpeza = tipo;
                    velocidade = 0.8;
                    break;
                default:
                    throw new Exception("Tipo de grade não reconhecido!");
            }
        }

        public void calculaAreaUtil()
        {
            if (velocidade != null)
            {
                areaUtilMax = (VazaoMaxFut / 1000) / velocidade;
            }
            else
            {
                throw new Exception("Tipo de Limpeza não informada");
            }
        }

        public void calculaAreaUtilLinha()
        {
            if (velocidade != null)
            {
                areaUtilMin = (VazaoMinFut / 1000) / velocidade;
            }
            else
            {
                throw new Exception("Tipo de Limpeza não informada");
            }
        }
        public void calculaSecaoCanal()
        {
            if (areaUtilMax != null && eficienciaGrade != null)
            {
                secaoCanalMax = areaUtilMax / eficienciaGrade;
            }
            else
            {
                throw new Exception("Au e Eficiencia Não calculados");
            }
        }

        public void calculaLarguraCanal()
        {
            if (secaoCanalMax != null)
            {
                larguraCanalMax = secaoCanalMax;// Falta dividir pela altura da calha parhsall
            }
            else
            {
                throw new Exception("Seção do Canal não calculada.");
            }
        }

        public void calculaSecaoCanalLinha()
        {
            if (areaUtilMin != null && eficienciaGrade != null)
            {
                secaoCanalMin = areaUtilMin / eficienciaGrade;
            }
            else
            {
                throw new Exception("Au' e Eficiencia Não calculados");
            }
        }

        public void calculaLarguraCanalLinha()
        {
            if(secaoCanalMin != null)
            {
                larguraCanalMin = secaoCanalMin; // falta dividir pela altura da calha parshall
            }
            else
            {
                throw new Exception("S' não calculada.");
            }
        }

        public void calculaVelocidadeLinha()
        {
            if (areaUtilMin != null)
            {
                velocidadeLinha = VazaoMinFut / areaUtilMin;
            }
            else
            {
                throw new Exception("Au' não foi calculado.");
            }
        }

        public void calculaVelAproxMax()
        {
            if (eficienciaGrade != null && areaUtilMax != null)
            {
                velocidadeAproxMax = VazaoMaxFut / 1000 * eficienciaGrade / areaUtilMax;
            }
            else
            {
                throw new Exception("Eficiencia ou Au não foram calculados.");
            }
        }

        public void calculaVelAproxMin()
        {
            if (eficienciaGrade != null && areaUtilMin != null)
            {
                velocidadeAproxMin = VazaoMinFut / 1000 * eficienciaGrade / areaUtilMin;
            }
            else
            {
                throw new Exception("Eficiencia ou Au' não foram calculados.");
            }
        }

        public void calculaPerdaCarga()
        {
            if (velocidade != null && velocidadeAproxMax != null && velocidadeAproxMin != null && velocidadeLinha != null)
            {
                perdaCargaMax = 1.43 * ((velocidade * velocidade) - (velocidadeAproxMax * velocidadeAproxMax)) / 2 * g;
                perdaCargaMin = 1.43 * ((velocidadeLinha * velocidadeLinha) - (velocidadeAproxMin * velocidadeAproxMin)) / 2 * g;

                perdaCargaMaxObs = 1.43 * ((4 * velocidade * velocidade) - (velocidadeAproxMax * velocidadeAproxMax)) / 2 * g;
                perdaCargaMinObs = 1.43 * ((4 * velocidadeLinha * velocidadeLinha) - (velocidadeAproxMin * velocidadeAproxMin)) / 2 * g;
            }
            else
            {
                throw new Exception("Velocidades não calculadas.");
            }
        }

        public void calculaPerdaCargaTotal()
        {
            if (perdaCargaMaxObs != null)
            {
                perdaCargaTotal = perdaCargaMaxObs; // falta dividir pela altura da calha parshall
            }
            else
            {
                throw new Exception("Perda de Carga Obstruida não calculada.");
            }
        }

        public void calculaBarras()
        {
            if (larguraCanalMax != null)
            {
                double? b = (larguraCanalMax - espacamentoGrade) / (espacamentoGrade + espessuraGrade);
                numeroBarras = Convert.ToInt32(Math.Round( Convert.ToDouble(Convert.ToString(b)), MidpointRounding.AwayFromZero));
                numeroEspacamentos = numeroBarras + 1;
            }
            else
            {
                throw new Exception("Largura do Canal não calculada.");
            }
        }

        public void calculaCorrecaoEspaco()
        {
            if (numeroBarras != null)
                correcaoBarraLateral = (espacamentoGrade * numeroEspacamentos) + (espessuraGrade * numeroBarras) - larguraCanalMax;
            else
                throw new Exception("Numero de Barras não calculado.");
        }

        public void calculaDiferencaEspaco()
        {
            if (correcaoBarraLateral != null)
            {
                difRetLateral = (espacamentoGrade - correcaoBarraLateral) / 2;
            }
            else
            {
                throw new Exception("Correção dos espaços laterais não calculado.");
            }
        }

        public void calculaComprimento()
        {
            if (perdaCargaTotal != null) {
                switch (tipoLimpeza) {
                    case 1:
                        comprimentoGrade = Convert.ToDouble(Convert.ToString(perdaCargaTotal)) / Math.Sin(a: Math.PI/3);
                        break;
                    case 2:
                        comprimentoGrade = Convert.ToDouble(Convert.ToString(perdaCargaTotal)) / Math.Sin(a: 7 * Math.PI / 18);
                        break;
                    default:
                        throw new Exception("Tipo de Grade não selecionado.");
                }
            }
        }

    }
}
