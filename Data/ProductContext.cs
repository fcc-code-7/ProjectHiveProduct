using Microsoft.AspNet.Identity.EntityFramework;
using ProWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProWeb.Data
{
    public class ProductContext : IdentityDbContext<ApplicationUser>
    {
        public ProductContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ProductContext Create()
        {
            return new ProductContext();
        }

        public DbSet<Product> Products { get; set; }
    }
}
