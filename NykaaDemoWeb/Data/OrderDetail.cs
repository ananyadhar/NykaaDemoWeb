using System;
using System.Collections.Generic;

#nullable disable

namespace NykaaDemoWeb.Data
{
    public partial class OrderDetail
    {
        public int OrdersDetailsId { get; set; }
        public int? UserId { get; set; }
        public int? OrderId { get; set; }
        public string BillingAddress { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalOrderPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}
