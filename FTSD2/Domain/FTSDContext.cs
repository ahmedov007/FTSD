using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FTSD2.Domain;
using FTSD2.Models;

namespace FTSD2.Domain
{
    public partial class FTSDContext : DbContext
    {
        public FTSDContext()
        {
        }

        public FTSDContext(DbContextOptions<FTSDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionType> ActionTypes { get; set; } = null!;
        public virtual DbSet<ActiveContract> ActiveContracts { get; set; } = null!;
        public virtual DbSet<AmedmentType> AmedmentTypes { get; set; } = null!;
        public virtual DbSet<AthorityMatrix> AthorityMatrices { get; set; } = null!;
        public virtual DbSet<BidsType> BidsTypes { get; set; } = null!;
        public virtual DbSet<BudgetPlan> BudgetPlans { get; set; } = null!;
        public virtual DbSet<BudgetYear> BudgetYears { get; set; } = null!;
        public virtual DbSet<BussinessUnit> BussinessUnits { get; set; } = null!;
        public virtual DbSet<CapitalProject> CapitalProjects { get; set; } = null!;
        public virtual DbSet<AmendmentContracts> AmendmentContracts { get; set; } = null!;
        public virtual DbSet<CapitalProjectAttachment> CapitalProjectAttachments { get; set; } = null!;
        public virtual DbSet<CapitalProjectNote> CapitalProjectNotes { get; set; } = null!;
        public virtual DbSet<CapitalProjectsType> CapitalProjectsTypes { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CompanyContact> CompanyContacts { get; set; } = null!;
        public virtual DbSet<ContractsType> ContractsTypes { get; set; } = null!;
        public virtual DbSet<DucomentType> DucomentTypes { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Ftsdrole> Ftsdroles { get; set; } = null!;
        public virtual DbSet<JobTitle> JobTitles { get; set; } = null!;
        public virtual DbSet<LandStatus> LandStatuses { get; set; } = null!;
        public virtual DbSet<Logo> Logos { get; set; } = null!;
        public virtual DbSet<Logs> Logs { get; set; } = null!;
        public virtual DbSet<LogTypes> LogTypes { get; set; } = null!;
        public virtual DbSet<NewContract> NewContracts { get; set; } = null!;
        public virtual DbSet<NewContractAction> NewContractActions { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<NotificationType> NotificationTypes { get; set; } = null!;
        public virtual DbSet<OperationalContractNote> OperationalContractNotes { get; set; } = null!;
        public virtual DbSet<OpertionalContractNote> OpertionalContractNotes { get; set; } = null!;
        public virtual DbSet<ProjectDate> ProjectDates { get; set; } = null!;
        public virtual DbSet<ProjectSatuse> ProjectSatuses { get; set; } = null!;
        public virtual DbSet<ProjectType> ProjectTypes { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=FTSD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ActiveContract>(entity =>
            {
                entity.ToTable("ActiveContract");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(350);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractNo).HasMaxLength(15);

                entity.Property(e => e.EndDat).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(350);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ActiveContracts)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_ActiveContract_Companies");

                entity.HasOne(d => d.ContractType)
                    .WithMany(p => p.ActiveContracts)
                    .HasForeignKey(d => d.ContractTypeId)
                    .HasConstraintName("FK_ActiveContract_ContractsType");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ActiveContracts)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_ActiveContract_Regions");
            });

            modelBuilder.Entity<AmedmentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<AthorityMatrix>(entity =>
            {
                entity.ToTable("AthorityMatrix");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(350);

                entity.Property(e => e.Name).HasMaxLength(350);
            });

            modelBuilder.Entity<BidsType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<BudgetPlan>(entity =>
            {
                entity.ToTable("BudgetPlan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            });

            modelBuilder.Entity<BudgetYear>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<BussinessUnit>(entity =>
            {
                entity.ToTable("BussinessUnit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CapitalProject>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArabicProjectName).HasMaxLength(350);

                entity.Property(e => e.ContractNo).HasMaxLength(100);

                entity.Property(e => e.ProjectName).HasMaxLength(350);

                entity.Property(e => e.ProjectNo).HasMaxLength(100);

                entity.HasOne(d => d.BudgetYear)
                    .WithMany(p => p.CapitalProjects)
                    .HasForeignKey(d => d.BudgetYearId)
                    .HasConstraintName("FK_CapitalProject_BudgetYears");

                entity.HasOne(d => d.BussinessUnit)
                    .WithMany(p => p.CapitalProjects)
                    .HasForeignKey(d => d.BussinessUnitId)
                    .HasConstraintName("FK_CapitalProject_BussinessUnit");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CapitalProjects)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_CapitalProject_Cities");

                entity.HasOne(d => d.LandStatus)
                    .WithMany(p => p.CapitalProjects)
                    .HasForeignKey(d => d.LandStatusId)
                    .HasConstraintName("FK_CapitalProject_landStatus");

                entity.HasOne(d => d.ProjectStatus)
                    .WithMany(p => p.CapitalProjects)
                    .HasForeignKey(d => d.ProjectStatusId)
                    .HasConstraintName("FK_CapitalProjects_ProjectSatuses");

                entity.HasOne(d => d.ProjetType)
                    .WithMany(p => p.CapitalProjects)
                    .HasForeignKey(d => d.ProjetTypeId)
                    .HasConstraintName("FK_CapitalProjects_ProjectTypes");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.CapitalProjects)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_CapitalProjects_Regions");
            });

            modelBuilder.Entity<CapitalProjectAttachment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(450);
            });

            modelBuilder.Entity<CapitalProjectNote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(450);
            });

