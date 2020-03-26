using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class PatientFacilityMovements
    {
        public long MovementId { get; set; }
        public long PatientId { get; set; }
        public int FromDataCenterId { get; set; }
        public int ToDataCenterId { get; set; }
        public DateTime MovementDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public virtual DataCenters FromDataCenter { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual DataCenters ToDataCenter { get; set; }
    }
}
