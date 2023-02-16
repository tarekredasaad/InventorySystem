/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Input;
using BLL;
using BIl;


namespace BLL
{
    public static class SampleData
    {
        public static List<Category> Categories = new List<Category>();
        public static List<Product> Products = new List<Product>();
        public static List<Order> Orders = new List<Order>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<User> Users = new List<User>();
        public static List<Supplier> Suppliers = new List<Supplier>();
        static SampleData() { 

            Users.Add(new User {Name = "Mohamed Makhzan" , UserName = "MohamedM5" , Email="MohamedM5@gmail.com", Age=25 , Phone="01067631594" ,Sex = Sex.Male });
            Users.Add(new User { Name = "Mahmoud Emad", UserName = "MahmoudE", Email = "MahmoudE@gmail.com", Age = 24, Phone = "01157528875", Sex = Sex.Male });
           


            Orders.Add(new Order { });
            Orders.Add(new Order { });
            Orders.Add(new Order { });


            Customers.Add(new Customer { });
            Customers.Add(new Customer { });
            Customers.Add(new Customer { });


            Suppliers.Add(new Supplier { });
            Suppliers.Add(new Supplier { });
            Suppliers.Add(new Supplier { });

            Categories.Add(new Category{ Id = 1 , Title="Mobiles"});
            Categories.Add(new Category { Id = 2 , Title = "Laptops"});
            Categories.Add(new Category { Id = 3 , Title = "Smart Watches"});
            Categories.Add(new Category { Id = 4, Title = "TVs"});

            Products.Add(new Product { Id = 1 , Title="Samsung A52S" , Category = Categories[0] , Price = 16000 });
            Products.Add(new Product { Id = 2 , Title = "Smart Samsung", Category = Categories[2] , Price = 4000 });
            Products.Add(new Product { Id = 3 , Title = "Dell G15", Category = Categories[1] , Price = 28000 });
            Products.Add(new Product { Id = 4 , Title = "LG TV", Category = Categories[3] , Price = 14000 });

        }
            
       

       

        

    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Input;
using BLL;
using BIl;
using Microsoft.Win32.SafeHandles;

namespace BLL
{
    public static class SampleData
    {
        public static List<Category> Categories;//= new List<Category>();
        public static List<Product> Products;// = new List<Product>();
        public static List<Order> Orders;//= new List<Order>();
        public static List<Customer> Customers;//  = new List<Customer>();
        public static List<User> Users;//= new List<User>();
        public static List<Supplier> Suppliers;// = new List<Supplier>();
        static SampleData()
        {

            Categories = new List<Category>();
            Products = new List<Product>();
            Orders = new List<Order>();
            Customers = new List<Customer>();
            Users = new List<User>();
            Suppliers = new List<Supplier>();
            //fill the list of  Categories
            Categories.Add(new Category { Id = 100, Title = "Mobile" });
            Categories.Add(new Category { Id = 101, Title = "Laptop" });
            Categories.Add(new Category { Id = 102, Title = "Electroics" });
            Categories.Add(new Category { Id = 103, Title = "Music instrument" });
            Categories.Add(new Category { Id = 104, Title = "Desktop" });
            Categories.Add(new Category { Id = 105, Title = "Body Care" });

            //fill the list of prodect
            Products.Add(new Product { Id = 1, Title = "Iphone 14 pro max", Price = 70000, Category = Categories[0], supplier = Suppliers[15] });
            Products.Add(new Product { Id = 2, Title = "Iphone pro max", Price = 65000, Category = Categories[0], supplier = Suppliers[15] });
            Products.Add(new Product { Id = 3, Title = "Iphone 6s", Price = 2800, Category = Categories[0], supplier = Suppliers[15] });
            Products.Add(new Product { Id = 4, Title = "Iphone pro max", Price = 65000, Category = Categories[0], supplier = Suppliers[15] });
            Products.Add(new Product { Id = 5, Title = "Dell set prestions x74", Price = 2300, Category = Categories[1], supplier = Suppliers[12] });
            Products.Add(new Product { Id = 6, Title = "Lenovo 12xs", Price = 2300, Category = Categories[1], supplier = Suppliers[12] });

            //Fill The List Of  Orders
            Orders.Add(new Order { CustomerId = 1, OrderId = 1, ProductId = 1, Quantity = 1, OrderDetails = "Iphone 14 pro max" });
            Orders.Add(new Order { CustomerId = 2, OrderId = 2, ProductId = 1, Quantity = 1, OrderDetails = "Iphone 14 pro max" });
            Orders.Add(new Order { CustomerId = 2, OrderId = 3, ProductId = 1, Quantity = 1, OrderDetails = "Iphone 14 pro max" });
            Orders.Add(new Order { CustomerId = 3, OrderId = 4, ProductId = 1, Quantity = 1, OrderDetails = "Iphone 14 pro max" });
            //Fill The List Of  Customer
            Customers.Add(new Customer { Name = "Ali", Age = 20, Sex = Sex.Male, Address = "Sohag", ID = 1, Phone = "01283839290" });
            Customers.Add(new Customer { Name = "Omer", Age = 20, Sex = Sex.Male, Address = "Assuit", ID = 2, Phone = "01283839290" });
            Customers.Add(new Customer { Name = "Syed", Age = 20, Sex = Sex.Male, Address = "Alex", ID = 3, Phone = "01283839290" });

            //Fill The List Of User
            Users.Add(new User { ID = 1, Name = "Tarek", Age = 23, Sex = Sex.Male, UserName = "Tarek_2022", Email = "Tarek232@gmail", Phone = "01038272789" });
            Users.Add(new User { ID = 2, Name = "Mohamed", Age = 23, Sex = Sex.Male, UserName = "Mohamed_2022", Email = "MohamedM5@gmail.com", Phone = "01067631594" });
            Users.Add(new User { ID = 3, Name = "Hamada", Age = 24, Sex = Sex.Male, UserName = "Hamada_2022", Email = "HamadaICPC@gmail.com", Phone = "01271921645" });

            //Fill The List Of Suppliers

            Suppliers.Add(new Supplier { City = "South Korea", Email = "L.G2312@gmail.com", ID = 10, Name = "L.G", Phone = "0926262718" });
            Suppliers.Add(new Supplier { City = "South Korea", Email = "Huaix2345@gmail.com", ID = 11, Name = "Huaix", Phone = "01271911645" });
            Suppliers.Add(new Supplier { City = "China", Email = "lenovo2223@gmial.com", ID = 12, Name = "Lenovo", Phone = "123-345-098" });
            Suppliers.Add(new Supplier { City = "China", Email = "TCL2223@gmial.com", ID = 14, Name = "TCL", Phone = "123-345-098" });
            Suppliers.Add(new Supplier { City = "China", Email = "VIVO2223@gmial.com", ID = 15, Name = "Vivo", Phone = "123-345-098" });
            Suppliers.Add(new Supplier { City = "China", Email = "Huawel565@gmail", ID = 16, Name = "Huawel", Phone = "8893 -3737-3737" });
            Suppliers.Add(new Supplier { City = "China", Email = "OPPO23455@gmail.com", ID = 17, Name = "Oppo", Phone = "8383-636-38" });
            Suppliers.Add(new Supplier { City = "Japan", Email = "NVIDA343@gmail.com", ID = 18, Name = "NVIDA", Phone = "23-44-56-76" });
            Suppliers.Add(new Supplier { City = "Japan", Email = "INTEL2345@gmail.com", ID = 19, Name = "Intel", Phone = "524-383-45" });
            Suppliers.Add(new Supplier { City = "Japan", Email = "Casio2332@gmail.com", ID = 20, Name = "CASIO", Phone = "73727-2929-9090" });
            Suppliers.Add(new Supplier { City = "Japan", Email = "SONY2344@gmail.com", ID = 21, Name = "SONY", Phone = "(2662)-828-222" });
            Suppliers.Add(new Supplier { City = "Newyork", Email = "SGI1234@gmail.com", ID = 22, Name = "SGI", Phone = "(2662)-828-222" });
            Suppliers.Add(new Supplier { City = "Newyork", Email = "Dell9876@gmail.com", ID = 23, Name = "DELL", Phone = "(2662)-828-222" });
            Suppliers.Add(new Supplier { City = "Newyork", Email = "BIM2672@gmail.com", ID = 24, Name = "BIM", Phone = "(2662)-828-222" });
            Suppliers.Add(new Supplier { City = "Newyork", Email = "ZENITH3453@gmail.com", ID = 25, Name = "ZENITH", Phone = "(2662)-828-222" });
            Suppliers.Add(new Supplier { City = "Newyork", Email = "APPEL23@gmail.com", ID = 26, Name = "Appal", Phone = "+092874737662" });
        }







    }
}
