using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class Nationalities
    {
        public Nationalities()
        {
            Patients = new HashSet<Patients>();
        }

        public string NationalityCode { get; set; }
        public string NationalityName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }
    }
}
