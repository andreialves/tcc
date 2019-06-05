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

		public DesarenadorView(Dictionary<string, string> d) {
            InitializeComponent();
			dados = d;
        }

		private void bt_grade_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string veloc = txb_velocidade.Text;
			string taxaAreia = txb_taxaAreia.Text;

			dados["velocidadeEfluente"] = veloc;
			dados["taxaAreiaDiaria"] = taxaAreia;

			CaixaSAOView caixaSAO = new CaixaSAOView(dados);
			caixaSAO.TopLevel = false;
			caixaSAO.Dock = DockStyle.Fill;
			Parent.Controls.Add(caixaSAO);
			caixaSAO.Show();
			Close();
		}
        
    }
}
