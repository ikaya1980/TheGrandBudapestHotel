using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheGrandBudapestHotel.Data;
using TheGrandBudapestHotel.Core;

namespace TheGrandBudapestHotel.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerData customerData;

        public CustomerController(ICustomerData _customerData)
        {
            
            customerData = _customerData;
        }


        public IActionResult Index()
        {
            return View(customerData.GetCustomers());
        }

        public IActionResult Apply()
        {
            return View();

        }


        [HttpPost]
        public IActionResult Apply(Customer customer)
        {
            if(!customer.Validate())
            {
                ModelState.AddModelError("Validate", "Customer bilgisi uygun değildir.");
                return new BadRequestObjectResult(ModelState);

            }

            customerData.Add(customer);

            return View("Index", customerData.GetCustomers());

        }


    }
}