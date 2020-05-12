using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class ConfirmedPatients
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string IdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public long PatientId { get; set; }
        public long ConfirmedPatientId { get; set; }
        public int? Age { get; set; }
        public string GuardianFirstName { get; set; }
        public string GuardianSurname { get; set; }
        public string GuardianPhoneNumber { get; set; }

        public virtual Patients Patient { get; set; }
    }
}
