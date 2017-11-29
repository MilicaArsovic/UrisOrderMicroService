using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrisOrderMicroService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String DeliveryAddress { get; set; }
        public String DeliveryCity { get; set; }
        public String DeliveryZipCode { get; set; }
        public String DeliveryCountry { get; set; }
        public String Note { get; set; }
        public int UserId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public bool Active { get; set; }
        // public ActiveStateEnum Active { get; set; }
    }
}