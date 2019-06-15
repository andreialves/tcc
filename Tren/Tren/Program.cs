using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tren.Classes;
using Tren.Views;

namespace Tren {
    class Program {
		[STAThread]
        static void Main(string[] args) {
			CentralTratamento central = new CentralTratamento();
			SequenciaPreliminar seqP = new SequenciaPreliminar(central);
			central.adicionar(seqP);

			CalhaParshall calha = new CalhaParshall(seqP);
			Desarenador des = new Desarenador(0.3, 0.003, seqP);
			Desarenador des2 = new Desarenador(0.3, 0.003, seqP);
			CaixaSAO caixa = new CaixaSAO(seqP);
			Desarenador des3 = new Desarenador(0.3, 0.003, seqP);
			Grade grd = new Grade(10, 35, 1, 1, seqP);

			seqP.adicionar(calha);
			seqP.adicionar(des);
			seqP.adicionar(des2);
			seqP.adicionar(caixa);
			seqP.adicionar(des3);
			seqP.adicionar(grd);

			int cont = 0;
			foreach (var i in seqP.getSeqPreliminar) {
				if (i.GetType() == typeof(Desarenador)) {
					Console.WriteLine(cont);
				}

				cont++;
			}


			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InicioView());
			
        }
    }
}
