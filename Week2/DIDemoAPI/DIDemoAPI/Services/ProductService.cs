using DIDemoAPI.Data;
using DIDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoAPI.Services
{
    public class ProductService : IProductService
    {
        private MiniDBContext miniDBContext;

        public ProductService(MiniDBContext miniDBContext)
        {
            this.miniDBContext = miniDBContext;  
        }
        public IList<Product> GetProducts()
        {
            return miniDBContext.Products.ToList();
        }
    }
}
