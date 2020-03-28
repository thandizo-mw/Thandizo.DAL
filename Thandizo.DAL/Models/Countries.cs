using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class Countries
    {
        public Countries()
        {
            PatientTravelHistory = new HashSet<PatientTravelHistory>();
        }

        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual ICollection<PatientTravelHistory> PatientTravelHistory { get; set; }
    }
}
