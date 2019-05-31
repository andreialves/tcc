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
        private double taxaAreiaDiaria;


        // Calculo da altura provisório
        private double alturaMin;
        private double alturaMax;
      

        // Construtores do Desarenador

        public Desarenador(double velocidadeEfluente, double taxaAreiaDiaria){
            if (velocidadeEfluente > 0.4 || velocidadeEfluente < 0.2) {
                throw new Exception("Velocidade Fora do Intervalo.");
            } else {
                this.velocidadeEfluente = velocidadeEfluente;
                this.taxaAreiaDiaria = taxaAreiaDiaria;
            }
        }

        //


        // Calcula a largura do desarenador
        public void CalculaLarguraDesarenador(){

            larguraDesarenador = (VazaoMaxFut / 1000) / (alturaMax * velocidadeEfluente);

        }

        // Calcula a area da seção do canal
        public void CalculaAreaSecao() {

            areaSecaoDesarenador = alturaMin * larguraDesarenador;

        }

        //Calcula o comprimento do desarenador
        public void CalculaComprimento() {

            comprimentoDesarenador = 22.5 * alturaMax;

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
                velocidadeTeste = VazaoMinFut / 1000 / areaSecaoDesarenador;
                return velocidadeTeste > 4;
            }
        }

        public bool VerificaTAS() {

            return taxaAplicacaoSueprficial <= 1300 && taxaAplicacaoSueprficial >= 600;

        }

        public void CalculaTAS() {

            taxaAplicacaoSueprficial = VazaoMaxFut / 1000 / areaSuperficial;

        }

        // Corrige a velocidade do efluente
        public void corrigeVelocidade(double vh){
            if (vh < 0.2 || vh > 0.4) {
                throw new Exception("Velocidade fora do intervalo.");
            } else {
                velocidadeEfluente = vh;
                CalculaLarguraDesarenador();
                CalculaAreaSecao();
            }
        }
 
        public void calculaFrequenciaLimpeza()
        {
            volDiarioAreiaRetido = taxaAreiaDiaria * 1000 * (VazaoMedFut / 1000) * 86400;
            alturaGeradaAreiaDia = (volDiarioAreiaRetido / 1000) * areaSuperficial;
            frequenciaLimpeza = Convert.ToInt32(Math.Round(0.2 * alturaGeradaAreiaDia, MidpointRounding.AwayFromZero));
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
        
    }
}
