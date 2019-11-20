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
	public partial class BoasVindasView : View {
		public BoasVindasView(InicioView pai) : base(pai) {
			InitializeComponent();
		}

		private void bt_comeco_Click(object sender, EventArgs e) {
			List<View> list = new List<View>();
			list.Add(new LagoaAnaerobiaView(new InicioView()));
			list.Add(new LagoaFacultativaView(new InicioView()));
			list.Add(new LagoaMaturacaoView(new Dictionary<string, string>(), new InicioView()));

			/*SecundariaDinamica secundariaDinamica = new SecundariaDinamica(list);
			secundariaDinamica.TopLevel = false;
			secundariaDinamica.Dock = DockStyle.Fill;
			Parent.Controls.Add(secundariaDinamica);
			secundariaDinamica.Show();*/

			PrincipalView principal = new PrincipalView(Pai);
			principal.TopLevel = false;
			principal.Dock = DockStyle.Fill;
			Parent.Controls.Add(principal);
			principal.Show();
			Close();
		}
	}
}
