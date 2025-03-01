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
        public static List<Product> products { get; set; } = new List<Product>();
        public static List<Order> orders { get; set; } = new List<Order>();
    }
}
