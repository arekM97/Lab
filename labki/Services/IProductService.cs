using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Entities;
using labki.Models;

namespace labki.Services
{
    public interface IProductService
    {
        public Task Add(ProductModel product);
        public Task<IEnumerable<ProductEntity>> GetAll(string name);
    }
}
