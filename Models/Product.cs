using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Product 
    {
        private readonly ILogger<Product> _logger;


        private readonly HttpClient _httpClient = new HttpClient();

        public Product()
        {
            var serviceProvider = new ServiceCollection()
                      .AddLogging()
                      .BuildServiceProvider();
            _logger = serviceProvider.GetService<ILoggerFactory>()
                        .CreateLogger<Product>();
        }

        // // ========== Function that calls endpoint /api/Customers/id to get all the data from the customer that is logged at the portal ============
        public Customer getFullCustomerInfo(string email)
        {
            var result = _httpClient.GetAsync("https://rocketelevators-em.azurewebsites.net/api/Customer/" + email).Result;
            var contentBody = result.Content.ReadAsStringAsync().Result;

            Customer customer = JsonConvert.DeserializeObject<Customer>(contentBody);

            _logger.LogInformation("customer email: {}", customer.EmailOfCompanyContact);
            _logger.LogInformation("customer buildings: {}", customer.Buildings);
            Console.WriteLine("---Display Customer Info---");
            Console.WriteLine(customer.Buildings.Count);

            return customer;
        }
    }
}

