using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Services;
using Warehouse.Web.Models;

namespace Warehouse.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemService _itemService;

        public HomeController(ILogger<HomeController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var items = _itemService.GetAllItems();
            return View(items);
        }

        [Route("Items/All")]
        public IActionResult ViewListOfItems(int id)
        {
            //List<Item> items = new List<Item>();
            //items.Add(new Item() { Id = 1, Name = "Apple", TypeName = "Grocery" });
            //items.Add(new Item() { Id = 2, Name = "Strawberry", TypeName = "Grocery" });
            //items.Add(new Item() { Id = 3, Name = "Pineapple", TypeName = "Grocery" });
            //items.Add(new Item() { Id = 4, Name = "TV", TypeName = "Electronics" });
            //items.Add(new Item() { Id = 5, Name = "PS5", TypeName = "Electronics" });
            //items.Add(new Item() { Id = 6, Name = "\"Harry Potter\"", TypeName = "Books" });
            //items.Add(new Item() { Id = 7, Name = "\"Alice in Wonderland\"", TypeName = "Books" });
            var items = _itemService.GetAllItems();

            return View(items); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}