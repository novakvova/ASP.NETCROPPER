using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteCrop.Models
{
    public class ProducCreateViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}