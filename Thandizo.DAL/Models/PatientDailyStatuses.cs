using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class PatientDailyStatuses
    {
        public long SubmissionId { get; set; }
        public int SymptomId { get; set; }
        public long PatientId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateSubmitted { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual PatientSymptoms Symptom { get; set; }
    }
}
