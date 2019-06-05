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
	public partial class CaixaSAOView : Form {
		public CaixaSAOView() {
			InitializeComponent();
		}

		private void bt_central1_avancar_Click(object sender, EventArgs e) {
			// Recupera valores do textBox
			string visc = txb_viscosidadeABS.Text;
			string dens = txb_densidadeOleo.Text;
			string turb = txb_turbulencia.Text;

			GradeView grade = new GradeView();
			grade.TopLevel = false;
			grade.Dock = DockStyle.Fill;
			Parent.Controls.Add(grade);
			grade.Show();
			Close();
		}

		private void bt_central2_voltar_Click(object sender, EventArgs e) {
			CentralDeTratamento1View central1 = new CentralDeTratamento1View();
			central1.TopLevel = false;
			central1.Dock = DockStyle.Fill;
			Parent.Controls.Add(central1);
			central1.Show();
			Close();
		}
	}
}
