using ManuelRestaurant.Domain.Infrastructure;
using ManuelRestaurant.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelRestaurant.Domain.BLL
{
    public static class UsersBLL
    {
        private static DataAccess db = new DataAccess();

        public static List<User> GetAll()
        {
            return db.Users.ToList();
        }    
    }
}
