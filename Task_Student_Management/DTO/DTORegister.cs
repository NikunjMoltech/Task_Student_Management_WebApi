using Microsoft.EntityFrameworkCore;

namespace Task_Student_Management.DTO
{
    public class DTORegister
    {
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string hobbies { get; set; }
        public string country { get; set; }
    }
}
