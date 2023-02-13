using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using HuskMock.Data.Entities;
using HuskMock.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace HuskMock.Data
{
    public class HuskMockDBContext : IdentityDbContext
    {		public HuskMockDBContext(DbContextOptions<HuskMockDBContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }    
    }
}
