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
	public partial class View : Form {
		private InicioView pai;

		public View() {
			InitializeComponent();
			pai = null;
		}

		public View(InicioView v) {
			InitializeComponent();

			pai = v;
		}

		public InicioView Pai {
			get {
				return pai;
			}
		}
	}
}
