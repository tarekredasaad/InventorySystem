using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public Supplier supplier { get; set; }




        //public string DescriptionImage { get; set; }


    }
}
