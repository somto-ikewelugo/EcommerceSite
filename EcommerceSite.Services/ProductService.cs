using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceSite.Entities;
using EcommerceSite.Entities.Dtos;
using EcommerceSite.Interfaces;

namespace EcommerceSite.Services
{
    public class ProductService : IProductService
    {
        public static int id = 0;

        // CRUD = CREATE, READ, UPDATE, DELETE


        // CREATE
        public void Create(ProductCreationDto productCreationDto)
        {
            Product product = new Product(
                ++id,
                productCreationDto.Name,
                productCreationDto.Description,
                productCreationDto.Price,
                productCreationDto.Quantity
            );

            DataBase.DataStore.products.Add( product );
        }

        // READ
        public List<Product> GetProducts()
        {
            if (DataBase.DataStore.products.Count > 0)
            {
                return DataBase.DataStore.products;
            }
            return new List<Product>();
        }
    }
}
