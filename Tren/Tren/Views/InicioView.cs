using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tren.Views {
    public partial class InicioView : MetroForm {
		private List<View> listaViews;
		private List<string> nomeViews;
		private int it;

		public InicioView() {
			InitializeComponent();

			listaViews = new List<View>();
			nomeViews = new List<string>();
			it = 0;

			PrincipalView principal = new PrincipalView(this);
            principal.TopLevel = false;
            principal.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(principal);
            principal.Show();
			
		}

		public void avancaView() {
			it++;
			ViewAtual.Show();
		}

		public void voltaView() {
			it--;
			ViewAtual.Show();
		}

		private View ViewAtual {
			get {
				if (it >= listaViews.Count)
					throw new Exception("InicioView::CurrentView - iterador inválido");

				return listaViews[it];
			}
		}

		public int NumViews {
			get {
				return listaViews.Count;
			}
		}

		public void limpaLista() {
			listaViews.Clear();
			nomeViews.Clear();
			it = 0;
		}

		public void AddView(View view, string nome) {
			if (nomeViews.Contains(nome)) {
				return;
			}
			view.TopLevel = false;
			view.Dock = DockStyle.Fill;
			mainPanel.Controls.Add(view);

			listaViews.Add(view);
			nomeViews.Add(nome);
		}
    }
}
