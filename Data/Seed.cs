using HuskMock.Data.Entities;
using HuskMock.Models;
using Microsoft.EntityFrameworkCore;

namespace HuskMock.Data
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HuskMockDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HuskMockDBContext>>()))
            {

                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Product()
                    {
                        Category = "Clothing",
                        Title = "Long Sleeve Shirt",
                        View = "LongSleeve",
                        Size = "M",
                        Color = "Black",
                        Price = 50,
                        SalePrice = 40,
                        Sale = true,
                        Stock = 100,
                        PicWay = "LongSleeve"
                    },
                    new Product()
                    {
                        Category = "Hammock",
                        Title = "Double Pack",
                        View = "DoublePack",
                        Size = "OneSize",
                        Color = "Black",
                        Price = 70,
                        SalePrice = 50,
                        Sale = false,
                        Stock = 100,
                        PicWay = "DoublePack"
                    },
                    new Product()
                    {
                        Category = "Hammock",
                        Title = "Double Sack",
                        View = "DoubleSack",
                        Size = "OneSize",
                        Color = "Green",
                        Price = 70,
                        SalePrice = 50,
                        Sale = false,
                        Stock = 100,
                        PicWay = "DoubleSack"
                    },
                    new Product()
                    {
                        Category = "Home",
                        Title = "Cup",
                        View = "Cup",
                        Size = "OneSize",
                        Color = "White",
                        Price = 20,
                        SalePrice = 10,
                        Sale = false,
                        Stock = 100,
                        PicWay = "Cup"
                    }
                    //new Product()
                    //{
                    //    Category = "Clothing",
                    //    Title = "LongSleeve",
                    //    Size = "LASSE",
                    //    Color = "Black",
                    //    Price = 112,
                    //    Sale = false,
                    //    Stock = 100,
                    //}
                    );

                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

              
                context.SaveChanges();
            }
        }
    }
}
