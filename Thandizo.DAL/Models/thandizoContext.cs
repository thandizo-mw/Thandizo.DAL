using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Thandizo.DAL.Models
{
    public partial class thandizoContext : DbContext
    {
        public thandizoContext()
        {
        }

        public thandizoContext(DbContextOptions<thandizoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConfirmedPatients> ConfirmedPatients { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<DataCenters> DataCenters { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<FacilityTypes> FacilityTypes { get; set; }
        public virtual DbSet<HealthCareWorkers> HealthCareWorkers { get; set; }
        public virtual DbSet<HealthFacilityResources> HealthFacilityResources { get; set; }
        public virtual DbSet<IdentificationTypes> IdentificationTypes { get; set; }
        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<PatientDailyStatuses> PatientDailyStatuses { get; set; }
        public virtual DbSet<PatientFacilityMovements> PatientFacilityMovements { get; set; }
        public virtual DbSet<PatientHistory> PatientHistory { get; set; }
        public virtual DbSet<PatientLocationMovements> PatientLocationMovements { get; set; }
        public virtual DbSet<PatientStatuses> PatientStatuses { get; set; }
        public virtual DbSet<PatientSymptoms> PatientSymptoms { get; set; }
        public virtual DbSet<PatientTravelHistory> PatientTravelHistory { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<RegistrationMappings> RegistrationMappings { get; set; }
        public virtual DbSet<RegistrationSources> RegistrationSources { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<ResourcesAllocation> ResourcesAllocation { get; set; }
        public virtual DbSet<ResponseTeamMappings> ResponseTeamMappings { get; set; }
        public virtual DbSet<ResponseTeamMembers> ResponseTeamMembers { get; set; }
        public virtual DbSet<TransmissionClassifications> TransmissionClassifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=thandizo;User Id=thandizo_dba;Password=admin2013+;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfirmedPatients>(entity =>
            {
                entity.HasKey(e => e.ConfirmedPatientId)
                    .HasName("confirmed_patients_pkey");

                entity.ToTable("confirmed_patients");

                entity.Property(e => e.ConfirmedPatientId)
                    .HasColumnName("confirmed_patient_id")
                    .HasDefaultValueSql("nextval('seq_confirmed_patient_id'::regclass)");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(40);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(1);

                entity.Property(e => e.GuardianFirstName)
                    .HasColumnName("guardian_first_name")
                    .HasMaxLength(40);

                entity.Property(e => e.GuardianPhoneNumber)
                    .HasColumnName("guardian_phone_number")
                    .HasMaxLength(20);

                entity.Property(e => e.GuardianSurname)
                    .HasColumnName("guardian_surname")
                    .HasMaxLength(40);

                entity.Property(e => e.IdentificationNumber)
                    .IsRequired()
                    .HasColumnName("identification_number")
                    .HasMaxLength(25);

                entity.Property(e => e.IdentificationType)
                    .IsRequired()
                    .HasColumnName("identification_type")
                    .HasMaxLength(5);

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(20);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(40);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConfirmedPatients)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patient_id_fk");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("countries_pkey");

                entity.ToTable("countries");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(40);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.ExternalReferenceNumber)
                    .HasColumnName("external_reference_number")
                    .HasMaxLength(15);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<DataCenters>(entity =>
            {
                entity.HasKey(e => e.CenterId)
                    .HasName("data_collection_centers_pkey");

                entity.ToTable("data_centers");

                entity.Property(e => e.CenterId)
                    .HasColumnName("center_id")
                    .HasDefaultValueSql("nextval('seq_center_id'::regclass)");

                entity.Property(e => e.CenterName)
                    .IsRequired()
                    .HasColumnName("center_name")
                    .HasMaxLength(70);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasColumnName("district_code")
                    .HasMaxLength(3);

                entity.Property(e => e.FacilityTypeId).HasColumnName("facility_type_id");

                entity.Property(e => e.IsHealthFacility).HasColumnName("is_health_facility");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.DataCenters)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("district_code_fk");

                entity.HasOne(d => d.FacilityType)
                    .WithMany(p => p.DataCenters)
                    .HasForeignKey(d => d.FacilityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("facility_type_id_fk");
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasKey(e => e.DistrictCode)
                    .HasName("districts_pkey");

                entity.ToTable("districts");

                entity.Property(e => e.DistrictCode)
                    .HasColumnName("district_code")
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Document).HasColumnName("document");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("region_id_fk");
            });

            modelBuilder.Entity<FacilityTypes>(entity =>
            {
                entity.HasKey(e => e.FacilityTypeId)
                    .HasName("facility_type_pkey");

                entity.ToTable("facility_types");

                entity.Property(e => e.FacilityTypeId)
                    .HasColumnName("facility_type_id")
                    .HasDefaultValueSql("nextval('seq_facility_type_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.FacilityTypeName)
                    .IsRequired()
                    .HasColumnName("facility_type_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<HealthCareWorkers>(entity =>
            {
                entity.HasKey(e => e.WorkerId)
                    .HasName("worker_id_pkey");

                entity.ToTable("health_care_workers");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasDefaultValueSql("nextval('seq_health_care_workers_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DataCenterId).HasColumnName("data_center_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(60);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(40);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(1);

                entity.Property(e => e.IdentificationNumber)
                    .IsRequired()
                    .HasColumnName("identification_number")
                    .HasMaxLength(25);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("identification_type_id");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(40);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.OtherNames)
                    .IsRequired()
                    .HasColumnName("other_names")
                    .HasMaxLength(40);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(20);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.HasOne(d => d.DataCenter)
                    .WithMany(p => p.HealthCareWorkers)
                    .HasForeignKey(d => d.DataCenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("data_center_id_fk");

                entity.HasOne(d => d.IdentificationType)
                    .WithMany(p => p.HealthCareWorkers)
                    .HasForeignKey(d => d.IdentificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("identification_type_id_fk");
            });

            modelBuilder.Entity<HealthFacilityResources>(entity =>
            {
                entity.HasKey(e => e.FacilityResourceId)
                    .HasName("health_facility_resources_pkey");

                entity.ToTable("health_facility_resources");

                entity.Property(e => e.FacilityResourceId)
                    .HasColumnName("facility_resource_id")
                    .HasDefaultValueSql("nextval('seq_facility_resource_id'::regclass)");

                entity.Property(e => e.CenterId).HasColumnName("center_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ResourceAllocationId).HasColumnName("resource_allocation_id");

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.HealthFacilityResources)
                    .HasForeignKey(d => d.CenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hfr_center_id_fk");

                entity.HasOne(d => d.ResourceAllocation)
                    .WithMany(p => p.HealthFacilityResources)
                    .HasForeignKey(d => d.ResourceAllocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("resource_allocation_id_fk");
            });

            modelBuilder.Entity<IdentificationTypes>(entity =>
            {
                entity.HasKey(e => e.IdentificationTypeId)
                    .HasName("identification_types_pkey");

                entity.ToTable("identification_types");

                entity.Property(e => e.IdentificationTypeId)
                    .HasColumnName("identification_type_id")
                    .HasDefaultValueSql("nextval('seq_identification_type_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(30);

                entity.Property(e => e.ExternalReferenceNumber)
                    .HasColumnName("external_reference_number")
                    .HasMaxLength(15);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Nationalities>(entity =>
            {
                entity.HasKey(e => e.NationalityCode)
                    .HasName("nationalities_pkey");

                entity.ToTable("nationalities");

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("nationality_code")
                    .HasMaxLength(5);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.Document).HasColumnName("document");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasColumnName("nationality_name")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<PatientDailyStatuses>(entity =>
            {
                entity.HasKey(e => e.SubmissionId)
                    .HasName("patient_daily_statuses_pkey");

                entity.ToTable("patient_daily_statuses");

                entity.Property(e => e.SubmissionId)
                    .HasColumnName("submission_id")
                    .HasDefaultValueSql("nextval('seq_patient_submission_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateSubmitted)
                    .HasColumnName("date_submitted")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.SymptomId).HasColumnName("symptom_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientDailyStatuses)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pds_patient_id_fk");

                entity.HasOne(d => d.Symptom)
                    .WithMany(p => p.PatientDailyStatuses)
                    .HasForeignKey(d => d.SymptomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pds_symptom_id_fk");
            });

            modelBuilder.Entity<PatientFacilityMovements>(entity =>
            {
                entity.HasKey(e => e.MovementId)
                    .HasName("patient_facility_movement_pkey");

                entity.ToTable("patient_facility_movements");

                entity.Property(e => e.MovementId)
                    .HasColumnName("movement_id")
                    .HasDefaultValueSql("nextval('seq_facility_movement_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.FromDataCenterId).HasColumnName("from_data_center_id");

                entity.Property(e => e.MovementDate)
                    .HasColumnName("movement_date")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.ToDataCenterId).HasColumnName("to_data_center_id");

                entity.HasOne(d => d.FromDataCenter)
                    .WithMany(p => p.PatientFacilityMovementsFromDataCenter)
                    .HasForeignKey(d => d.FromDataCenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("from_data_center_id_fk");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientFacilityMovements)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patient_id");

                entity.HasOne(d => d.ToDataCenter)
                    .WithMany(p => p.PatientFacilityMovementsToDataCenter)
                    .HasForeignKey(d => d.ToDataCenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("to_data_center_id_fk");
            });

            modelBuilder.Entity<PatientHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("patient_history_pkey");

                entity.ToTable("patient_history");

                entity.Property(e => e.HistoryId)
                    .HasColumnName("history_id")
                    .HasDefaultValueSql("nextval('seq_patient_history_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateReported)
                    .HasColumnName("date_reported")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.PatientStatusId).HasColumnName("patient_status_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientHistory)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patient_id_fk");

                entity.HasOne(d => d.PatientStatus)
                    .WithMany(p => p.PatientHistory)
                    .HasForeignKey(d => d.PatientStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patient_status_id_fk");
            });

            modelBuilder.Entity<PatientLocationMovements>(entity =>
            {
                entity.HasKey(e => e.MovementId)
                    .HasName("patient_movements_pkey");

                entity.ToTable("patient_location_movements");

                entity.Property(e => e.MovementId)
                    .HasColumnName("movement_id")
                    .HasDefaultValueSql("nextval('seq_location_movement_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasColumnName("district_code")
                    .HasMaxLength(3);

                entity.Property(e => e.ImagePath)
                    .HasColumnName("image_path")
                    .HasMaxLength(100);

                entity.Property(e => e.MovementDate)
                    .HasColumnName("movement_date")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.PatientLocationMovements)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("district_code_fk");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientLocationMovements)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patient_id_fk");
            });

            modelBuilder.Entity<PatientStatuses>(entity =>
            {
                entity.HasKey(e => e.PatientStatusId)
                    .HasName("patient_stage_pkey");

                entity.ToTable("patient_statuses");

                entity.Property(e => e.PatientStatusId)
                    .HasColumnName("patient_status_id")
                    .HasDefaultValueSql("nextval('seq_patient_status_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.PatientStatusName)
                    .IsRequired()
                    .HasColumnName("patient_status_name")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.Property(e => e.Severity).HasColumnName("severity");
            });

            modelBuilder.Entity<PatientSymptoms>(entity =>
            {
                entity.HasKey(e => e.SymptomId)
                    .HasName("patient_symptoms_pkey");

                entity.ToTable("patient_symptoms");

                entity.Property(e => e.SymptomId)
                    .HasColumnName("symptom_id")
                    .HasDefaultValueSql("nextval('seq_patient_symptom_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.ExternalReferenceNumber)
                    .HasColumnName("external_reference_number")
                    .HasMaxLength(15);

                entity.Property(e => e.IsAvailableForRegistration).HasColumnName("is_available_for_registration");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.Property(e => e.SymptomName)
                    .IsRequired()
                    .HasColumnName("symptom_name")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<PatientTravelHistory>(entity =>
            {
                entity.HasKey(e => e.TravelId)
                    .HasName("patient_travel_history_pkey");

                entity.ToTable("patient_travel_history");

                entity.Property(e => e.TravelId)
                    .HasColumnName("travel_id")
                    .HasDefaultValueSql("nextval('seq_patient_travel_id'::regclass)");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.PatientTravelHistory)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pth_country_code_fk");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientTravelHistory)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pth_patient_id_fk");
            });

            modelBuilder.Entity<Patients>(entity =>
            {
                entity.HasKey(e => e.PatientId)
                    .HasName("patients_pkey");

                entity.ToTable("patients");

                entity.HasIndex(e => e.PatientStatusId)
                    .HasName("fki_patient_status_id_fk");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .HasDefaultValueSql("nextval('seq_patient_id'::regclass)");

                entity.Property(e => e.ClassificationId).HasColumnName("classification_id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DataCenterId).HasColumnName("data_center_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasColumnName("district_code")
                    .HasMaxLength(3);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(60);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(40);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(1);

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasColumnName("home_address")
                    .HasMaxLength(200);

                entity.Property(e => e.IdentificationNumber)
                    .IsRequired()
                    .HasColumnName("identification_number")
                    .HasMaxLength(25);

                entity.Property(e => e.IdentificationTypeId).HasColumnName("identification_type_id");

                entity.Property(e => e.IsConfirmed).HasColumnName("is_confirmed");

                entity.Property(e => e.IsSelfRegistered).HasColumnName("is_self_registered");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(40);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(50);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.NationalityCode)
                    .IsRequired()
                    .HasColumnName("nationality_code")
                    .HasMaxLength(5);

                entity.Property(e => e.NextOfKinFirstName)
                    .HasColumnName("next_of_kin_first_name")
                    .HasMaxLength(40);

                entity.Property(e => e.NextOfKinLastName)
                    .HasColumnName("next_of_kin_last_name")
                    .HasMaxLength(40);

                entity.Property(e => e.NextOfKinPhoneNumber)
                    .HasColumnName("next_of_kin_phone_number")
                    .HasMaxLength(15);

                entity.Property(e => e.OtherNames)
                    .HasColumnName("other_names")
                    .HasMaxLength(40);

                entity.Property(e => e.PatientStatusId).HasColumnName("patient_status_id");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(20);

                entity.Property(e => e.PhysicalAddress)
                    .HasColumnName("physical_address")
                    .HasMaxLength(200);

                entity.Property(e => e.ResidenceCountryCode)
                    .IsRequired()
                    .HasColumnName("residence_country_code")
                    .HasMaxLength(3);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.Property(e => e.SourceId)
                    .IsRequired()
                    .HasColumnName("source_id")
                    .HasMaxLength(2);

                entity.HasOne(d => d.Classification)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.ClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pt_classification_id_fk");

                entity.HasOne(d => d.DataCenter)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DataCenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("data_center_id_fk");

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("district_code_fk");

                entity.HasOne(d => d.IdentificationType)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.IdentificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("identification_type_id_fk");

                entity.HasOne(d => d.NationalityCodeNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.NationalityCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pth_nationality_code_fk");

                entity.HasOne(d => d.PatientStatus)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.PatientStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patient_status_id_fk");

                entity.HasOne(d => d.ResidenceCountryCodeNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.ResidenceCountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pt_country_code_fk");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_source_id_fk");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("regions_pkey");

                entity.ToTable("regions");

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasDefaultValueSql("nextval('seq_region_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasColumnName("region_name")
                    .HasMaxLength(30);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<RegistrationMappings>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("registration_mappings_pkey");

                entity.ToTable("registration_mappings");

                entity.Property(e => e.MappingId)
                    .HasColumnName("mapping_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassificationId).HasColumnName("classification_id");

                entity.Property(e => e.DataCenterId).HasColumnName("data_center_id");

                entity.Property(e => e.PatientStatusId).HasColumnName("patient_status_id");
            });

            modelBuilder.Entity<RegistrationSources>(entity =>
            {
                entity.HasKey(e => e.SourceId)
                    .HasName("registration_sources_pkey");

                entity.ToTable("registration_sources");

                entity.Property(e => e.SourceId)
                    .HasColumnName("source_id")
                    .HasMaxLength(2);

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasColumnName("source_name")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.HasKey(e => e.ResourceId)
                    .HasName("resources_pkey");

                entity.ToTable("resources");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("resource_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasColumnName("resource_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ResourcesAllocation>(entity =>
            {
                entity.HasKey(e => e.ResourceAllocationId)
                    .HasName("resources_allocation_pkey");

                entity.ToTable("resources_allocation");

                entity.Property(e => e.ResourceAllocationId)
                    .HasColumnName("resource_allocation_id")
                    .HasDefaultValueSql("nextval('seq_resource_allocation_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.PatientStatusId).HasColumnName("patient_status_id");

                entity.Property(e => e.RequiredQuantity).HasColumnName("required_quantity");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.HasOne(d => d.PatientStatus)
                    .WithMany(p => p.ResourcesAllocation)
                    .HasForeignKey(d => d.PatientStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("status_id_fk");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourcesAllocation)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ra_resource_id_fk");
            });

            modelBuilder.Entity<ResponseTeamMappings>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("rtmp_mapping_id_pk");

                entity.ToTable("response_team_mappings");

                entity.Property(e => e.MappingId)
                    .HasColumnName("mapping_id")
                    .HasDefaultValueSql("nextval('seq_team_member_mapping_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasColumnName("district_code")
                    .HasMaxLength(3);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.Property(e => e.TeamMemberId).HasColumnName("team_member_id");

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.ResponseTeamMappings)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rtmp_district_code_fk");

                entity.HasOne(d => d.TeamMember)
                    .WithMany(p => p.ResponseTeamMappings)
                    .HasForeignKey(d => d.TeamMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rtmp_team_member_id_fk");
            });

            modelBuilder.Entity<ResponseTeamMembers>(entity =>
            {
                entity.HasKey(e => e.TeamMemberId)
                    .HasName("rtm_team_member_id_pk");

                entity.ToTable("response_team_members");

                entity.Property(e => e.TeamMemberId)
                    .HasColumnName("team_member_id")
                    .HasDefaultValueSql("nextval('seq_team_member_id'::regclass)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(40);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.OtherNames)
                    .HasColumnName("other_names")
                    .HasMaxLength(60);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasMaxLength(15);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TransmissionClassifications>(entity =>
            {
                entity.HasKey(e => e.ClassificationId)
                    .HasName("transmission_classifications_pkey");

                entity.ToTable("transmission_classifications");

                entity.Property(e => e.ClassificationId)
                    .HasColumnName("classification_id")
                    .HasDefaultValueSql("nextval('seq_trans_classification_id'::regclass)");

                entity.Property(e => e.ClassificationName)
                    .IsRequired()
                    .HasColumnName("classification_name")
                    .HasMaxLength(40);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(40);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("timestamp(4) with time zone");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(40);

                entity.Property(e => e.RowAction)
                    .IsRequired()
                    .HasColumnName("row_action")
                    .HasMaxLength(1);
            });

            modelBuilder.HasSequence("seq_center_id");

            modelBuilder.HasSequence("seq_confirmed_patient_id");

            modelBuilder.HasSequence("seq_facility_movement_id");

            modelBuilder.HasSequence("seq_facility_resource_id");

            modelBuilder.HasSequence("seq_facility_type_id");

            modelBuilder.HasSequence("seq_health_care_workers_id");

            modelBuilder.HasSequence("seq_identification_type_id");

            modelBuilder.HasSequence("seq_location_movement_id");

            modelBuilder.HasSequence("seq_patient_history_id");

            modelBuilder.HasSequence("seq_patient_id");

            modelBuilder.HasSequence("seq_patient_status_id");

            modelBuilder.HasSequence("seq_patient_submission_id");

            modelBuilder.HasSequence("seq_patient_symptom_id");

            modelBuilder.HasSequence("seq_patient_travel_id");

            modelBuilder.HasSequence("seq_region_id");

            modelBuilder.HasSequence("seq_resource_allocation_id");

            modelBuilder.HasSequence("seq_resource_id");

            modelBuilder.HasSequence("seq_team_member_id");

            modelBuilder.HasSequence("seq_team_member_mapping_id");

            modelBuilder.HasSequence("seq_trans_classification_id");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
