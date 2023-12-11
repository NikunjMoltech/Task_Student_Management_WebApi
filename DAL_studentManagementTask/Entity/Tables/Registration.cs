using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_studentManagementTask.Entity.Tables
{
    public class Registration
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; } 
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Hobbies { get; set; }
        public string Country { get; set; }



    }
}
