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

        public IActionResult Intervention(string columnId, string elevatorId, string buildingId, string batteryId)
        {
            var user_email = _userManager.GetUserName(User);
            var customer = _productService.getFullCustomerInfo(user_email);

            ViewBag.ColumnId = columnId;
            ViewBag.ElevatorId = elevatorId;
            ViewBag.BuildingId = buildingId;
            ViewBag.BatteryId = batteryId;
            ViewBag.Customer = customer;

            return View();
        }

        public IActionResult Products(string columnId, string elevatorId, string buildingId, string batteryId)
        {
            var user_email = _userManager.GetUserName(User);
            var customer = _productService.getFullCustomerInfo(user_email);

            ViewBag.ColumnId = columnId;
            ViewBag.ElevatorId = elevatorId;
            ViewBag.BuildingId = buildingId;
            ViewBag.BatteryId = batteryId;
            ViewBag.Customer = customer;

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

            var customer = _productService.getFullCustomerInfo(user_email);

            return View("~/Views/Home/Products.cshtml", customer);
        }
    }
}
