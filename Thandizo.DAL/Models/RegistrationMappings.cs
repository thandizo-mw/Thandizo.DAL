using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class RegistrationMappings
    {
        public int MappingId { get; set; }
        public int ClassificationId { get; set; }
        public int PatientStatusId { get; set; }
        public int DataCenterId { get; set; }
    }
}
