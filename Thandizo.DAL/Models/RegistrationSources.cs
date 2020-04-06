using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class RegistrationSources
    {
        public RegistrationSources()
        {
            Patients = new HashSet<Patients>();
        }

        public string SourceId { get; set; }
        public string SourceName { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }
    }
}