            modelBuilder.Entity<CapitalProjectsType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Logo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(350);

                entity.Property(e => e.NameArabic).HasMaxLength(350);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Sapno)
                    .HasMaxLength(50)
                    .HasColumnName("SAPNo");

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyContact>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(350);

                entity.Property(e => e.Mobile).HasMaxLength(350);

                entity.Property(e => e.Name).HasMaxLength(350);

                entity.Property(e => e.NameArabic).HasMaxLength(350);

                entity.Property(e => e.OtherTitle).HasMaxLength(350);

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.CompanyContacts)
                    .HasForeignKey(d => d.JobTitleId)
                    .HasConstraintName("FK_CompanyContacts_CompanyContacts");
            });

            modelBuilder.Entity<ContractsType>(entity =>
            {
                entity.ToTable("ContractsType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DucomentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArabiceName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArabicName).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobTitleId)
                    .HasConstraintName("FK_Employees_Employees");
            });

            modelBuilder.Entity<Ftsdrole>(entity =>
            {
                entity.ToTable("FTSDRoles");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.NameArabic).HasMaxLength(150);
            });

            modelBuilder.Entity<LandStatus>(entity =>
            {
                entity.ToTable("LandStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Logo>(entity =>
            {
                entity.HasKey(e => e.SiteNo)
                    .HasName("PK__logos__65370702");

                entity.ToTable("logos");

                entity.Property(e => e.ActiveSite).HasColumnName("Active_Site");

                entity.Property(e => e.Background).HasColumnType("image");

                entity.Property(e => e.Ebackground)
                    .HasColumnType("image")
                    .HasColumnName("EBackground");

                entity.Property(e => e.Elogo).HasColumnType("image");

                entity.Property(e => e.Ename)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Logo1)
                    .HasColumnType("image")
                    .HasColumnName("logo");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewContract>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArabicContractName).HasMaxLength(350);

                entity.Property(e => e.AwardingApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.BidEvaluationDate).HasColumnType("datetime");

                entity.Property(e => e.ContractName).HasMaxLength(350);

                entity.Property(e => e.ContractRequestDate).HasColumnType("datetime");

                entity.Property(e => e.ContractorDate).HasColumnType("datetime");

                entity.Property(e => e.JobexDate).HasColumnType("datetime");

                entity.Property(e => e.OpenBidDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.SigningDate).HasColumnType("datetime");

                entity.Property(e => e.WavierDate).HasColumnType("datetime");

                entity.HasOne(d => d.AthorityApprovalNavigation)
                    .WithMany(p => p.NewContracts)
                    .HasForeignKey(d => d.AthorityApproval)
                    .HasConstraintName("FK_NewContracts_AthorityMatrix");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.NewContracts)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_NewContracts_Companies");

                entity.HasOne(d => d.ContractType)
                    .WithMany(p => p.NewContracts)
                    .HasForeignKey(d => d.ContractTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewContracts_ContractsType");

                entity.HasOne(d => d.NewContractAction)
                    .WithMany(p => p.NewContracts)
                    .HasForeignKey(d => d.NewContractActionId)
                    .HasConstraintName("FK_NewContracts_NewContractAction");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.NewContracts)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewContracts_Regions");
            });

          

            modelBuilder.Entity<NewContractAction>(entity =>
            {
                entity.ToTable("NewContractAction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(350);

                entity.Property(e => e.Name).HasMaxLength(350);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Receiver).HasMaxLength(450);

                entity.Property(e => e.Sender).HasMaxLength(450);

                entity.Property(e => e.Title).HasMaxLength(350);

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .HasConstraintName("FK_Notifications_NotificationTypes");
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Criticality).HasMaxLength(50);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameArabic).HasMaxLength(50);
            });

            modelBuilder.Entity<OperationalContractNote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(450);
            });

            modelBuilder.Entity<OpertionalContractNote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NoteDate).HasColumnType("datetime");

                entity.HasOne(d => d.DucomentType)
                    .WithMany(p => p.OpertionalContractNotes)
                    .HasForeignKey(d => d.DucomentTypeId)
                    .HasConstraintName("FK_OpertionalContractNotes_DucomentTypes");

                entity.HasOne(d => d.OperationalContract)
                    .WithMany(p => p.OpertionalContractNotes)
                    .HasForeignKey(d => d.OperationalContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpertionalContractNotes_ActiveContract");

                entity.HasOne(d => d.OperationalContractNavigation)
                    .WithMany(p => p.OpertionalContractNotes)
                    .HasForeignKey(d => d.OperationalContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpertionalContractNotes_NewContracts");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OpertionalContractNotes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OpertionalContractNotes_Employees");
            });

            modelBuilder.Entity<ProjectDate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AwardingDate).HasColumnType("date");

                entity.Property(e => e.BiddingDate).HasColumnType("date");

                entity.Property(e => e.Closing).HasColumnType("date");

                entity.Property(e => e.CompletionDate)
                    .HasColumnType("date")
                    .HasColumnName("completionDate");

                entity.Property(e => e.DesigningDate).HasColumnType("date");

                entity.Property(e => e.PlannigDate).HasColumnType("date");

                entity.Property(e => e.RecevReq).HasColumnType("date");
            });

            modelBuilder.Entity<ProjectSatuse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<FTSD2.Models.OperationContractsActiveAddViewModel>? OperationContractsActiveAddViewModel { get; set; }

        public DbSet<FTSD2.Models.OperationContractsPreparationAddViewModel>? OperationContractsPreparationAddViewModel { get; set; }

    }
}
