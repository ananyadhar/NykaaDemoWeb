using System;
using System.Collections.Generic;

#nullable disable

namespace NykaaDemoWeb.Data
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
