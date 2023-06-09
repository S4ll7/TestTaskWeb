using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Interfaces;
using TestTask.Data.Models;

namespace TestTask.Data.Mocks
{
    public class MockProduct : IAllProducts
    {
        private readonly IProductsCategory categoryProducts = new MockCategory(); 
        public IEnumerable<Product> Products {
            get
            {
                return new List<Product> {
                    new Product{id = 0, Name ="Riva de la costa", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56, Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(0) },
                    new Product{id = 1, Name ="Riva de la costa", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56,Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(0) },
                    new Product{id = 2, Name ="Riva de la costa", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56,Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(0) },
                    new Product{id = 3, Name ="Riva de la costa", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56,Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(0) },
                    new Product{id = 4, Name ="Riva de la costa", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56, Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(0) },
                    new Product{id = 5, Name ="Riva de la costa 2", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56, Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(1) },
                    new Product{id = 6, Name ="Riva de la costa 2", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56, Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(1) },
                    new Product{id = 7, Name ="Riva de la costa 2", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56, Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(1) },
                    new Product{id = 8, Name ="Riva de la costa 2", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд", District = "de la cruso", Size = 56, Image = "/img/House.jpg", Price = 1000, Category = categoryProducts.AllCategoriesGet.ElementAt(1) },
                    new Product{id = 9, Name ="Embargo", ShortDescription = "площадь 36 м^2", LongDescription = "Длинное описание приемуществ данного жилья, комплекса итд",District = "de la cruso", Size = 56, Image = "/img/House.jpg", Price = 100, Category = categoryProducts.AllCategoriesGet.Last() }
                };
            }
        }
        
        public Product GetProduct(int ProductId)
        {
            foreach (var product in Products)
            {
                if (product.id == ProductId)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
