using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSharp
{
    public class Order
    {
        
        public int OrderId { get; set; }

        public int Quantity { get; set; }

        public int SubTotal { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string OrderDetails { 
            
            get 
            {
                return $"Order ID : {OrderId} \n DeliveryDate : {DeliveryDate} \n" +
                    $"CustomerId : {CustomerId} \n" +
                    $" DeliveryAddress : {DeliveryAddress}";
            }

            set { }
        
        }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        public string DeliveryAddress { get; set; }

        //public List<Product> OrderItems { get; set; }
        //public Customer Customer { get; set; }

        //public Product Product { get; set; }

        //public double GetFullPrice() {

        //    return Quantity * Product.Price;

        //}


    }



    
}
