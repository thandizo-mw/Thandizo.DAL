using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class DhisProgrammes
    {
        public string DhisProgrammeId { get; set; }
        public string DhisProgrammeName { get; set; }
        public string DhisTrackedEntityId { get; set; }
        public string DhisProgramStage { get; set; }
    }
}
