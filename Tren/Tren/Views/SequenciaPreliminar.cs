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
	public partial class SequenciaPreliminar : Form {
		public SequenciaPreliminar() {
			InitializeComponent();
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			CaixaSAO caixaSAO = new CaixaSAO();
			caixaSAO.TopLevel = false;
			caixaSAO.Dock = DockStyle.Fill;
			Parent.Controls.Add(caixaSAO);
			caixaSAO.Show();
			Close();
		}

		private void bt_central2_voltar_Click(object sender, EventArgs e) {
			CentralDeTratamento1 central1 = new CentralDeTratamento1();
			central1.TopLevel = false;
			central1.Dock = DockStyle.Fill;
			Parent.Controls.Add(central1);
			central1.Show();
			Close();
		}
	}
}
