using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProductController : ApiController
    {
        private Product[] products = new[] { 
            new Product {name = "Kajak", description = "lodka przeznaczona dla jednej osoby " , category = "Sporty wodne", price = 25, id = "116cf04ffa29e87a"},
            new Product {name = "Kamizelka ratunkowa", description = "Z tą rzecza nie utoniesz" , category = "Sporty wodne", price = 74, id = "216cf04ffa29e87a"},
            new Product {name = "Flagi narożne", description = "Zawsze stoja w boku boiska" , category = "Piłka nozna", price = 43, id = "316cf04ffa29e87a"},
            new Product {name = "Stadion", description = "Kazdy na nim gral" , category = "Piłka nozna", price = 897, id = "416cf04ffa29e87a"},
            new Product {name = "Czapka", description = "Dodaje duzo do inteligencji" , category = "Piłka nozna", price = 451, id = "416cf04ffa29e87a"},
            new Product {name = "Niestabilne krzesło", description = "Zmniejsza szanse przeciwnika.", category = "Szachy", price = 29.95, id = "416cf04ffa29e87a"},
            new Product {name = "Ludzka szachownica", description = "Przyjemna gra dla całej rodziny!" , category = "Szachy", price = 75, id = "416cf04ffa29e87a"},
            new Product {name = "Blyszczacy krol", description = "Pokryty złotem i wysadzany diamentami krol" , category = "Szachy", price = 1200, id = "416cf04ffa29e87a"},
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return this.products;
        }

        public IHttpActionResult GetProduct(string id)
        {
            var product = this.products.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        
        public IHttpActionResult AddProduct([FromBody]Product product)
        {
            var productsList = products.ToList();
            productsList.Add(product);
            return Ok();
        }
    }
}
