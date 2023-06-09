using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Interfaces;
using TestTask.Data.Models;
using TestTask.ViewModels;

namespace TestTask.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts allProducts;
        private readonly IProductsCategory allCategories;

        public ProductsController(IAllProducts iAllProducts, IProductsCategory iProductsCategory)
        {
            allProducts = iAllProducts;
            allCategories = iProductsCategory;
        }
        
        [Route("Products/AllProductsList")]
        [Route("Products/AllProductsList/{category}")]
        public ViewResult AllProductsList(string category)
        {
            ProductsListViewModel obj = new ProductsListViewModel();
            IEnumerable<Category> helpObj = allCategories.AllCategoriesGet;

            switch (category)
            {
                case "Новостройки":

                    obj.AllProducts = allProducts.Products.Where(i => i.Category.CategoryName.Equals("Новостройки"));
                    obj.ProductCategory = "Новостройки";
                    break;
                case "Вторичная недвижимость":
                    obj.AllProducts = allProducts.Products.Where(i => i.Category.CategoryName.Equals("Вторичная недвижимость"));
                    obj.ProductCategory = "Вторичная недвижимость";
                    break;
                case "Аренда":
                    obj.AllProducts = allProducts.Products.Where(i => i.Category.CategoryName.Equals("Аренда"));
                    obj.ProductCategory = "Аренда";
                    break;
                case "Земельные участки":
                    obj.AllProducts = allProducts.Products.Where(i => i.Category.CategoryName.Equals("Земельные участки"));
                    obj.ProductCategory = "Земельные участки";
                    break;
                default:
                    obj.AllProducts = allProducts.Products;
                    obj.ProductCategory = "All";
                    break;
            }
            
            return View(obj);
        }

    }
}
