using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class IdentificationTypes
    {
        public IdentificationTypes()
        {
            HealthCareWorkers = new HashSet<HealthCareWorkers>();
            Patients = new HashSet<Patients>();
        }

        public int IdentificationTypeId { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }
        public string ExternalReferenceNumber { get; set; }

        public virtual ICollection<HealthCareWorkers> HealthCareWorkers { get; set; }
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
