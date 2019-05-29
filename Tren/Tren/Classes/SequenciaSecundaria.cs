﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
	class SequenciaSecundaria : Sequencia
	{
		private List<List<UnidadeSecundaria>> sequenciaSecundaria;

		public SequenciaSecundaria()
		{
			sequenciaSecundaria = new List<List<UnidadeSecundaria>>();
		}

		public void adicionarEmSerie(UnidadeSecundaria us)
		{
			sequenciaSecundaria.Add(new List<UnidadeSecundaria>());
			sequenciaSecundaria.Last().Add(us);
		}

		public void adicionarEmParalelo(int pos, UnidadeSecundaria us)
		{
			if(sequenciaSecundaria.Count > pos)
				sequenciaSecundaria[pos].Add(us);
			else throw new System.ArgumentException("Parametro com valor invalido", "pos");
		}
	}
}