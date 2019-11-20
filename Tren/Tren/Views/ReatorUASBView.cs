using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tren.Classes;

namespace Tren.Views {
    public partial class ReatorUASBView : View {
        Dictionary<string, string> dados;

        public ReatorUASBView(Dictionary<string, string> d, InicioView pai) : base(pai) {
            InitializeComponent();
            dados = d;
        }

        private void bt_uasb_avancar_Click(object sender, EventArgs e) {
            // Recupera valores do textBox

            bool vTipicoDBO = checkBox1.Checked, vTipicoDQO = checkBox2.Checked, vTipicoSST = checkBox3.Checked;
            string dbo = txb_dbo.Text, dqo = txb_dqo.Text, sst = txb_sst.Text, temperatura = txb_temp.Text;

            if (vTipicoDBO) dbo = "50";
            if (vTipicoDQO) dqo = "100";
            if (vTipicoSST) sst = "180";

            if ((!vTipicoDBO && dbo == "") || (!vTipicoDQO && dqo == "") || (!vTipicoSST && sst == "") || (temperatura =="")) return;
           
            

            dados["dbo"] = dbo;
            dados["dqo"] = dqo;
            dados["sst"] = sst;
            dados["temperatura"] = temperatura;

            double db = Convert.ToDouble(dbo);
            double dq = Convert.ToDouble(dqo);
            double s = Convert.ToDouble(sst);
            double temp = Convert.ToDouble(temperatura);

            foreach (var c in Pai.Centrais) {
                foreach (var d in c.getSequencia) {
                    if (d.GetType() == typeof(SequenciaSecundaria)) {
                        foreach (var f in ((SequenciaSecundaria)d).getSeqSecundaria) {
                            foreach (var u in f) {
                                if (u.GetType() == typeof(ReatorUASB)) {
                                    ReatorUASB reator = (ReatorUASB)u;
                                    reator.dboSet = db;
                                    reator.dqoSet = dq;
                                    reator.sstSet = s;
                                    reator.temp = temp;

                                    // Calculos

                                    reator.calculaCargaDQO();
                                    reator.calculaTDH();
                                    reator.calculaVolumeTotal();
                                    reator.calculaReatores();
                                    reator.calculaVolumeUtil();
                                    reator.calculaAreaTransversal();
                                    reator.calculaAreaTotal();
                                    reator.calculaLodoGerado();
                                    reator.calculaEficienciaRemocao();
                                    reator.ajustaDQO();
                                    reator.calculaCargaDQOEstimado();
                                    reator.calculaFatorCorrecao();
                                    reator.converteMassaMetano();
                                    reator.calculaBiogas();

                                    reator.print();
                                }
                            }
                        }
                    }
                }
            }

            

            Pai.avancaView();
            Hide();
        }

        private void bt_uasb_voltar_Click(object sender, EventArgs e) {
            Pai.voltaView();
            Hide();
        }

        private void txb_numeros(object sender, KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ',') {
                if (e.KeyChar == ',' && ((MetroTextBox)sender).Text.Contains(','))
                    e.Handled = true; // não processa tecla apertada
                return; // processa a tecla apertada
            }

            e.Handled = true; // não processa tecla apertada
        }

    }
}
