using DIDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoAPI.Services
{
    public class AnotherProductService : IProductService
    {
        public IList<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{ Id = 2, Name="another product A", Price=200},
                new Product{ Id = 3, Name="another product C", Price=300},
            };
        }
    }
}
