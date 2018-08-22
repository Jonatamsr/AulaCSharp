using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608_EFDatabaseFirst.Controllers
{
    class ProductController
    {
        void Inserir(Product p)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Product.Add(p);
            contexto.SaveChanges();
        }
        List<Product> 
    }
}
