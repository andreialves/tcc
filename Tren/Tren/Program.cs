using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Classes;

namespace Tren {
    class Program {
        static void Main(string[] args) {
			try {
				CentralTratamento ct = new CentralTratamento(1000, 600, 400, 2000, 1200, 400, 6000, 12000);
				SequenciaPreliminar sp = new SequenciaPreliminar(ct);
				ct.adicionar(sp);
				CalhaParshall cp = new CalhaParshall(sp);
				CaixaSAO cSao = new CaixaSAO(1.0, 0.8, 1.37, sp);
			}catch(Exception e) {
				Console.WriteLine(e.Message);
			}

			Console.WriteLine("Fim do programa!");

				
            Console.ReadKey();
        }
    }
}
