using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Ocorrencia
    {

        public int Id { get; set; }
        public int NumeroOcorrencia { get; set; }
        public bool StatusOcorrencia { get; set; }

        public Ocorrencia()
        {
        }

        public Ocorrencia(int id, int numeroOcorrencia, bool statusOcorrencia)
        {
            Id = id;
            NumeroOcorrencia = numeroOcorrencia;
            StatusOcorrencia = statusOcorrencia;
           
        }

    }

}
