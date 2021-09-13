using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int IDTransacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public Department()
        {
        }

        public Department(int id, string name, int idtransacao, DateTime datacadastro)
        {
            Id = id;
            Name = name;
            IDTransacao = idtransacao;
            DataCadastro = datacadastro;
        }


    }

}
