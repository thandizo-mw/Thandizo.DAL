using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class ResponseTeamMembers
    {
        public ResponseTeamMembers()
        {
            ResponseTeamMappings = new HashSet<ResponseTeamMappings>();
        }

        public int TeamMemberId { get; set; }
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }

        public virtual ICollection<ResponseTeamMappings> ResponseTeamMappings { get; set; }
    }
}
