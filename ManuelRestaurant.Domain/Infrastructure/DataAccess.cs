using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelRestaurant.Domain.Infrastructure
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {
            Database.SetInitializer(
                new ManuelRestaurant.Domain.Infrastructure.DataInitializers()
            );
        }

        public DbSet<Models.User> Users { get; set; }
   }
}
