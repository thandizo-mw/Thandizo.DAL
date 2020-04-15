﻿using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class Patients
    {
        public Patients()
        {
            PatientDailyStatuses = new HashSet<PatientDailyStatuses>();
            PatientFacilityMovements = new HashSet<PatientFacilityMovements>();
            PatientHistory = new HashSet<PatientHistory>();
            PatientLocationMovements = new HashSet<PatientLocationMovements>();
            PatientTravelHistory = new HashSet<PatientTravelHistory>();
            ConfirmedPatients = new HashSet<ConfirmedPatients>();
        }

        public long PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HomeAddress { get; set; }
        public string PhysicalAddress { get; set; }
        public string DistrictCode { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public int IdentificationTypeId { get; set; }
        public int DataCenterId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int PatientStatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }
        public string NationalityCode { get; set; }
        public int ClassificationId { get; set; }
        public string SourceId { get; set; }
        public bool IsConfirmed { get; set; }

        public virtual TransmissionClassifications Classification { get; set; }
        public virtual DataCenters DataCenter { get; set; }
        public virtual Districts DistrictCodeNavigation { get; set; }
        public virtual IdentificationTypes IdentificationType { get; set; }
        public virtual Nationalities NationalityCodeNavigation { get; set; }
        public virtual PatientStatuses PatientStatus { get; set; }
        public virtual RegistrationSources Source { get; set; }
        public virtual ICollection<PatientDailyStatuses> PatientDailyStatuses { get; set; }
        public virtual ICollection<PatientFacilityMovements> PatientFacilityMovements { get; set; }
        public virtual ICollection<PatientHistory> PatientHistory { get; set; }
        public virtual ICollection<PatientLocationMovements> PatientLocationMovements { get; set; }
        public virtual ICollection<PatientTravelHistory> PatientTravelHistory { get; set; }
        public virtual ICollection<ConfirmedPatients> ConfirmedPatients { get; set; }
    }
}
