using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceSite.Entities;

namespace EcommerceSite.Services.Interfaces
{
    public interface IOrderService
    {
        void placeOrder(List<Product> products, List<Order> orders);
        void viewOrder(List<Order> orders);
    }
}
