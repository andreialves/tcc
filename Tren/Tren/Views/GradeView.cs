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
    public partial class GradeView : View {
		Dictionary<string, string> dados;
		public GradeView(Dictionary<string, string> d, InicioView pai) : base(pai) {
            InitializeComponent();
			dados = d;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

		private void bt_grade_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string tipoGrade = cb_tipoGrade.Text;
			bool limpezaMec = metroRadioButton1.Checked;
			bool limpezaMan = metroRadioButton2.Checked;
			string espessura = txb_espessura.Text;
			string espacamento = txb_espacamento.Text;

			int tipoG = 0;
			if (tipoGrade == "Grossa")
				tipoG = 1;
			else if (tipoGrade == "Média")
				tipoG = 2;
			else if (tipoGrade == "Fina")
				tipoG = 3;

			int tipoLimpeza = 0;
			if (limpezaMan)
				tipoLimpeza = 2;
			else if (limpezaMec)
				tipoLimpeza = 1;

			if (tipoG == 0 || tipoLimpeza == 0 || espessura == "" || espacamento == "") {
				return;
			}

			dados["tipoGrade"] = tipoG.ToString();
			dados["tipoLimpeza"] = tipoLimpeza.ToString();
			dados["espessura"] = espessura;
			dados["espacamento"] = espacamento;

			double espes = double.Parse(espessura);
			double espac = double.Parse(espacamento);

			foreach (var c in Pai.Centrais) {
				foreach (var s in c.getSequencia) {
					if (s.GetType() == typeof(SequenciaPreliminar)) {
						foreach (var u in ((SequenciaPreliminar)s).getSeqPreliminar) {
							if (u.GetType() == typeof(Grade)) {
								Grade gr = (Grade)u;
								gr.TipoGrade = tipoG;
								gr.TipoLimpeza = tipoLimpeza;
								gr.Espessura = espes;
								gr.Espacamento = espac;
								// calcula valores
								gr.CalculoEficiencia();
								gr.CalculaAreaUtil();
								gr.CalculaAreaUtilLinha();
								gr.CalculaSecaoCanal();
								gr.CalculaSecaoCanalLinha();
								gr.CalculaLarguraCanal();
								gr.CalculaLarguraCanalLinha();
								gr.CalculaSecaoCanalLinha();
								gr.CalculaVelocidadeLinha();
								gr.CalculaVelAproxMax();
								gr.CalculaVelAproxMin();
								gr.CalculaPerdaCarga();
								gr.CalculaPerdaCargaTotal();
								gr.CalculaBarras();
								gr.CalculaCorrecaoEspaco();
								gr.CalculaDiferencaEspaco();
								gr.CalculaComprimento();
							}
						}
					}
				}
			}

			Pai.avancaView();
            Hide();
        }

		private void bt_grade_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Hide();
		}

        private void Grade_Load(object sender, EventArgs e) {
           
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
