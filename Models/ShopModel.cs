using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static System.Net.WebRequestMethods;

namespace HuskMock.Models
{
    public class ShopModel
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string View { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }
        public bool Sale { get; set; }
        public int Stock { get; set; }
        public string PicWay { get; set; }

    }

}
