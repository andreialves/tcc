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
    public partial class DesarenadorView : View {
		Dictionary<string, string> dados;

		public DesarenadorView(Dictionary<string, string> d, InicioView pai) : base(pai) {
            InitializeComponent();
			dados = d;
        }

		private void bt_grade_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string veloc = txb_velocidade.Text;
			string taxaAreia = txb_taxaAreia.Text;

			if (veloc == "" || taxaAreia == "") {
				return;
			}

			dados["velocidadeEfluente"] = veloc;
			dados["taxaAreiaDiaria"] = taxaAreia;

			Pai.avancaView();
			Close();
		}

		private void bt_grade_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
		}
	}
}
