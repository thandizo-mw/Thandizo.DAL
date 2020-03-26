using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class PatientHistory
    {
        public long HistoryId { get; set; }
        public long PatientId { get; set; }
        public int PatientStatusId { get; set; }
        public DateTime DateReported { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual PatientStatuses PatientStatus { get; set; }
    }
}
