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
           double extensaoRede, double taxaInfiltracao, double taxaInfiltracaoFut){

            this.populacao = populacao;
            this.populacaoFut = populacaoFut;
            this.qpc = qpc;
            this.extensaoRede = extensaoRede;
            this.taxaInfiltracao = taxaInfiltracao;
            this.taxaInfiltracaoFut = taxaInfiltracaoFut;

            calculaVazaoDomestica(populacao, qpc);
            calculaVazaoDomesticaFut(populacaoFut, qpc);
            calculaVazaoInfiltracao(extensaoRede, taxaInfiltracao);
            calculaVazaoInfiltracaoFut(extensaoRede, taxaInfiltracaoFut);
            calculaVazao();
            calculaVazaoFut();
        }

        public void imprime(){
            try
            {
                Console.WriteLine("Ano       Populacao       Qmed       Qmin       Qmax");
                Console.WriteLine(DateTime.Now.Year + "       " + populacao + "       " + vazaoMed + "       " +
                    vazaoMin + "       " + vazaoMax);
                Console.WriteLine((DateTime.Now.Year + 20) + "       " + populacaoFut + "       " + vazaoMedFut + "       " +
                    vazaoMinFut + "       " + vazaoMaxFut);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERRO - As vazões não foram calculadas");
            }
        }

        public void calculaVazaoDomestica(int populacao, double qpc){
            this.vazaoDomestica = (populacao * qpc * 0.8) / 86400;
        }

        public void calculaVazaoDomesticaFut(int populacaoFut, double qpc){
            this.vazaoDomesticaFut = (populacaoFut * qpc * 0.8) / 86400;
        }

        public void calculaVazaoInfiltracao(double extensaoRede, double taxaInfiltracao){
            this.vazaoInfiltracao = extensaoRede * taxaInfiltracao;
        }

        public void calculaVazaoInfiltracaoFut(double extensaoRede, double taxaInfiltracaoFut){
            this.vazaoInfiltracaoFut = extensaoRede * taxaInfiltracaoFut;
        }

        public void calculaVazao(){
            try
            {
                vazaoMed = vazaoDomestica + vazaoInfiltracao;
                vazaoMax = (1.2 * 1.5 * vazaoDomestica) + vazaoInfiltracao;
                vazaoMin = (0.5 * vazaoDomestica) + vazaoInfiltracao;
            }
            catch (Exception e)
            {
                Console.WriteLine("Vazoes Domesticas e de Infiltracao não calculadas");
            }
        }

        public void calculaVazaoFut(){
            try
            {
                vazaoMedFut = vazaoDomesticaFut + vazaoInfiltracaoFut;
                vazaoMaxFut = (1.2 * 1.5 * vazaoDomesticaFut) + vazaoInfiltracaoFut;
                vazaoMinFut = (0.5 * vazaoDomesticaFut) + vazaoInfiltracaoFut;

            }
            catch (Exception e)
            {
                Console.WriteLine("Vazoes Domesticas e de Infiltracao não calculadas");
            }
        }
    }
}
