using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoxControlAdminTools
{

    public class User
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public int Employee_ID { get; set; }    
        public bool Admin { get; set; }
        public bool Delivery { get; set; }
        public bool Client { get; set; }
        public bool Hr { get; set; }
        public bool Blocked { get; set; }
    }
}
