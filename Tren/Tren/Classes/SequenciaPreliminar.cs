using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tren.Classes
{
    class SequenciaPreliminar : Sequencia{
        private List<UnidadePreliminar> sequenciaPreliminar;

        public SequenciaPreliminar(UnidadePreliminar a)
        {
            sequenciaPreliminar = new List<UnidadePreliminar>();
            sequenciaPreliminar.Add(a);

        }

        public List<UnidadePreliminar> getUnidadePreliminar()
        {
            return sequenciaPreliminar;
        }
    }
}
