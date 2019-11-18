using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;

namespace Tren.Classes {
    public class TanqueSeptico : UnidadeSecundaria{

        private Dictionary<String, String>[] TabControlEsgoto; // C | Lf
        private Dictionary<String, String>[] TabTempoDetHidrica; // litros | dias
        private Dictionary<String, String>[] TabelaAcumulacaoLodo; // anos | <10 | 10 < T < 20 | > 20
        private Dictionary<String, String>[] OcupanteNumero;
        private int? tempoLimpeza = null;
        private double? temperaturaMesFrio = null;
        private double? vazaoDiaria = null;
        private double? esgotoTotal = null;
        private double? lodoFrescoTotal = null;
        private double? tempoDetHidraulica = null;
        private int? taxaAcumulacaoLodo = null;
        private double? volumeUtilNecessario = null;
        private double? dboEntrada = null;
        private double? dqoEntrada = null;
        private double? sstEntrada = null;
        private double? dboSaida = null;
        private double? sstSaida = null;
        private double? contribuicaoTotal = null;
        private double? periodoDet = null;


        public TanqueSeptico( SequenciaSecundaria ss) : base(ss) {
            carregaTabControl();
            carregaTabLodo();
            carregaTabHidrica();
        }

        public TanqueSeptico(int tempoLimpeza, double temperaturaMesFrio, SequenciaSecundaria ss) : base(ss) {
            carregaTabControl();
            carregaTabLodo();
            carregaTabHidrica();
        }

        private void carregaTabControl() {
            try {
                string[] linhas = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Tabelas Tren\TanqueSeptico.tren");
                TabControlEsgoto = new Dictionary<string, string>[linhas.Length];

                for (int i = 0; i < linhas.Length; i++) {
                    string[] aux = linhas[i].Split(' ');

                    TabControlEsgoto[i] = new Dictionary<string, string>();
                    TabControlEsgoto[i]["C"] = aux[0];
                    TabControlEsgoto[i]["Lf"] = aux[1];
                }
            } catch (Exception){
                throw new Exception("Tanque Septico: Erro de Leitura da Tabela de Controle de Esgoto.");
            }
        }
        private void carregaTabLodo() {
            try {
                string[] linhas = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Tabelas Tren\AcumulacaoLodo.tren");
                TabelaAcumulacaoLodo = new Dictionary<string, string>[linhas.Length];
                for (int i = 0; i < linhas.Length; i++) {
                    string[] aux = linhas[i].Split(' ');

                    TabelaAcumulacaoLodo[i] = new Dictionary<string, string>();
                    
                    TabelaAcumulacaoLodo[i]["anos"] = aux[0];
                    TabelaAcumulacaoLodo[i]["<10"] = aux[1];
                    TabelaAcumulacaoLodo[i]["10<T<20"] = aux[2];
                    TabelaAcumulacaoLodo[i][">20"] = aux[3];
                }

            } catch (Exception) {
                throw new Exception("Tanque Septico: Erro de Leitura da Tabela de Acumulacao de Lodo.");
            }
        }

        private void carregaTabHidrica() {
            try {
                string[] linhas = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Tabelas Tren\TempoDetHidrica.tren");

                TabTempoDetHidrica = new Dictionary<string, string>[linhas.Length];
                for(int i = 0; i < linhas.Length; i++) {
                    string[] aux = linhas[i].Split(' ');

                    TabTempoDetHidrica[i] = new Dictionary<string, string>();

                    TabTempoDetHidrica[i]["litros"] = aux[0];
                    TabTempoDetHidrica[i]["dias"] = aux[1];

                }

            } catch (Exception) {
                throw new Exception("Tanque Septico: Erro de Leitura da Tabela de Tempo de Detencao Hidrica.");
            }
        }

        public void calculaTd() {
            for (int i = 0; i < TabTempoDetHidrica.Length - 1; i++) {
                if(contribuicaoTotal > Convert.ToDouble(TabTempoDetHidrica[i]["litros"]) && contribuicaoTotal <= Convert.ToDouble(TabTempoDetHidrica[i+1]["litros"])) {
                    periodoDet = Convert.ToDouble(TabTempoDetHidrica[i]["dias"]);
                    return;
                }
            }
            periodoDet = Convert.ToDouble(TabTempoDetHidrica[TabTempoDetHidrica.Length-1]["dias"]);
        }

		public override void accept(Visitor v) {
			v.visit(this);
		}
	}
}
