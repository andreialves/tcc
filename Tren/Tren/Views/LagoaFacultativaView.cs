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
	public partial class LagoaFacultativaView : View {
		Dictionary<string, string> dados;
		public LagoaFacultativaView(Dictionary<string, string> d, InicioView pai) : base(pai) {
			InitializeComponent();
			dados = d;
		}

		private void bt_lagoaFacul_avancar_Click(object sender, EventArgs e) {
			string dboEntrada = txb_dboEntrada.Text;
			string tempMesFrio = txb_tempMesFrio.Text;

			if (dboEntrada == "" || tempMesFrio == "") {
				return;
			}

			dados["dboEntrada"] = dboEntrada;
			dados["tempMesFrio"] = tempMesFrio;

			Pai.avancaView();
			Close();
		}
	}
}
