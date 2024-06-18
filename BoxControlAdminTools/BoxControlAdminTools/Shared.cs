using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxControlAdminTools
{
    public static class Shared
    {
        public static User Demo_user {  get; set; }

        public static bool demo { get; set; }
        public static User Active_user {  get; set; }

        public static List<User> Demo_users { get; set; }



        public static void  InitDemo_user()
        {
            Demo_user = new User();
            Demo_user.Id = 1;
            Demo_user.Username = "Demo user";
            Demo_user.Password = "pass1";
            Demo_user.Employee_ID = 101;
            Demo_user.Admin = true;
            Demo_user.Delivery = false;
            Demo_user.Client = false;
            Demo_user.Hr = true;
            Demo_user.Blocked = false;
 
        }

        public static void Clean_Users()
        {
            Demo_users = new List<User>();
        }
            public static void Load_Users()
        {
            Demo_users = new List<User>
        {
            new User
            {
                Id = 1,
                Username = "user1",
                Password = "pass1",
                Employee_ID = 101,
                Admin = true,
                Delivery = false,
                Client = false,
                Hr = true,
                Blocked = false
            },
            new User
            {
                Id = 2,
                Username = "user2",
                Password = "pass2",
                Employee_ID = 102,
                Admin = false,
                Delivery = true,
                Client = false,
                Hr = false,
                Blocked = false
            },
            new User
            {
                Id = 3,
                Username = "user3",
                Password = "pass3",
                Employee_ID = 103,
                Admin = false,
                Delivery = false,
                Client = true,
                Hr = false,
                Blocked = true
            },
        };
        }
    }
}
