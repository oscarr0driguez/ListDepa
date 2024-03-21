using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDepa
{
    class Reporte
    {
        string nombreDepartamento;
        int  tempratura;
        DateTime fecha;

        public Reporte(string nombreDepartamento, int tempratura, DateTime fecha)
        {
            this.nombreDepartamento = nombreDepartamento;
            this.tempratura = tempratura;
            this.fecha = fecha;
        }

        public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }
        public int Tempratura { get => tempratura; set => tempratura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
