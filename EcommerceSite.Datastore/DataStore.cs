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
            new Product("IPhone 12 Pro max", "Fairly used 64gb", 725000, 25 ),
            new Product("IPhone 13 Pro Max", "UK used 256gb", 9850000, 10),
            new Product("IPhone 14 Pro max", "Open box 128gb", 1250000, 15),
            new Product("IPhone 15 Pro max", "Brand new 256gb", 1550000, 15)
        };
    }
}
