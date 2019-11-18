using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Tren.Views {
	public partial class SecundariaDinamica : View {
		public SecundariaDinamica(List<View> telas) {
			InitializeComponent();
			
			int p = 0;
			foreach (View v in telas) {
				for (int i = v.Controls.Count - 1; i >= 0; i--) {
					if (!v.Controls[i].Name.Contains("Titulo") && !v.Controls[i].Name.Contains("bt")) {
						v.Controls[i].Top += 250 * p;
						//Console.WriteLine(v.Controls[i].ToString());
						Controls.Add(v.Controls[i]);
					}
				}
				p++;
			}

			MetroButton voltar = new MetroButton();
			voltar.Text = "Voltar";
			voltar.Top = 393 + 250 * (p-1);
			voltar.Left = 110;
			voltar.Width = 237;
			voltar.Height = 45;
			voltar.Click += new System.EventHandler(this.bt_dinamica_voltar_Click);

			MetroButton avancar = new MetroButton();
			avancar.Text = "Avançar";
			avancar.Top = 393 + 250 * (p - 1);
			avancar.Left = 453;
			avancar.Width = 237;
			avancar.Height = 45;
			avancar.Click += new System.EventHandler(this.bt_dinamica_avancar_Click);

			Controls.Add(voltar);
			Controls.Add(avancar);
		}
		void bt_dinamica_avancar_Click(object sender, EventArgs e) {

		}

		void bt_dinamica_voltar_Click(object sender, EventArgs e) {

		}
	}
}
