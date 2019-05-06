using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Classes;

namespace Tren
{
    class Program
    {
        static void Main(string[] args)
        {
			UnidadePreliminar a = new UnidadePreliminar(60000, 70411, 150, 120, 140, 0);
			// a.imprime();
			//Desarenador b = new Desarenador(0.2, 5, 3, 60000, 70411, 150, 120, 140, 0, 0.2);
			CalhaParshall cp = new CalhaParshall();
			Console.WriteLine(cp.VazaoMax);
            //SequenciaPreliminar sequencia = new SequenciaPreliminar(b);
			//sequencia.adicionar(a);
			
            /*foreach (UnidadePreliminar i in sequencia.getUnidadePreliminar())
            {
                i.imprime();
            }*/
            Console.ReadKey();
        }
    }
}
