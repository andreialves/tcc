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
    public partial class PrincipalView : View {
		public PrincipalView(InicioView pai) : base(pai) {
			InitializeComponent();
            this.webBrowser1.Navigate(string.Format(@"file://{0}\MaterialApoio.pdf", Application.StartupPath));
            
        }

		private void Principal_Load(object sender, EventArgs e) {

        }

        private void metroTabPage1_Click(object sender, EventArgs e) {

        }

        private void metroButton1_Click(object sender, EventArgs e) {
			SelecaoSeqColView seqCol = new SelecaoSeqColView(Pai);
			seqCol.TopLevel = false;
			seqCol.Dock = DockStyle.Fill;
			Parent.Controls.Add(seqCol);
			seqCol.Show();
			Close();
		}

        private void metroButton2_Click(object sender, EventArgs e) {
			SelecaoSeqIndView seqInd = new SelecaoSeqIndView(Pai);
			seqInd.TopLevel = false;
			seqInd.Dock = DockStyle.Fill;
			Parent.Controls.Add(seqInd);
			seqInd.Show();
			Close();
		}
    }
}
