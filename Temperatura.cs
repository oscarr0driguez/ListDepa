using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDepa
{
    class Temperatura
    {
        int idDepartamento;
        int temp;
        DateTime fechaLectura;

        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public int Temp { get => temp; set => temp = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
    }
}
