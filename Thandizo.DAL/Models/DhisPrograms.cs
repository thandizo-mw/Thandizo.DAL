using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class DhisPrograms
    {
        public string DhisProgramId { get; set; }
        public string DhisProgramName { get; set; }
        public string DhisTrackedEntityId { get; set; }
        public string DhisProgramStage { get; set; }
    }
}
