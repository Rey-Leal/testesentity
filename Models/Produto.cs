using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesEntity.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string grupo { get; set; }
        public string nome { get; set; }
        public string especificacao { get; set; }
        public string unidade { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }
    }
}