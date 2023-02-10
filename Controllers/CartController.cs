using HuskMock.Data;
using HuskMock.Data.Entities;
using HuskMock.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace HuskMock.Controllers
{
    public class CartController : Controller
    {
        private readonly HuskMockDBContext _db;
        public CartPageModel CartPageModel { get; set; }

        public CartController(HuskMockDBContext db)
        {
            _db = db;
        }

        [HttpGet("Cart")]
        public IActionResult Cart()
        {
            IEnumerable<OrderItem> order = _db.OrderItems;
            List<Tuple<OrderItem, Product>> orderAndProduct = new List<Tuple<OrderItem, Product>>();

            foreach (OrderItem item in order)
            {
                Product product = _db.Products.Find(item.ProductId);
                Tuple<OrderItem, Product> My_Tuple = new Tuple<OrderItem, Product>(item, product);

                orderAndProduct.Add(My_Tuple);
            }
            return View(orderAndProduct);
        }

        [HttpPost("Cart")]
        public IActionResult Cart(int id)
        {
            IEnumerable<OrderItem> order = _db.OrderItems;
           
            foreach (OrderItem item in order)
            {
                if (item.Id == id)
                {
                    _db.OrderItems.Remove(item);
                }

                _db.SaveChanges();               
            }
            return Cart();
        }
    }
}
