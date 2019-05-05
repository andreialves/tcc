using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
    class UnidadePreliminar {

        private double vazaoMax;
        private double vazaoMed;
        private double vazaoMin;
        private double vazaoMaxFut;
        private double vazaoMedFut;
        private double vazaoMinFut;

        private int populacao;
        private int populacaoFut;
        private double qpc;
        private double extensaoRede;
        private double extensaoRedeFut;
        private double taxaInfiltracao;
        private double taxaInfiltracaoFut;
        private double vazaoInfiltracao;
        private double vazaoInfiltracaoFut;
        private double vazaoDomestica;
        private double vazaoDomesticaFut;

        public UnidadePreliminar(double vazaoMax, double vazaoMed, double vazaoMin,
           double vazaoMaxFut, double vazaoMedFut, double vazaoMinFut){

            this.vazaoMax = vazaoMax;
            this.vazaoMed = vazaoMed;
            this.vazaoMin = vazaoMin;
            this.vazaoMaxFut = vazaoMaxFut;
            this.vazaoMedFut = vazaoMedFut;
            this.vazaoMinFut = vazaoMinFut;
            this.populacao = 0;
            this.populacaoFut = 0;
        }

       public UnidadePreliminar(int populacao, int populacaoFut, double qpc, 
           double extensaoRede, double extensaoRedeFut, double taxaInfiltracao, double taxaInfiltracaoFut){

            this.populacao = populacao;
            this.populacaoFut = populacaoFut;
            this.qpc = qpc;
            this.extensaoRede = extensaoRede;
            this.extensaoRedeFut = extensaoRedeFut;
            this.taxaInfiltracao = taxaInfiltracao;
            this.taxaInfiltracaoFut = taxaInfiltracaoFut;

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
                Console.WriteLine("ERRO - As vazões não foram calculadas");
            }
        }

        public void calculaVazaoDomestica(){
            this.vazaoDomestica = (populacao * qpc * 0.8) / 86400;
        }

        public void calculaVazaoDomesticaFut(){
            this.vazaoDomesticaFut = (populacaoFut * qpc * 0.8) / 86400;
        }

        public void calculaVazaoInfiltracao(){
            this.vazaoInfiltracao = extensaoRede * taxaInfiltracao;
        }

        public void calculaVazaoInfiltracaoFut(){
            this.vazaoInfiltracaoFut = extensaoRedeFut * taxaInfiltracaoFut;
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
