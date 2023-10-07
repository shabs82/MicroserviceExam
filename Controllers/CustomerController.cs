//using CustomerApi.Repository;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using CustomerApi.Model;
using CustomerApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
 {
    // CustomersController.cs
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _repository;

        public CustomerController(CustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{customerName}/bought-products")]
        public IActionResult GetBoughtProducts(String customerName)
        {
            var customer = _repository.GetCustomerByName1(customerName);

            if (customer == null)
            {
                return NotFound();
            }

            // Here, you would retrieve and return the customer's bought products.
            // You can replace this with your actual logic to fetch products.

            var boughtProducts = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.99m },
            new Product { Id = 2, Name = "Product 2", Price = 20.99m },
            // Add products based on customer's history
        };

            return Ok(boughtProducts);
        }
    }

}
