using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Database;
using labki.Entities;
using labki.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace labki.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;

        public ProductService(AppDbContext dbContext, IHttpContextAccessor accessor, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _httpContextAccessor = accessor;
            _userManager = userManager;
        }
        public async Task Add(ProductModel product)
        {
            // obecnie zalogowany user
            var currentUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);


            var entity = new ProductEntity
            {
                Name = product.Name,
                Description = product.Description,
                IsVisible = product.IsVisible,
                Owner = currentUser,
            };
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<ProductEntity>> GetAll(string name)
        {
           // var currentUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            IQueryable<ProductEntity> productsQuery = _dbContext.Products;
          //  productsQuery = productsQuery.Where(x => x.Owner == currentUser);

            if (!string.IsNullOrEmpty(name))
            {
                productsQuery = productsQuery.Where(x => x.Name.Contains(name));
            }
            var products = await productsQuery.ToListAsync();
            return products;

        }
    }
}
