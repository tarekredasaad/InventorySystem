using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL

{
    public class Supplier
    {
        public int ID;
        public string Name;
        public string City;
        public string Phone;
        public string Email;
        private string password;

        private string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 6)
                {
                    password = value;
                }
                else
                {
                    throw new Exception("Password must be at least 6 characters");
                }
            }
        }


        public string addSupplier(int id, string name, string city, string email, string phone)
        {
            ID = id;
            Name = name;
            City = city;
            Email = email;
            Phone = phone;
            return "New Supplier Added.";
        }

        public string editSupplier(int id, string name)
        {
            ID = id;
            Name = name;
            return "Supplier Info Updated.";
        }

        public string deleteSupplier()
        {
            return "Supplier Deleted.";
        }


        public bool searchSupplier(Supplier s)
        {
            return true;
        }


    }
}
