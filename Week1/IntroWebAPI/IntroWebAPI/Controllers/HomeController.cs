using IntroWebAPI.Business;
using IntroWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // request will come here , return response 
        // GET - POST

        [HttpGet] //if Get request come
        public IActionResult AllProducts()
        {
            ProductService dataService = new ProductService();
            var list = dataService.GetListResponseDTOs();
            return Ok(list);
        }

        [HttpGet("{id}")]//attribute 
        public IActionResult GetProductById(int id)
        {
            ProductService dataservice = new ProductService();
            var product = dataservice.GetProductResponseDTO(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            //suppose add db
            return CreatedAtAction(nameof(GetProductById), new { id = 3 }, null);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Product product)
        { //Update here
            return Ok();
        }
    }
}
