using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Models
{
    class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Imposto { get; set; }

        // Relacionamento Produto <--> Categoria
        public int CategoriaId { get; set; }
        public virtual Categoria _Categoria { get; set; }
    }
}
