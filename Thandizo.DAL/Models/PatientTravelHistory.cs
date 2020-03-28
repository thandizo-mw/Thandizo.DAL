using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class PatientTravelHistory
    {
        public int TravelId { get; set; }
        public string CountryCode { get; set; }
        public long PatientId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual Patients Patient { get; set; }
    }
}
