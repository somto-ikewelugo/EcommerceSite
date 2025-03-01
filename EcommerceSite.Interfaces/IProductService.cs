using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceSite.Entities;
using EcommerceSite.Entities.Dtos;

namespace EcommerceSite.Interfaces
{
    public interface IProductService
    {
        void Create(ProductCreationDto productCreationDto);
        List<Product> GetProducts();
    }
}
