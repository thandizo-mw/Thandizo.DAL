using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class PatientStatuses
    {
        public PatientStatuses()
        {
            Patients = new HashSet<Patients>();
            ResourcesAllocation = new HashSet<ResourcesAllocation>();
        }

        public int PatientStatusId { get; set; }
        public string PatientStatusName { get; set; }
        public int Severity { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }
        public virtual ICollection<ResourcesAllocation> ResourcesAllocation { get; set; }
    }
}
