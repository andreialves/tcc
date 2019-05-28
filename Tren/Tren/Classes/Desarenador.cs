using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tren.Classes
{
    class Desarenador : UnidadePreliminar
    {
        IFormatProvider format = CultureInfo.InvariantCulture;
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


        // Calculo da altura provisório
        private double alturaMin;
        private double alturaMax;
      

        // Construtores do Desarenador

        public Desarenador(double velocidadeEfluente, double alturaMax, double alturaMin)
        {
            this.velocidadeEfluente = velocidadeEfluente;
            calculaLarguraDesarenador(VazaoMaxFut, alturaMax, this.velocidadeEfluente);
            calculaAreaSecao(alturaMin);

            corrigeVelocidade(velocidadeEfluente);


            calculaComprimento(alturaMax);
            calculaAreaSuperficial();
            calculaTaxaAplicacaoSuperficial();
            calculaFrequenciaLimpeza(0.9);



            this.alturaMin = alturaMin;
            this.alturaMax = alturaMax;
        }

        public Desarenador( double velocidadeEfluente, double alturaMax, double alturaMin,
            double vazaoMax, double vazaoMed, double vazaoMin, double vazaoMaxFut, double vazaoMedFut, double vazaoMinFut)
            : base(vazaoMax, vazaoMed, vazaoMin, vazaoMaxFut, vazaoMedFut, vazaoMinFut){

            this.velocidadeEfluente = velocidadeEfluente;
            calculaLarguraDesarenador(VazaoMaxFut, alturaMax, this.velocidadeEfluente);
            calculaAreaSecao(alturaMin);
            
            corrigeVelocidade(velocidadeEfluente);

           
            calculaComprimento(alturaMax);
            calculaAreaSuperficial();
            calculaTaxaAplicacaoSuperficial();
            calculaFrequenciaLimpeza(0.9);



            this.alturaMin = alturaMin;
            this.alturaMax = alturaMax;
        }

        public Desarenador(double velocidadeEfluente, double alturaMax, double alturaMin,
            int populacao, int populacaoFut, double qpc, double extensaoRede, double extensaoRedeFut, double taxaInfiltracao, double taxaInfiltracaoFut)
            : base(populacao, populacaoFut, qpc, extensaoRede, extensaoRedeFut, taxaInfiltracao, taxaInfiltracaoFut){

            this.velocidadeEfluente = velocidadeEfluente;
            calculaLarguraDesarenador(VazaoMaxFut, alturaMax, this.velocidadeEfluente);
            calculaAreaSecao(alturaMin);
            corrigeVelocidade(velocidadeEfluente);
            calculaComprimento(alturaMax);
            calculaAreaSuperficial();
            calculaTaxaAplicacaoSuperficial();
            calculaFrequenciaLimpeza(0.9);



            this.alturaMin = alturaMin;
            this.alturaMax = alturaMax;
        }

        //


        // Calcula a largura inicial do desarenador
        public void calculaLarguraDesarenador(double vazaoMaxFut, double alturaMax, double velocidadeEfluente)
        {
            larguraDesarenador = (VazaoMaxFut / 1000) / (alturaMax * velocidadeEfluente);
        }

        // Calcula a area da seção do canal inicial
        public void calculaAreaSecao(double alturaMin) 
        {
            areaSecaoDesarenador = alturaMin * larguraDesarenador;
        }

        // Corrige a velocidade do efluente
        public void corrigeVelocidade(double vh){
            try
            {
                if (vh < 0.2 || vh > 0.4)
                {
                    Console.WriteLine("Valor fora do intervalo (0.2 , 0.4)");
                    Console.WriteLine(vh);
                    vh = double.Parse(Console.ReadLine(), format);
                }
                if (CalculaVelocidadeTeste(0.2) && CalculaVelocidadeTeste(0.4))
                {
                   
                        throw new Exception("Largura Fora das Normas, impossível realizar a operação!");
                }

                if (CalculaVelocidadeTeste(vh))
                {
                    Console.WriteLine("Sua velocidade está fora das normas, por favor insira uma nova velocidade: ");
                    vh = double.Parse(Console.ReadLine(), format);
                    while(CalculaVelocidadeTeste(vh))
                    {
                        Console.WriteLine(vh);
                        if (vh < 0.2 || vh > 0.4)
                        {
                            Console.WriteLine("Valor fora do intervalo (0.2 , 0.4)");
                            vh = double.Parse(Console.ReadLine(), format);
                        }
                        else
                        {
                            Console.WriteLine("Sua velocidade está fora das normas, por favor insira uma nova velocidade: ");
                            vh = double.Parse(Console.ReadLine(), format);
                        }

                    }

                    velocidadeEfluente = vh;
                    larguraDesarenador = VazaoMaxFut / 1000 / (alturaMax * velocidadeEfluente);
                    areaSecaoDesarenador = alturaMin * larguraDesarenador;
                    
                }
                velocidadeTeste = (VazaoMinFut / 1000) / areaSecaoDesarenador;

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
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
                Console.WriteLine(e.Message); 
            }
        }
 
        /* Calcula a taxa de aplicação superficial, e verifica se ela está dentro dos padões. Caso não esteja pede pra corrigir 
         * velocidade e recalcula todos os coeficientes
        */
        public void calculaTaxaAplicacaoSuperficial()
        {
            taxaAplicacaoSueprficial = (VazaoMaxFut / 1000) * areaSuperficial;
            try
            {
                if (verificaExtremos(0.2) && verificaExtremos(0.4))
                {
                    throw new Exception("Fora do intervalo, impossível fazer a verificação");
                }

                if (taxaAplicacaoSueprficial > 1300 || taxaAplicacaoSueprficial < 600)
                {
                    do
                    {
                        Console.WriteLine("TAS " + taxaAplicacaoSueprficial + "fora da faixa, por favor informe uma nova velocidade: ");
                        double vh;
                        vh = double.Parse(Console.ReadLine(), format);
                        Console.WriteLine(vh);
                        corrigeVelocidade(vh);
                        calculaAreaSuperficial();
                        taxaAplicacaoSueprficial = (VazaoMaxFut / 1000) * areaSuperficial;


                    } while (taxaAplicacaoSueprficial > 1300 || taxaAplicacaoSueprficial < 600);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void calculaFrequenciaLimpeza(double taxaDiariaAreia)
        {
            volDiarioAreiaRetido = (taxaDiariaAreia * 1000) * (VazaoMedFut/1000) * 86400;
            alturaGeradaAreiaDia = (volDiarioAreiaRetido / 1000) * areaSuperficial;
            frequenciaLimpeza = (int)Math.Round((0.2 * alturaGeradaAreiaDia));
        }

        public override void imprime()
        {
            Console.WriteLine(larguraDesarenador);
            Console.WriteLine(velocidadeEfluente);
            Console.WriteLine(comprimentoDesarenador);
            Console.WriteLine(areaSuperficial);
            Console.WriteLine("Altura m");
            Console.WriteLine("Altura M");
            Console.WriteLine(velocidadeTeste);
            Console.WriteLine(taxaAplicacaoSueprficial);
            Console.WriteLine(alturaGeradaAreiaDia);
            Console.WriteLine(frequenciaLimpeza);
        }

        /**
         * 
         * Função para verificar se a velocidade informada é menor que o recomendado pela norma
         * 
        **/
        private bool CalculaVelocidadeTeste(double velocidade)
        {
            double largura, area, vh;
            largura = (VazaoMaxFut / 1000) / (alturaMax * velocidade);
            area = alturaMin * largura;
            vh = VazaoMinFut / 1000 / area;
            
            return vh > 4;
        }

        private bool verificaExtremos(double velocidade)
        {
            double largura, area, vh, superficial, taxa;
            largura = (VazaoMaxFut / 1000) / (alturaMax * velocidade);
            area = alturaMin * largura;
            vh = VazaoMinFut / 1000 / area;
            superficial = comprimentoDesarenador * largura;
            taxa = (VazaoMaxFut / 1000) * superficial;
            return (taxa > 1300 || taxa < 600);
        }
    }
}
