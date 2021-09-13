using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class NovaTrans
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumTransacao { get; set; }
        public NovaTrans()
        {
        }

        public NovaTrans(int id, string name, int numTransacao)
        {
            Id = id;
            Name = name;
            NumTransacao = numTransacao;
        }


    }

}
