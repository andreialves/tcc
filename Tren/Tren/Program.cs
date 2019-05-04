using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.UnidadePreliminar a = new Classes.UnidadePreliminar(35000, 52008, 1.4, 10.0, 34.9, 12.5);
           // a.imprime();

            Classes.SequenciaPreliminar sequencia = new Classes.SequenciaPreliminar(a);

            foreach (Classes.UnidadePreliminar i in sequencia.getUnidadePreliminar())
            {
                i.imprime();
            }
            Console.ReadKey();
        }
    }
}
