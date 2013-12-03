using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WebAPITest.Models;
using WebAPITest.Repository;

namespace WebAPITest.Controllers
{
    public class ProductController : ApiController
    {

        //private IProductRepository _repository = new ProductRepository();
        private readonly IProductRepository _IProductRepository;

        public ProductController(IProductRepository iProductIProductRepository)
        {
            _IProductRepository = iProductIProductRepository;
        }

        // GET api/product
        public IEnumerable<ProductModel> Get()
        {
            return _IProductRepository.GetProducts();
            //return _products;
        }

        // GET api/product/5
        public IHttpActionResult Get(int id)
        {
            var temp = _IProductRepository.GetProduct(id);
            if (temp == null)
            {
                return NotFound();
            }
            return Ok(temp);
        }

        // POST api/product
        public IHttpActionResult Post([FromBody]string value)
        {
            var temp = new ProductModel() { Name = value };
            var result = _IProductRepository.CreateProduct(temp);
            if (result > 0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // PUT api/product/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            var temp = new ProductModel() { Id = id, Name = value };
            var result =_IProductRepository.UpdateProduct(temp);
            if (result > 0)
            {
                return Ok();
            }
            else
            {
                return NotFound();                 
            }
        }

        // DELETE api/product/5
        public IHttpActionResult Delete(int id)
        {
            var result = _IProductRepository.DeleteProduct(id);
            if (result > 0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
