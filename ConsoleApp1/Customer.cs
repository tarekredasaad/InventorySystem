using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIl
{
    //public   struct Address
    //{
    //    public static string city;
    //    public string country;
    //    public string street;

    //}
    public class Customer : Person

    {
        //becouse it hide the proparty Id in base class
        //public static int ID;
        public string Address { get; set; }

        public List<Order> Order;



    }
}
