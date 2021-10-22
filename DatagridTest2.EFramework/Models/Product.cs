using System;
using System.Collections.Generic;

#nullable disable

namespace DatagridTest2.EFramework
{
    public partial class Product
    {
        public Product()
        {
            Records = new HashSet<Record>();
        }

        public long Id { get; set; }
        public string ProductName { get; set; }
        public double BoughtFor { get; set; }
        public double SoldFor { get; set; }
        public long SelledBy { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
