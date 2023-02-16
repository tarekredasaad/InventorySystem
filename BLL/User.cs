using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIl
{
    public class User : Person
    {
        // public static int ID;
        public string UserName { get; set; }
        private string Password { get; set; }
        public string Email { get; set; }
        /*public User(string name, int age, Sex sex, string phone, string password, string email,string userName):base(++ID,name,age,sex,phone)
        {
            UserName = userName;
            Password = password;
            Email= email;
        }*/


    }
}
