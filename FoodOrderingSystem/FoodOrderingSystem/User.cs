using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem
{   
     internal class User
    {
        public static int userIndex = 0;
        public static User[] users = new User[100];
        public String username { get; set; }
        public String Password { get; set; }
    }
}
