using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class DhisAttributes
    {
        public string DhisAttributeId { get; set; }
        public string DhisDisplayName { get; set; }
        public string SourceColumnName { get; set; }
        public string ModuleCode { get; set; }
    }
}
