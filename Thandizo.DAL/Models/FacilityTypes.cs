using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class FacilityTypes
    {
        public FacilityTypes()
        {
            DataCenters = new HashSet<DataCenters>();
        }

        public int FacilityTypeId { get; set; }
        public string FacilityTypeName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual ICollection<DataCenters> DataCenters { get; set; }
    }
}
