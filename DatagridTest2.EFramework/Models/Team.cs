using System;
using System.Collections.Generic;

#nullable disable

namespace DatagridTest2.EFramework
{
    public partial class Team
    {
        public long Id { get; set; }
        public long Leader { get; set; }
        public long MembersCount { get; set; }
        public double TotalContribution { get; set; }

        public virtual User User { get; set; }
    }
}
