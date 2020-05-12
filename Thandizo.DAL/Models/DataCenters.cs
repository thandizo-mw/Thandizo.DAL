using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class DataCenters
    {
        public DataCenters()
        {
            HealthCareWorkers = new HashSet<HealthCareWorkers>();
            HealthFacilityResources = new HashSet<HealthFacilityResources>();
            Patients = new HashSet<Patients>();
        }

        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public int FacilityTypeId { get; set; }
        public string DistrictCode { get; set; }
        public bool IsHealthFacility { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual Districts DistrictCodeNavigation { get; set; }
        public virtual FacilityTypes FacilityType { get; set; }
        public virtual ICollection<HealthCareWorkers> HealthCareWorkers { get; set; }
        public virtual ICollection<HealthFacilityResources> HealthFacilityResources { get; set; }
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
