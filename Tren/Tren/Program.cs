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
			UnidadePreliminar a = new UnidadePreliminar(60000, 70411, 150, 120, 140.822, 0, 0.2);
			// a.imprime();
			
			CalhaParshall cp = new CalhaParshall();
            Desarenador b = new Desarenador(0.3, cp.getHMax, cp.getHMin);
            //Console.WriteLine("dados: " + cp.getW + " " + cp.getN + " " + cp.getK + " " + cp.getHMin + " " + cp.getHMax + " " + cp.gethMin + " " + cp.gethMax);
            SequenciaPreliminar sequencia = new SequenciaPreliminar(cp);
            sequencia.adicionar(b);
            //b.imprime();

            foreach (UnidadePreliminar i in sequencia.getUnidadePreliminar())
            {
                i.imprime();
            }

          

            Console.ReadKey();
        }
    }
}
