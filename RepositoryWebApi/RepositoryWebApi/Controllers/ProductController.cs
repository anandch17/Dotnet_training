using Microsoft.AspNetCore.Mvc;
using RepositoryWebApi.Models;
using RepositoryWebApi.Repository;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RepositoryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productRepository.GetProducts();
            return Ok(products);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product=_productRepository.GetProductById(id);
            
            return new OkObjectResult(product);
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            using(var scope=new TransactionScope())
            {
                _productRepository.InsertProduct(product);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
                // Use the productRepository to perform operations
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("Product ID mismatch.");
            }
            try
            {
                _productRepository.UpdateProduct(product);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"Product with id {id} not found.");
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _productRepository.DeleteProduct(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"Product with id {id} not found.");
            }
        }
    }
}
