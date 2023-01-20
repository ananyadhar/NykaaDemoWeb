using System;
using System.Collections.Generic;

#nullable disable

namespace NykaaDemoWeb.Data
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Pid { get; set; }
        public string Pbrand { get; set; }
        public string Pname { get; set; }
        public string Pdescription { get; set; }
        public int? Pprice { get; set; }
        public int? ScatId { get; set; }
        public string Pimg { get; set; }

        public virtual SubCategory Scat { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
