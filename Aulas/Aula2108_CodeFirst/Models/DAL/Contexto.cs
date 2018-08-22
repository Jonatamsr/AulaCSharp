using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Models.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("nomeStringConexao")
        {

        }
    }
}
