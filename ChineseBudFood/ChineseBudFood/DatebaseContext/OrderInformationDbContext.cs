using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ChineseBudFood.DatebaseContext
{
    public class OrderInformationDbContext:DbContext
    {
        public OrderInformationDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<ChineseBudFood.Models.OrderInformation> OrderInformations { get; set; }
    }
}