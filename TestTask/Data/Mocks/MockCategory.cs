using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Interfaces;
using TestTask.Data.Models;

namespace TestTask.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategoriesGet
        {
            get
            {
                return new List<Category> {
                    new Category{ CategoryName = "Новостройки", Description = "описание категории 1"},
                    new Category{ CategoryName = "Вторичная недвижимость", Description = "описание категории 1"},
                    new Category{ CategoryName = "Аренда", Description = "описание категории 1"},
                    new Category{ CategoryName = "Земельные участки", Description = "описание категории 1"}
                };

            }
        }
    }
}
