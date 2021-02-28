using System;
using System.Collections.Generic;
using System.Text;

namespace ColdStart_Api.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public int IcecreamId { get; set; }
        public string Status { get; set; }
        public string DriverId { get; set; }
        public string FullAddress { get; set; }
        public string LastPosition { get; set; }
    }
}
