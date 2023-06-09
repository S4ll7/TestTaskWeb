using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Models;

namespace TestTask.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get;}
        Product GetProduct(int ProductId);
    }
}
