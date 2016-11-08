using MvcWebApiTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;


namespace MvcWebApiTest.Controllers
{
    [RoutePrefix("api/v1/reactions")]
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return products;
        //}

        //[System.Web.Mvc.HttpGet]
        //public HttpResponseMessage Get()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, products);
        //}

        [Route("")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [Route("")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, products);
        }


    }
}
