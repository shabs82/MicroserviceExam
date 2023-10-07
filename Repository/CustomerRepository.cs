using CustomerApi.Model;

namespace CustomerApi.Repository
{
    public class CustomerRepository
    {
        private readonly List<Customer> _customers;
        public CustomerRepository()
        {

         _customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John" },
            new Customer { Id = 2, Name = "Alice" },
            // Add more customers as needed
        };
        }

        public Customer GetCustomerByName1(String customerName)
        {
            return _customers.FirstOrDefault(c => c.Name == customerName);
        }
    }
}
