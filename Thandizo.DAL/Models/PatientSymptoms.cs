using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class PatientSymptoms
    {
        public PatientSymptoms()
        {
            PatientDailyStatuses = new HashSet<PatientDailyStatuses>();
        }

        public int SymptomId { get; set; }
        public string SymptomName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }
        public string ExternalReferenceNumber { get; set; }
        public bool IsAvailableForRegistration { get; set; }

        public virtual ICollection<PatientDailyStatuses> PatientDailyStatuses { get; set; }
    }
}
