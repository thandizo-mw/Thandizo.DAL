using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class Regions
    {
        public Regions()
        {
            Districts = new HashSet<Districts>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual ICollection<Districts> Districts { get; set; }
    }
}
