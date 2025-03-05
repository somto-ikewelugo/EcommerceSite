using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceSite.Entities;

namespace EcommerceSite.DataBase
{
    public class DataStore
    {
        public static List<Product> products { get; set; } = new List<Product>()
        {
            new Product(1, "Hisense Television", "55 inches 4k Smart TV", 725000, 25 ),
            new Product(2, "IPhone 16 Pro Max", "Brand new 256gb storage", 2300000, 10),
            new Product(3, "Dell Laptop", "Brand new model 7270", 250000, 15),
            new Product(4, "Playstation 5 Pro", "Brand new 1TB", 1200000, 15),
            new Product(5, "LG Refrigerator", "Brand new 250L", 520000, 20),
            new Product(6, "IPad", "Brand new 12 inches 256gb", 750000, 35)
        };
        public static List<Order> orders { get; set; } = new List<Order>();
    }
}
