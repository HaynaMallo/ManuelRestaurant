using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelRestaurant.Domain.Infrastructure
{
    public class DataInitializers : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataAccess>
    {
        protected override void Seed(DataAccess db)
        {
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Manuel",
                    LastName = "DelRosario",
                    Password = "Midr2017",
                    UserName = "Ynnah",
                    Role = Models.Enums.Role.Admin
                }
            );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "Hayna",
                     LastName = "Mallo",
                     Password = "Midr2017",
                     UserName = "Hayna",
                     Role = Models.Enums.Role.Admin
                 }
             );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "PauleneLiah",
                     LastName = "Mallo",
                     Password = "Midr2017",
                     UserName = "Poleng",
                     Role = Models.Enums.Role.Waiter
                 }
             );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "Harley",
                     LastName = "Mallo",
                     Password = "Midr2017",
                     UserName = "Boy",
                     Role = Models.Enums.Role.Waiter
                 }
             );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "Hilda",
                     LastName = "Mallo",
                     Password = "Midr2017",
                     UserName = "Dhang",
                     Role = Models.Enums.Role.Cashier
                 }
             );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "Hayna",
                     LastName = "Mallo",
                     Password = "Midr2017",
                     UserName = "Hayna",
                     Role = Models.Enums.Role.Cashier
                 }
             );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "Hazel",
                     LastName = "Mallo",
                     Password = "Midr2017",
                     UserName = "zel",
                     Role = Models.Enums.Role.Chef
                 }
             );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "James",
                     LastName = "Mallo",
                     Password = "Midr2017",
                     UserName = "elise",
                     Role = Models.Enums.Role.Chef
                 }
             );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "khaye",
                     LastName = "Mallo",
                     Password = "Midr2017",
                     UserName = "kc",
                     Role = Models.Enums.Role.InventoryController
                 }
             );
            db.SaveChanges();

            db.Users.Add(
                 new Models.User()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "Danica",
                     LastName = "Manuel",
                     Password = "Midr2017",
                     UserName = "nica",
                     Role = Models.Enums.Role.InventoryController

                 }
             );
            db.SaveChanges();
        }
    }
}
