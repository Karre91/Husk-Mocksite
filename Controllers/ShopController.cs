using HuskMock.Data;
using HuskMock.Data.Entities;
using HuskMock.Models;
using HuskMock.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace HuskMock.Controllers
{
    //[Route("api/Controller")]
    public class ShopController : Controller
    {
        private readonly HuskMockDBContext _db;   

        //TEST
        private OrderItem? _orderItem;
        private Product? _product;

        public ShopController(HuskMockDBContext? db)
        {
            _db = db;
        }

        //-- All the Get --//
        [HttpGet("Shop")]
        public IActionResult Shop()
        {
            IEnumerable<Product> products = _db.Products;
            return View(products);
        }

        [HttpGet("Longsleeve")]
        public IActionResult LongSleeve()
        {
            return View();
        }

        [HttpGet("Cup")]
        public IActionResult Cup()
        {
            return View();
        }

        [HttpGet("Double-Pack")]
        public IActionResult DoublePack()
        {
            return View();
        }

        [HttpGet("Double-Sack")]
        public IActionResult DoubleSack()
        {
            return View();
        }

        // -- All the Post --


        [HttpPost("Longsleeve")]
        public IActionResult LongSleeve(OrderItem item)
        {
            doSomething(item, 1);

            return View();
        }

        [HttpPost("Double-Pack")]
        public IActionResult DoublePack(OrderItem item)
        {
            doSomething(item, 2);

            return View();
        }

        [HttpPost("Double-Sack")]
        public IActionResult DoubleSack(OrderItem item)
        {
            doSomething(item, 3);
            
                return View();
        }

        [HttpPost("Cup")]
        public IActionResult Cup(OrderItem item)
        {
            doSomething(item, 4);

            return View();
        }

        public bool doSomething(OrderItem  item, int id)
        {
            if (item == null)
            {
                return false;
            }
            var product = _db.Products.Find(id);
            _orderItem = new();
            _orderItem.Quantity = item.Quantity;
            _orderItem.UnitPrice = product.Price * item.Quantity;
            _orderItem.ProductId = id;
            _db.OrderItems.Add(_orderItem);
            _db.SaveChangesAsync();
            ViewBag.UserMessage = "Added";
            ModelState.Clear();
            return true;
        }
    }
}
