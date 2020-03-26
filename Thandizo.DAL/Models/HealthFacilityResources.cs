using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class HealthFacilityResources
    {
        public int FacilityResourceId { get; set; }
        public int CenterId { get; set; }
        public long ResourceAllocationId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual DataCenters Center { get; set; }
        public virtual ResourcesAllocation ResourceAllocation { get; set; }
    }
}
