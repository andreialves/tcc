using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Tren.Classes
{
	class CalhaParshall : UnidadePreliminar
	{
		private IDictionary<string, string> [] tabelaCalhas; // | mm | polegadas | vazaoMin | vazaoMax | n | k |
		private int mm;
		private double n;
		private double k;
		private double HMin;
		private double HMax;
		private double hMin;
		private double hMax;
		private double desnivel;


		public CalhaParshall()
		{
			// carrega tabelaCalhas
			try
			{
				string[] linhas = System.IO.File.ReadAllLines(@"C:\TREN\calhas.tren");
				tabelaCalhas = new Dictionary<string, string> [linhas.Length];
				
				for(int i = 0; i < linhas.Length; i++)
				{
					string[] aux = linhas[i].Split(' ');

					tabelaCalhas[i] = new Dictionary<string, string>();
					tabelaCalhas[i]["mm"] = aux[0];
					tabelaCalhas[i]["pol"] = aux[1];
					tabelaCalhas[i]["vMin"] = aux[2];
					tabelaCalhas[i]["vMax"] = aux[3];
					tabelaCalhas[i]["n"] = aux[4];
					tabelaCalhas[i]["k"] = aux[5];
				}
				//calcula valores dos atributos
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			IFormatProvider prov = CultureInfo.InvariantCulture;
			double menorInt = 100000;
			foreach (Dictionary<string, string> d in tabelaCalhas)
			{
				if (double.Parse(d["vMin"], prov) <= VazaoMin && double.Parse(d["vMax"], prov) >= VazaoMaxFut)
					if (double.Parse(d["vMax"], prov) - double.Parse(d["vMin"], prov) < menorInt)
					{
						menorInt = double.Parse(d["vMax"], prov) - double.Parse(d["vMin"], prov);
						mm = int.Parse(d["mm"]);
						n = double.Parse(d["n"], prov);
						k = double.Parse(d["k"], prov);
					}
			}

			HMin = Math.Round(Math.Pow(VazaoMinFut / (1000 * k), 1/n), 2);
			HMax = Math.Round(Math.Pow(VazaoMaxFut / (1000 * k), 1/n), 2);
			desnivel = Math.Round((VazaoMaxFut*HMin - VazaoMinFut*HMax) / (VazaoMaxFut - VazaoMinFut), 2);
			hMin = Math.Round(HMin - desnivel, 2);
			hMax = Math.Round(HMax - desnivel, 2);
		}

		public double getW { get { return mm; } }
		public double getN { get { return n; } }
		public double getK { get { return k; } }
		public double getHMax { get { return HMax; } }
		public double getHMin { get { return HMin; } }
		public double gethMax { get { return hMax; } }
		public double gethMin { get { return hMin; } }
	}
}
