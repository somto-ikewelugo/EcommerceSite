using EcommerceSite.Entities.Dtos;
using EcommerceSite.Interfaces;
using EcommerceSite.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceSite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ProductsViewModel _productsViewModel;

        public ProductController(IProductService productService, ProductsViewModel productsViewModel)
        {
            _productService = productService;
            _productsViewModel = productsViewModel;
        }

        public IActionResult ProductDisplay()
        {
            _productsViewModel.products = _productService.GetProducts();
            return View(_productsViewModel);
        }

        public IActionResult CreateProduct(ProductCreationDto creationDto)
        {

            _productService.Create(creationDto);
            return RedirectToAction("ProductsDisplay", "Product");
        }

        public IActionResult ProductCreatePage()
        {
            return View("CreateProduct");
        }

        public IActionResult DeleteProduct(string id)
        {

            _productService.DeleteProduct(id);
            return RedirectToAction("ProductsDisplay", "Product");
        }

        public IActionResult UpdateProduct(ProductUpdateDto updateDto)
        {
            _productService.UpdateProduct(updateDto);
            return RedirectToAction("ProductDisplay", "Product");
        }

        public IActionResult ProductUpdateView(string id)
        {
            var product = DataBase.DataStore.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            var updateDto = new ProductUpdateDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity
            };

            return View("UpdateProduct", updateDto);
        }
    }
}

