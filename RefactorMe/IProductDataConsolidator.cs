using RefactorMe.DontRefactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMe
{
    public interface IProductDataConsolidator
    {
        IEnumerable<Product> GetAllProducts();
    }
}
