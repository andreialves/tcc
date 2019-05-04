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
            Classes.grade teste = new Classes.grade(3, 8);

            Console.WriteLine(teste.espacamentoBarras + " " + teste.eficiencia);
            Console.ReadKey();
        }
    }
}
