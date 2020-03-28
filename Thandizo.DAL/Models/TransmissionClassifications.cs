using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class TransmissionClassifications
    {
        public TransmissionClassifications()
        {
            Patients = new HashSet<Patients>();
        }

        public int ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }
    }
}
