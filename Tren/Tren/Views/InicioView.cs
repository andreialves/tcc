using Tren.Classes;
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
		private List<CentralTratamento> centrais;
		private int it;

		public InicioView() {
			InitializeComponent();

			centrais = new List<CentralTratamento>();
			listaViews = new List<View>();
			nomeViews = new List<string>();
			it = 0;

			BoasVindasView boasVindas = new BoasVindasView(this);
            boasVindas.TopLevel = false;
            boasVindas.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(boasVindas);
            boasVindas.Show();
			
			
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
				if (it < 0 || it >= listaViews.Count)
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
			foreach (View v in listaViews)
				if (v != listaViews[0]) {
					mainPanel.Controls.Remove(v);
					v.Close();
				}
			listaViews.Clear();
			nomeViews.Clear();
			it = 0;
			centrais.Clear();
		}

		public void AddView(View view, string nome) {
			view.TopLevel = false;
			view.Dock = DockStyle.Fill;
			mainPanel.Controls.Add(view);

			if (nomeViews.Contains(nome)) {
				int idx = nomeViews.IndexOf(nome);
				mainPanel.Controls.Remove(listaViews[idx]);
				listaViews[idx].Close();
				listaViews[idx] = view;
				return;
			}

			listaViews.Add(view);
			nomeViews.Add(nome);
		}

		public List<CentralTratamento> Centrais {
			get {
				return centrais;
			}
		}
    }
}
