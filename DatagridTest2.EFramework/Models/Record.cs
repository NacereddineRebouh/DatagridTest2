using System;
using System.Collections.Generic;

#nullable disable

namespace DatagridTest2.EFramework
{
    public partial class Record
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public double SoldFor { get; set; }
        public long SelledBy { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
