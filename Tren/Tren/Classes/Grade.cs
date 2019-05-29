using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren.Classes
{
    class Grade : UnidadePreliminar
    {
        private int tipoGrade;
        private double espessuraGrade;
        private double espacamentoGrade;
        private double eficienciaGrade;
        private double areaUtilMax;
        private double areaUtilMin;
        private double secaoCanalMax;
        private double larguraGradeMax;
        private double secaoCanalMin;
        private double larguraGradeMin;
        private double velocidadeMin;
        private double velocidadeAproxMax;
        private double velocidadeAproxMin;
        private double perdaCargaMax;
        private double perdaCargaMin;
        private double perdaCargaMaxObs;
        private double perdaCargaMinObs;
        private double perdaCargaTotal;
        private int numeroBarras;
        private int numeroEspacamentos;
        private int correcaoBarraLateral;
        private double difRetLateral;
        private double comprimentoGrade;


        public Grade(int espessura, int espacamento)
        {
            espessuraGrade = espessura;
            espacamentoGrade = espacamento;
        }

    }
}
