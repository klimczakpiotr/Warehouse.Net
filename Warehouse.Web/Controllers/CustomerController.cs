using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Application.Interfaces;
using Warehouse.Application.ViewModels.Customer;

namespace Warehouse.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _custService;
        public CustomerController(ICustomerService custService)
        {
            _custService = custService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _custService.GetAllCustomersForList(5, 1, "");
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _custService.GetAllCustomersForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View(new NewCustomerVm());
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCustomer(NewCustomerVm model)
        {
            if (ModelState.IsValid)
            {
                var id = _custService.AddCustomer(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult EditCustomer(int id)
        {
            var customer = _custService.GetCustomerForEdit(id);
            return View(customer);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCustomer(NewCustomerVm model)
        {
            if (ModelState.IsValid)
            {
                _custService.UpdateCustomer(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddNewAddressForClient(int customerId)
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddNewAddressForClient(AddressModel model)
        //{
        //    return View();
        //}

        public IActionResult ViewCustomer(int Id)
        {
            var customerModel = _custService.GetCustomerDetails(Id);
            return View(customerModel);
        }

        [Authorize]
        public IActionResult DeleteCustomer(int id)
        {
            _custService.DeleteCustomer(id);
            return RedirectToAction("Index");
        }
    }
}
