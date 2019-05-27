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
			UnidadePreliminar a = new UnidadePreliminar(40, 30, 19, 119, 60, 50);
			// a.imprime();
			// Desarenador b = new Desarenador(0.2, 5, 3, 60000, 70411, 150, 120, 140, 0, 0.2);
			CalhaParshall cp = new CalhaParshall();
			Console.WriteLine("dados: " + cp.getW + " " + cp.getN + " " + cp.getK + " " + cp.getHMin + " " + cp.getHMax + " " + cp.gethMin + " " + cp.gethMax);
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
