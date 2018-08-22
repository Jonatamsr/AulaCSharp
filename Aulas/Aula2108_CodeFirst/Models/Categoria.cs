using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Models
{
    class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(30)]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Produto> _Produtos { get; set; }
    }
}
