using IntroWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Business
{
    public class ProductService
    {
        // This class will take data from DB,API,,,vs.
        public List<ProductListResponseDTO> GetListResponseDTOs()
        {
            
            ProductRepository repo = new ProductRepository();
            var products = repo.GetAllProducts();


            List<ProductListResponseDTO> dtoList = new List<ProductListResponseDTO>();

            foreach (var item in products)
            {
                //initialize ->

                var dto = new ProductListResponseDTO
                {
                    Description = item.Description,
                    Discount = item.Discount,
                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    Name = item.Name,
                    Price = item.Price,
                    Rating = item.Ratig
                };
                dtoList.Add(dto);
            }
            return dtoList;//just 
        }

        public Product GetProductResponseDTO(int id)
        {
            ProductRepository repo = new ProductRepository();
            var products = repo.GetAllProducts();
            //return true if the Id in the product is equal to the parameter id, otherwise return null.
            return products.FirstOrDefault(p => p.Id == id);
         
        }
    }
}
