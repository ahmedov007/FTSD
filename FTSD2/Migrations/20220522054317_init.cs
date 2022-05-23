using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FTSD2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AmedmentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmedmentTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AthorityMatrix",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AthorityMatrix", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BidsTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetPlan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    Yearbudget = table.Column<int>(type: "int", nullable: true),
                    AnualPlan = table.Column<int>(type: "int", nullable: true),
                    Spentbudget = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetPlan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BudgetYears",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearName = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BussinessUnit",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussinessUnit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CapitalProjectAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CapitalProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectSatustsIdId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalProjectAttachments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapitalProjectNotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CapitalProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NoteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true),
                    ProjectStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalProjectNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapitalProjectsTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SAPNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    NameArabic = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContractsType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractsType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DucomentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabiceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DucomentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FTSDRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FTSDRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameArabic = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LandStatus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "logos",
                columns: table => new
                {
                    SiteNo = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Ename = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    logo = table.Column<byte[]>(type: "image", nullable: true),
                    Background = table.Column<byte[]>(type: "image", nullable: true),
                    Elogo = table.Column<byte[]>(type: "image", nullable: true),
                    EBackground = table.Column<byte[]>(type: "image", nullable: true),
                    Active_Site = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__logos__65370702", x => x.SiteNo);
                });

            migrationBuilder.CreateTable(
                name: "NewContractAction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewContractAction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameArabic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Criticality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationalContractNotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ActiveContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NoteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalContractNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecevReq = table.Column<DateTime>(type: "date", nullable: true),
                    PlannigDate = table.Column<DateTime>(type: "date", nullable: true),
                    DesigningDate = table.Column<DateTime>(type: "date", nullable: true),
                    BiddingDate = table.Column<DateTime>(type: "date", nullable: true),
                    AwardingDate = table.Column<DateTime>(type: "date", nullable: true),
                    completionDate = table.Column<DateTime>(type: "date", nullable: true),
                    Closing = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContacts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    NameArabic = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    OtherTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    JobTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CompanyContacts_CompanyContacts",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    JobTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Employees",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    NotificationContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Sender = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Receiver = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationTypes",
                        column: x => x.NotificationTypeId,
                        principalTable: "NotificationTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActiveContract",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaasicDuration = table.Column<int>(type: "int", nullable: true),
                    OptionalDuration = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDat = table.Column<DateTime>(type: "datetime", nullable: true),
                    BasicPeriodValue = table.Column<double>(type: "float", nullable: true),
                    OptionalPeriodValue = table.Column<double>(type: "float", nullable: true),
                    LumpSum = table.Column<double>(type: "float", nullable: true),
                    Uitrate = table.Column<double>(type: "float", nullable: true),
                    OptionalValue = table.Column<double>(type: "float", nullable: true),
                    CotractTotal = table.Column<double>(type: "float", nullable: true),
                    ContractTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveContract", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ActiveContract_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ActiveContract_ContractsType",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractsType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ActiveContract_Regions",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CapitalProjects",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContractNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BudgetYearId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    LandStatusId = table.Column<int>(type: "int", nullable: true),
                    BussinessUnitId = table.Column<int>(type: "int", nullable: true),
                    ProjetTypeId = table.Column<int>(type: "int", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    ArabicProjectName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    ProjectStatusId = table.Column<int>(type: "int", nullable: true),
                    PlanPercentage = table.Column<int>(type: "int", nullable: true),
                    ActualPercentage = table.Column<int>(type: "int", nullable: true),
                    ProjectDatesId = table.Column<int>(type: "int", nullable: true),
                    EstimatBudget = table.Column<int>(type: "int", nullable: true),
                    ContractCost = table.Column<int>(type: "int", nullable: true),
                    BudgetSpent = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalProjects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CapitalProject_BudgetYears",
                        column: x => x.BudgetYearId,
                        principalTable: "BudgetYears",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CapitalProject_BussinessUnit",
                        column: x => x.BussinessUnitId,
                        principalTable: "BussinessUnit",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CapitalProject_Cities",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CapitalProject_landStatus",
                        column: x => x.LandStatusId,
                        principalTable: "LandStatus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CapitalProjects_ProjectSatuses",
                        column: x => x.ProjectStatusId,
                        principalTable: "ProjectSatuses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CapitalProjects_ProjectTypes",
                        column: x => x.ProjetTypeId,
                        principalTable: "ProjectTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CapitalProjects_Regions",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "NewContracts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ArabicContractName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    ContractTypeId = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    WavierDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContractRequestDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    JobexDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OpenBidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    BidEvaluationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AwardingApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AthorityApproval = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SigningDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContractorDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NewContractActionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewContracts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NewContracts_AthorityMatrix",
                        column: x => x.AthorityApproval,
                        principalTable: "AthorityMatrix",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NewContracts_Companies",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NewContracts_ContractsType",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractsType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NewContracts_NewContractAction",
                        column: x => x.NewContractActionId,
                        principalTable: "NewContractAction",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NewContracts_Regions",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OpertionalContractNotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OperationalContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NoDelete = table.Column<bool>(type: "bit", nullable: true),
                    DucomentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpertionalContractNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpertionalContractNotes_ActiveContract",
                        column: x => x.OperationalContractId,
                        principalTable: "ActiveContract",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OpertionalContractNotes_DucomentTypes",
                        column: x => x.DucomentTypeId,
                        principalTable: "DucomentTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpertionalContractNotes_Employees",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpertionalContractNotes_NewContracts",
                        column: x => x.OperationalContractId,
                        principalTable: "NewContracts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveContract_CompanyID",
                table: "ActiveContract",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_ActiveContract_ContractTypeId",
                table: "ActiveContract",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ActiveContract_RegionId",
                table: "ActiveContract",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_BudgetYearId",
                table: "CapitalProjects",
                column: "BudgetYearId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_BussinessUnitId",
                table: "CapitalProjects",
                column: "BussinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_CityId",
                table: "CapitalProjects",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_LandStatusId",
                table: "CapitalProjects",
                column: "LandStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_ProjectStatusId",
                table: "CapitalProjects",
                column: "ProjectStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_ProjetTypeId",
                table: "CapitalProjects",
                column: "ProjetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CapitalProjects_RegionId",
                table: "CapitalProjects",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContacts_JobTitleId",
                table: "CompanyContacts",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employees",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_NewContracts_AthorityApproval",
                table: "NewContracts",
                column: "AthorityApproval");

            migrationBuilder.CreateIndex(
                name: "IX_NewContracts_CompanyId",
                table: "NewContracts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_NewContracts_ContractTypeId",
                table: "NewContracts",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NewContracts_NewContractActionId",
                table: "NewContracts",
                column: "NewContractActionId");

            migrationBuilder.CreateIndex(
                name: "IX_NewContracts_RegionId",
                table: "NewContracts",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationTypeId",
                table: "Notifications",
                column: "NotificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OpertionalContractNotes_DucomentTypeId",
                table: "OpertionalContractNotes",
                column: "DucomentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OpertionalContractNotes_OperationalContractId",
                table: "OpertionalContractNotes",
                column: "OperationalContractId");

            migrationBuilder.CreateIndex(
                name: "IX_OpertionalContractNotes_UserId",
                table: "OpertionalContractNotes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionTypes");

            migrationBuilder.DropTable(
                name: "AmedmentTypes");

            migrationBuilder.DropTable(
                name: "BidsTypes");

            migrationBuilder.DropTable(
                name: "BudgetPlan");

            migrationBuilder.DropTable(
                name: "CapitalProjectAttachments");

            migrationBuilder.DropTable(
                name: "CapitalProjectNotes");

            migrationBuilder.DropTable(
                name: "CapitalProjects");

            migrationBuilder.DropTable(
                name: "CapitalProjectsTypes");

            migrationBuilder.DropTable(
                name: "CompanyContacts");

            migrationBuilder.DropTable(
                name: "FTSDRoles");

            migrationBuilder.DropTable(
                name: "logos");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OperationalContractNotes");

            migrationBuilder.DropTable(
                name: "OpertionalContractNotes");

            migrationBuilder.DropTable(
                name: "ProjectDates");

            migrationBuilder.DropTable(
                name: "BudgetYears");

            migrationBuilder.DropTable(
                name: "BussinessUnit");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "LandStatus");

            migrationBuilder.DropTable(
                name: "ProjectSatuses");

            migrationBuilder.DropTable(
                name: "ProjectTypes");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "ActiveContract");

            migrationBuilder.DropTable(
                name: "DucomentTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "NewContracts");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "AthorityMatrix");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ContractsType");

            migrationBuilder.DropTable(
                name: "NewContractAction");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
