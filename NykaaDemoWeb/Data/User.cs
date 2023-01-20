using System;
using System.Collections.Generic;

#nullable disable

namespace NykaaDemoWeb.Data
{
    public partial class User
    {
        public User()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWrd { get; set; }
        public string UserType { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
