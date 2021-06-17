using IntroWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Business
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts() // get all product 
        {
            List<Product> products = new List<Product>() {

             new Product
             {
                 Id = 2,
                 Name="Daxtors",
                 Description="Sport sneakers",
                 Price=107,
                 Discount=0.25f,
                 ImageUrl="/picture1.jpf",
                 IsActive=true,
                 Stock=100,
                 CreatedDate=DateTime.Now

             },

             new Product
             {
                 Id = 3,
                 Name="Adidas"
                 ,Description="Sport sneakers",
                 Price=250,
                 Discount=0.23f,
                 ImageUrl="/picture1.jpf",
                 IsActive=false,
                 Stock=1000,
                 CreatedDate= new DateTime(2021,1,1)
             },

            };
            products.Add(new Product
            {
                Id = 1,
                Name = "Solante",
                Description = "Sun lotion",
                Price = 100,
                Discount = 0.15f,
                IsActive = true,
                Stock = 300,
                CreatedDate = new DateTime(2021, 3, 6)
            });
            return products;
        }
    }
}
