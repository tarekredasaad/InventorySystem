using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIl
{
    [Flags]
    public enum Sex
    {
        Male,
        Female
    }
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public string Phone { get; set; }

        /*public Person(int id,string name, int age,Sex sex, string phone)
        {
            ID = id;
            Age = age;
            Name = name;
            Phone = phone;
            Sex = sex;
        }*/





    }
}
