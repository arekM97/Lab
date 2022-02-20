using System.Linq;
using System.Threading.Tasks;
using labki.Database;
using labki.Entities;
using labki.Models;
using labki.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace labki.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;


        //wstrzykiwanie poprzez konstruktor
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductModel product)
        {
            //var entity = new ProductEntity
            //{
            //    Name= product.Name,
            //    Description = product.Description,
            //    IsVisible = product.IsVisible,
            //};
            //await _dbContext.AddAsync(entity);
            //await _dbContext.SaveChangesAsync();

            await _productService.Add(product);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> List(string name)
        {
            //IQueryable<ProductEntity> productsQuery = _dbContext.Products;
            //if (!string.IsNullOrEmpty(name))
            //{
            //    productsQuery = productsQuery.Where(x => x.Name.Contains(name));
            //}
            //var products = await productsQuery.ToListAsync();
            var products = await _productService.GetAll(name);
            return View(products);
        }
    }
}
