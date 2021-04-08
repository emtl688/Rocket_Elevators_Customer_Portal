using Rocket_Elevators_Customer_Portal.Areas.Identity.Data;
using Rocket_Elevators_Customer_Portal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductService _productService = new ProductService();
        private readonly UserManager<ApplicationUser> _userManager; // current user

        public HomeController(
            ILogger<HomeController> logger,
            UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager; // code for UserManager from Areas\Identity\Pages\Account\Manage\ChangePassword.cshtml.cs
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Action to render the Intervention Form page
        public IActionResult Intervention()
        {
            return View();
        }

        // Action to render the Products page
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult UpdateCompanyInfo()
        {
            var user_email = _userManager.GetUserName(User);
            var customer = _productService.getFullCustomerInfo(user_email);

            ViewBag.customer = customer;

            return View();
        }

        public IActionResult getFullCustomerInfo()
        {
            var user_email = _userManager.GetUserName(User);
            Console.WriteLine("email: " + user_email);

            var customer = _productService.getFullCustomerInfo(user_email);

            Console.WriteLine("Called getFullCustomerInfo");

            _logger.LogInformation(" !!! CALLED FUNCTION getFullCustomerInfo !!! ");

            return View("~/Views/Home/Products.cshtml", customer);
        }
    }
}
