using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class PatientLocationMovements
    {
        public long MovementId { get; set; }
        public long PatientId { get; set; }
        public string DistrictCode { get; set; }
        public string ImagePath { get; set; }
        public DateTime MovementDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public virtual Districts DistrictCodeNavigation { get; set; }
        public virtual Patients Patient { get; set; }
    }
}
