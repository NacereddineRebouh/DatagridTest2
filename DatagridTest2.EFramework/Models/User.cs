using System;
using System.Collections.Generic;

#nullable disable

namespace DatagridTest2.EFramework
{
    public partial class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public byte[] ProfileImage { get; set; }
        public long MemberOf { get; set; }
        public string Job { get; set; }
        public long RoleId { get; set; }

        public virtual Team Team { get; set; }
        //[ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
