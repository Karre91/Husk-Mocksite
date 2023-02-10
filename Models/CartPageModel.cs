using HuskMock.Data;
using HuskMock.Data.Entities;
using System.Collections.Generic;

namespace HuskMock.Models
{
    public class CartPageModel
    {
        public Product Model1 { get; set; }
        public OrderItem Model2 { get; set; }

        private readonly HuskMockDBContext _db;
        public CartPageModel(HuskMockDBContext db)
        {
            _db = db;
        }
        public List<Tuple<OrderItem, Product>> LALA()
        {
            IEnumerable<OrderItem> order = _db.OrderItems;
            List<Tuple<OrderItem, Product>> orderAndProduct = new List<Tuple<OrderItem, Product>>();

            foreach (OrderItem item in order)
            {
                Product product = _db.Products.Find(item.ProductId);
                Tuple<OrderItem, Product> My_Tuple = new Tuple<OrderItem, Product>(item, product);

                orderAndProduct.Add(My_Tuple);                
            }
            return orderAndProduct;
        }
    }
}
