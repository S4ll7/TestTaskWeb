﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Data.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string District { get; set; }
        public int Size { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
