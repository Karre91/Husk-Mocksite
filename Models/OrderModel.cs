using HuskMock.Models;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace HuskMock.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }

        public string MyItem { get; set; }
    }
}
