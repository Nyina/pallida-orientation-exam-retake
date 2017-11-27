using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webshop.Controllers
{
    [Route("")]
    public class ShoppingController : Controller
    {
        [Route("")]
        [Route("/shoppingplanner")]
        [HttpGet]
        public IActionResult ShoppingPlanner()
        {
            return View();
        }

        [Route("/summary")]
        [HttpGet]
        public IActionResult Summary()
        {
            return View();
        }

        [Route("/warehouse")]
        [HttpGet]
        public IActionResult Warehouse()
        {
            return Ok();
        }

        [Route("/warehouse/summary")]
        [HttpPost]
        public IActionResult WareHouseSummary()
        {
            return Ok();
        }

        [Route("/warehouse/query")]
        [HttpGet]
        public IActionResult WarehouseQuery()
        {
            return Ok();
        }
    }
}
