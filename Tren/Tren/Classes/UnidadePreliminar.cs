using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
    class UnidadePreliminar {

        private static double vazaoMax;
        private static double vazaoMed;
        private static double vazaoMin;
        private static double vazaoMaxFut;
        private static double vazaoMedFut;
        private static double vazaoMinFut;

        private static int populacao;
        private static int populacaoFut;
        private static double qpc;
        private static double extensaoRede;
        private static double extensaoRedeFut;
        private static double taxaInfiltracao;
        private static double taxaInfiltracaoFut;
        private static double vazaoInfiltracao;
        private static double vazaoInfiltracaoFut;
        private static double vazaoDomestica;
        private static double vazaoDomesticaFut;


		public UnidadePreliminar() { }

        public UnidadePreliminar(double vMax, double vMed, double vMin,
           double vMaxFut, double vMedFut, double vMinFut){

            vazaoMax = vMax;
            vazaoMed = vMed;
            vazaoMin = vMin;
            vazaoMaxFut = vMaxFut;
            vazaoMedFut = vMedFut;
            vazaoMinFut = vMinFut;
            populacao = 0;
            populacaoFut = 0;
        }

        public UnidadePreliminar(int pop, int popFut, double QPC, 
           double extensao, double extensaoFut, double taxaInf, double taxaInfFut){

            populacao = pop;
            populacaoFut = popFut;
            qpc = QPC;
            extensaoRede = extensao;
            extensaoRedeFut = extensaoFut;
            taxaInfiltracao = taxaInf;
            taxaInfiltracaoFut = taxaInfFut;

            calculaVazaoDomestica();
            calculaVazaoDomesticaFut();
            calculaVazaoInfiltracao();
            calculaVazaoInfiltracaoFut();
            calculaVazao();
            calculaVazaoFut();
        }

        public virtual void imprime(){
            try
            {
                Console.WriteLine("Ano       Populacao       Qmed       Qmin       Qmax");
                Console.WriteLine(DateTime.Now.Year + "       " + populacao + "       " + vazaoMed + 
                    "       " + vazaoMin + "       " + vazaoMax);
                Console.WriteLine((DateTime.Now.Year + 20) + "       " + populacaoFut + "       " + vazaoMedFut + "       " +
                    vazaoMinFut + "       " + vazaoMaxFut);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void calculaVazaoDomestica(){
            vazaoDomestica = (populacao * qpc * 0.8) / 86400;
        }

        public void calculaVazaoDomesticaFut(){
            vazaoDomesticaFut = (populacaoFut * qpc * 0.8) / 86400;
        }

        public void calculaVazaoInfiltracao(){
            vazaoInfiltracao = extensaoRede * taxaInfiltracao;
        }

        public void calculaVazaoInfiltracaoFut(){
            vazaoInfiltracaoFut = extensaoRedeFut * taxaInfiltracaoFut;
        }

        public void calculaVazao(){
            try
            {
                vazaoMed = Math.Round(vazaoDomestica + vazaoInfiltracao, 2);
                vazaoMax = Math.Round((1.2 * 1.5 * vazaoDomestica) + vazaoInfiltracao, 2);
                vazaoMin = Math.Round((0.5 * vazaoDomestica) + vazaoInfiltracao, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Vazoes Domesticas e de Infiltracao não calculadas");
            }
        }

        public void calculaVazaoFut(){
            try
            {
                vazaoMedFut = Math.Round(vazaoDomesticaFut + vazaoInfiltracaoFut, 2);
                vazaoMaxFut = Math.Round((1.2 * 1.5 * vazaoDomesticaFut) + vazaoInfiltracaoFut, 2);
                vazaoMinFut = Math.Round((0.5 * vazaoDomesticaFut) + vazaoInfiltracaoFut, 2);

            }
            catch (Exception e)
            {
                Console.WriteLine("Vazoes Domesticas e de Infiltracao não calculadas");
            }
        }

        public double VazaoMax { get { return vazaoMax; } }
        public double VazaoMin { get { return vazaoMin; } }
        public double VazaoMed { get { return vazaoMed; } }
        public double VazaoMaxFut { get { return vazaoMaxFut; } }
        public double VazaoMinFut { get { return vazaoMinFut; } }
        public double VazaoMedFut { get { return vazaoMedFut; } }
    }
}
