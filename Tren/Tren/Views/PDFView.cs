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
    public partial class PDFView : Form {
        public PDFView() {
            InitializeComponent();
            this.webBrowser1.Navigate(string.Format( @"file://{0}\Relatorio.pdf", Application.StartupPath));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
           
        }
    }
}
