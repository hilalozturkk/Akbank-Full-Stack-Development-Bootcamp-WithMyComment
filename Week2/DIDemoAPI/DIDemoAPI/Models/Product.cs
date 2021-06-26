using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoAPI.Models
{//The product model contains the entities we store in the database
    //entity -> one product
    public class Product
    {
        public int Id { get; set; }

        [Required]//
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? StockCount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public float? Discount { get; set; }// ? -> nullable
        public string ImageUrl { get; set; }
    }
}
