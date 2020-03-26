using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class Resources
    {
        public Resources()
        {
            ResourcesAllocation = new HashSet<ResourcesAllocation>();
        }

        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual ICollection<ResourcesAllocation> ResourcesAllocation { get; set; }
    }
}
