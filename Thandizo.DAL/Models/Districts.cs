using System;
using System.Collections.Generic;
using NpgsqlTypes;

namespace Thandizo.DAL.Models
{
    public partial class Districts
    {
        public Districts()
        {
            DataCenters = new HashSet<DataCenters>();
            PatientLocationMovements = new HashSet<PatientLocationMovements>();
            Patients = new HashSet<Patients>();
        }

        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public int RegionId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }
        public NpgsqlTsVector Document { get; set; }

        public virtual Regions Region { get; set; }
        public virtual ICollection<DataCenters> DataCenters { get; set; }
        public virtual ICollection<PatientLocationMovements> PatientLocationMovements { get; set; }
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
