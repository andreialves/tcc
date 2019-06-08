using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			if (limpezaMec)
				tipoLimpeza = 1;
			else if (limpezaMan)
				tipoLimpeza = 2;

			if (tipoG == 0 || tipoLimpeza == 0 || espessura == "" || espacamento == "") {
				return;
			}

			dados["tipoGrade"] = Convert.ToString(tipoG);
			dados["tipoLimpeza"] = Convert.ToString(tipoLimpeza);
			dados["espessura"] = espessura;
			dados["espacamento"] = espacamento;

			Pai.avancaView();
            Close();
        }

		private void bt_grade_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Close();
		}

        private void Grade_Load(object sender, EventArgs e) {
           
        }
    }
}
