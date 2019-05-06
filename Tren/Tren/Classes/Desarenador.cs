using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
    class Desarenador : UnidadePreliminar
    {
        private double velocidadeEfluente;
        private double velocidadeTeste;
        private double larguraDesarenador;
        private double areaSecaoDesarenador;
        private double comprimentoDesarenador;
        private double areaSuperficial;
        private double taxaAplicacaoSueprficial;
        private int frequenciaLimpeza;
        private double volDiarioAreiaRetido;
        private double alturaGeradaAreiaDia;


        public Desarenador( double velocidadeEfluente, double alturaMax, double alturaMin,
            double vazaoMax, double vazaoMed, double vazaoMin, double vazaoMaxFut, double vazaoMedFut, double vazaoMinFut)
            : base(vazaoMax, vazaoMed, vazaoMin, vazaoMaxFut, vazaoMedFut, vazaoMinFut){

            this.velocidadeEfluente = velocidadeEfluente;
            calculaLarguraDesarenador(VazaoMaxFut, alturaMax, this.velocidadeEfluente);
            calculaAreaSecao(alturaMin);
            verificaVelocidade();
            calculaComprimento(alturaMax);
            calculaAreaSuperficial();
            calculaTaxaAplicacaoSuperficial();
            calculaFrequenciaLimpeza(0.9);
        }

        public Desarenador(double velocidadeEfluente, double alturaMax, double alturaMin,
            int populacao, int populacaoFut, double qpc, double extensaoRede, double extensaoRedeFut, double taxaInfiltracao, double taxaInfiltracaoFut)
            : base(populacao, populacaoFut, qpc, extensaoRede, extensaoRedeFut, taxaInfiltracao, taxaInfiltracaoFut){

            this.velocidadeEfluente = velocidadeEfluente;
            calculaLarguraDesarenador(VazaoMaxFut, alturaMax, this.velocidadeEfluente);
            calculaAreaSecao(alturaMin);
            verificaVelocidade();
            calculaComprimento(alturaMax);
            calculaAreaSuperficial();
            calculaTaxaAplicacaoSuperficial();
            calculaFrequenciaLimpeza(0.9);
        }

        public void calculaLarguraDesarenador(double vazaoMaxFut, double alturaMax, double velocidadeEfluente)
        {
            larguraDesarenador = (VazaoMaxFut / 1000) / (alturaMax * velocidadeEfluente);
        }

        public void calculaAreaSecao(double alturaMin) 
        {
            areaSecaoDesarenador = alturaMin * larguraDesarenador;
        }

        public void verificaVelocidade(){
            try
            {
                velocidadeTeste = (VazaoMinFut / 1000) / areaSecaoDesarenador;
                while(velocidadeTeste > 4){
                    Console.WriteLine("Calcule uma nova Largura para o Desarenador");
                    // fazer o calculo velocidadeTeste = (VazaoMin / 1000) / areaSecaoDesarenador;
                    velocidadeTeste = 3;
                }

            }catch(Exception)
            {
                Console.WriteLine("ERRO - Área da Seção do Canal não foi Calculado");
            }
        }

        public void calculaComprimento(double alturaMax)
        {
            comprimentoDesarenador = 22.5 * alturaMax;
        }

        public void calculaAreaSuperficial()
        {
            try
            {
                areaSuperficial = comprimentoDesarenador * larguraDesarenador;
            }
            catch (Exception e)
            {
                throw e.InnerException; 
            }
        }

        public void calculaTaxaAplicacaoSuperficial()
        {
            taxaAplicacaoSueprficial = (VazaoMaxFut / 1000) * areaSuperficial;

            // Falta fazer a verificação do VH
        }

        public void calculaFrequenciaLimpeza(double taxaDiariaAreia)
        {
            volDiarioAreiaRetido = (taxaDiariaAreia * 1000) * (VazaoMedFut/1000) * 86400;
            alturaGeradaAreiaDia = (volDiarioAreiaRetido / 1000) * areaSuperficial;
            frequenciaLimpeza = (int)Math.Round((0.2 * alturaGeradaAreiaDia));
        }




        public double VelocidadeEfluente
        {
            get
            {
                return velocidadeEfluente;
            }
            set
            {
                velocidadeEfluente = value;
            }
        }

        public override void imprime()
        {
            Console.WriteLine(larguraDesarenador);
            Console.WriteLine(velocidadeEfluente);
            Console.WriteLine(comprimentoDesarenador);
            Console.WriteLine(areaSuperficial);
            Console.WriteLine("Altura m");
            Console.WriteLine("Altura M");
            Console.WriteLine(taxaAplicacaoSueprficial);
            Console.WriteLine(alturaGeradaAreiaDia);
            Console.WriteLine(frequenciaLimpeza);
        }

        
    }
}
