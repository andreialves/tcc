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

namespace Tren.Views {
	public partial class DBOView : View {
		public DBOView(InicioView pai):base(pai) {
			InitializeComponent();
		}

		private void bt_dbo_avancar_Click(object sender, EventArgs e) {
			string dbo = txb_dbo.Text;

			if (dbo == "") {
				// Avisar para preencher os campos
				return;
			}

			double DBO = double.Parse(dbo);

			foreach (var c in Pai.Centrais) {
				c.DBOEntrada = DBO;
			}

			Pai.avancaView();
			Hide();
		}

		private void bt_dbo_voltar_Click(object sender, EventArgs e) {
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
