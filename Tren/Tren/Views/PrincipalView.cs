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
    public partial class PrincipalView : Form {
        public PrincipalView() {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e) {

        }

        private void metroTabPage1_Click(object sender, EventArgs e) {

        }

        private void metroButton1_Click(object sender, EventArgs e) {
			SelecaoSeqColView seqCol = new SelecaoSeqColView();
			seqCol.TopLevel = false;
			seqCol.Dock = DockStyle.Fill;
			Parent.Controls.Add(seqCol);
			seqCol.Show();
			Close();
		}

        private void metroButton2_Click(object sender, EventArgs e) {
			SelecaoSeqIndView seqInd = new SelecaoSeqIndView();
			seqInd.TopLevel = false;
			seqInd.Dock = DockStyle.Fill;
			Parent.Controls.Add(seqInd);
			seqInd.Show();
			Close();
		}
    }
}
