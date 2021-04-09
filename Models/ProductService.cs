using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class ProductService 
    {
        private readonly ILogger<ProductService> _logger;


        private readonly HttpClient _httpClient = new HttpClient();

        public ProductService()
        {
            var serviceProvider = new ServiceCollection()
                      .AddLogging()
                      .BuildServiceProvider();
            _logger = serviceProvider.GetService<ILoggerFactory>()
                        .CreateLogger<ProductService>();
        }

        public Customer getFullCustomerInfo(string email)
        {
            var result = _httpClient.GetAsync("https://rocketelevators-em.azurewebsites.net/api/Customers/" + email).Result;
            var contentBody = result.Content.ReadAsStringAsync().Result;

            Customer customer = JsonConvert.DeserializeObject<Customer>(contentBody);

            _logger.LogInformation("customer email: {}", customer.EmailOfCompanyContact);
            _logger.LogInformation("customer buildings: {}", customer.Buildings);
            Console.WriteLine(" ============ all the CUSTOMER infos are here!!! ============ ");
            Console.WriteLine(customer.Buildings.Count);

            return customer;
        }
    }
}

