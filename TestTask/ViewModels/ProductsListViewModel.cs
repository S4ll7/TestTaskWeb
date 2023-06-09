using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Models;

namespace TestTask.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> AllProducts { get; set; }
        public string ProductCategory { get; set; }
    }
}
