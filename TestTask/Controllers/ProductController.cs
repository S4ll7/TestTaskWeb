using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Interfaces;
using TestTask.Data.Models;

namespace TestTask.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProducts allProducts;

        public ProductController(IAllProducts iAllProducts)
        {
            allProducts = iAllProducts;
        }

        [Route("Product/ShowProductInfo")]
        [Route("Product/ShowProductInfo/{productId}")]
        public ViewResult ShowProductInfo(int productId)
        {
            Product product = allProducts.GetProduct(productId);
            return View(product);
        }
    }
}
