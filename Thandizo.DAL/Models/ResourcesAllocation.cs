using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class ResourcesAllocation
    {
        public ResourcesAllocation()
        {
            HealthFacilityResources = new HashSet<HealthFacilityResources>();
        }

        public long ResourceAllocationId { get; set; }
        public int PatientStatusId { get; set; }
        public int ResourceId { get; set; }
        public int RequiredQuantity { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual PatientStatuses PatientStatus { get; set; }
        public virtual Resources Resource { get; set; }
        public virtual ICollection<HealthFacilityResources> HealthFacilityResources { get; set; }
    }
}
