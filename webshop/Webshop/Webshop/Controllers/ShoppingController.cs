using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webshop.Repositories;

namespace Webshop.Controllers
{
    [Route("")]
    public class ShoppingController : Controller
    {
        private ProductRepository productRepository;

        public ShoppingController(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [Route("")]
        [Route("/warehouse")]
        [HttpGet]
        public IActionResult ShoppingPlanner()
        {
            return View(productRepository.ListAll());
        }

        [Route("/warehouse/summary")]
        [HttpGet]
        public IActionResult Summary([FromQuery]string itemname, [FromQuery]string size, [FromQuery]int amount)
        {
            return View(productRepository.Selected(itemname, size, amount));
        }

        [Route("/warehouse/summary")]
        [HttpPost]
        public IActionResult WareHouseSummary()
        {
            return RedirectToAction("Summary");
        }

        [Route("/warehouse/query")]
        [HttpGet]
        public IActionResult WarehouseQuery([FromQuery]int price, [FromQuery]string type)
        {
            return Json(new { result = "ok" });
        }
    }
}
