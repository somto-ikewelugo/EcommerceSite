using EcommerceSite.Entities;
using EcommerceSite.Entities.Dtos;
using EcommerceSite.Interfaces;
using Microsoft.Extensions.Logging;

namespace EcommerceSite.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        public static int id = 2;

        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        // CRUD = CREATE, READ, UPDATE, DELETE


        // CREATE
        public void Create(ProductCreationDto productCreationDto)
        {
            try
            {
                Product product = new Product(
                    productCreationDto.Name,
                    productCreationDto.Description,
                    productCreationDto.Price,
                    productCreationDto.Quantity
                );

                DataBase.DataStore.products.Add(product);
                _logger.LogInformation("Product created successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occured while creating Product {} {}", ex.Message, ex);
            }
              
        }

        // READ
        public List<Product> GetProducts()
        {
            if (DataBase.DataStore.products.Count() > 0)
            {
                try
                {
                    List<Product> products = DataBase.DataStore.products;
                    _logger.LogInformation("Products returned successfully");
                    return products;
                }
                catch (Exception ex)
                { 
                    _logger.LogError("Error occurred while fetching product {} {}", ex.Message,ex);
                }

            }
            return new List<Product>();
        }

        // UPDATE
        public void UpdateProduct(ProductUpdateDto updateDto)
        {
            if (DataBase.DataStore.products.Count() > 0)
            {
                try
                {
                    Product product = DataBase.DataStore.products.Where(p => p.Id == updateDto.Id).FirstOrDefault();
                    _logger.LogInformation("Product to be deleted: {}", product);
                    if (product != null)
                    {
                        mapDtoToEntity(updateDto, product);
                    }
                    _logger.LogInformation("Products with id " + updateDto.Id + " updated successfully");
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError("Error occurred while updating book {} {}", ex.Message, ex);
                    }
                }
            }
        

        // DELETE
        public void DeleteProduct(string id)
        {
            if (DataBase.DataStore.products.Count() > 0)
            {
                try
                {
                    Product productToBeDeleted = DataBase.DataStore.products.Where(p => p.Id == id).FirstOrDefault();
                    _logger.LogInformation("Products to be deleted: {}", productToBeDeleted);
                    if (productToBeDeleted != null)
                    {
                        DataBase.DataStore.products.Remove(productToBeDeleted);
                    }
                    _logger.LogInformation("Books with id " + id + " deleted successfully");
                }
                catch (Exception ex)
                {
                    _logger.LogError("Error occurred while deleting product {} {}", ex.Message, ex);
                }
            }
        }

        private void mapDtoToEntity(ProductUpdateDto dto, Product product)
        {
            if (!string.IsNullOrEmpty(dto.Name)) product.Name = dto.Name;
            if (!string.IsNullOrEmpty(dto.Description)) product.Description = dto.Description;
            if (!string.IsNullOrEmpty(dto.Price.ToString())) product.Price = dto.Price;
            if (!string.IsNullOrEmpty(dto.Quantity.ToString())) product.Quantity = dto.Quantity;
        }
    }
}
