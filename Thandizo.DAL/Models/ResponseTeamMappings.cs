using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class ResponseTeamMappings
    {
        public int MappingId { get; set; }
        public int TeamMemberId { get; set; }
        public string DistrictCode { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual Districts DistrictCodeNavigation { get; set; }
        public virtual ResponseTeamMembers TeamMember { get; set; }
    }
}
