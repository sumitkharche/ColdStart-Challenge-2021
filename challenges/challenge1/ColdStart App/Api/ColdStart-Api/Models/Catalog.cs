using System;
using System.Collections.Generic;
using System.Text;

namespace ColdStart_Api.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
