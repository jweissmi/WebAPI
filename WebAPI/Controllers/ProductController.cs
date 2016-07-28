using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductController : ApiController
    {

        Product[] products = new Product[]{
            new Product {ID = 10, Name = "Paddle", Category = "Supplies", Price = 14.50, InStock = true },
            new Product { ID = 11, Name = "Kayak", Category = "Boats", Price = 300.00, InStock = true },
            new Product { ID = 12, Name = "Life Jacket", Category = "Safety", Price = 150.00, InStock = true },
            new Product { ID = 13, Name = "Paddle", Category = "Supplies", Price = 7.25, InStock = false },
            new Product { ID = 14, Name = "Vest", Category = "Safety", Price = 70.00, InStock = false },
            new Product { ID = 15, Name = "Canoe", Category = "Boats", Price = 525.00, InStock = true },
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProductByID(int ID)
        {
            var product = products.FirstOrDefault(p => p.ID == ID);
            if (products == null)
                return NotFound();
            else
                return Ok(product);
        }
    }
}
