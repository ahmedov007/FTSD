IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [ActionTypes] (
    [ID] int NOT NULL,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_ActionTypes] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [AmedmentTypes] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_AmedmentTypes] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [AthorityMatrix] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(350) NOT NULL,
    [ArabicName] nvarchar(350) NULL,
    [IsActive] bit NULL,
    [IsDelete] bit NULL,
    CONSTRAINT [PK_AthorityMatrix] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [BidsTypes] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [IsDelete] bit NULL,
    CONSTRAINT [PK_BidsTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [BudgetPlan] (
    [ID] int NOT NULL IDENTITY,
    [ProjectID] int NULL,
    [Yearbudget] int NULL,
    [AnualPlan] int NULL,
    [Spentbudget] int NULL,
    CONSTRAINT [PK_BudgetPlan] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [BudgetYears] (
    [Id] uniqueidentifier NOT NULL,
    [YearName] int NULL,
    CONSTRAINT [PK_BudgetYears] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [BussinessUnit] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_BussinessUnit] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [CapitalProjectAttachments] (
    [Id] uniqueidentifier NOT NULL,
    [Notes] nvarchar(max) NULL,
    [NoteDate] datetime NULL,
    [UserId] nvarchar(450) NULL,
    [CapitalProjectId] uniqueidentifier NULL,
    [ProjectSatustsIdId] uniqueidentifier NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_CapitalProjectAttachments] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [CapitalProjectNotes] (
    [Id] uniqueidentifier NOT NULL,
    [Notes] nvarchar(max) NULL,
    [UserId] nvarchar(450) NULL,
    [CapitalProjectId] uniqueidentifier NULL,
    [NoteDate] datetime NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    [ProjectStatusId] uniqueidentifier NULL,
    CONSTRAINT [PK_CapitalProjectNotes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [CapitalProjectsTypes] (
    [ID] int NOT NULL,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL
);
GO

CREATE TABLE [Cities] (
    [ID] int NOT NULL IDENTITY,
    [RegionId] int NOT NULL,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_Cities] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [Companies] (
    [ID] uniqueidentifier NOT NULL,
    [SAPNo] nvarchar(50) NULL,
    [Name] nvarchar(350) NULL,
    [NameArabic] nvarchar(350) NULL,
    [CityId] int NULL,
    [Logo] nvarchar(50) NULL,
    [Phone] nvarchar(50) NULL,
    [SubmissionDate] datetime NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [ContractsType] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_ContractsType] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [DucomentTypes] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NULL,
    [ArabiceName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [IsDelete] bit NULL,
    CONSTRAINT [PK_DucomentTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [FTSDRoles] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(150) NULL,
    [ArabicName] nvarchar(150) NULL,
    [IsActive] bit NULL,
    [IsDelete] bit NULL,
    CONSTRAINT [PK_FTSDRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [JobTitles] (
    [ID] uniqueidentifier NOT NULL,
    [Name] nvarchar(150) NULL,
    [NameArabic] nvarchar(150) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_JobTitles] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [LandStatus] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_LandStatus] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [logos] (
    [SiteNo] float NOT NULL,
    [Name] varchar(255) NULL,
    [Ename] varchar(255) NULL,
    [logo] image NULL,
    [Background] image NULL,
    [Elogo] image NULL,
    [EBackground] image NULL,
    [Active_Site] bit NOT NULL,
    CONSTRAINT [PK__logos__65370702] PRIMARY KEY ([SiteNo])
);
GO

CREATE TABLE [NewContractAction] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(350) NULL,
    [ArabicName] nvarchar(350) NULL,
    [IsActive] bit NULL,
    [IsDelete] bit NULL,
    CONSTRAINT [PK_NewContractAction] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [NotificationTypes] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NULL,
    [NameArabic] nvarchar(50) NULL,
    [Criticality] nvarchar(50) NULL,
    [Icon] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_NotificationTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [OperationalContractNotes] (
    [Id] uniqueidentifier NOT NULL,
    [Notes] nvarchar(max) NULL,
    [UserId] nvarchar(450) NULL,
    [ActiveContractId] uniqueidentifier NULL,
    [NoteDate] datetime NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_OperationalContractNotes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProjectDates] (
    [ID] int NOT NULL IDENTITY,
    [RecevReq] date NULL,
    [PlannigDate] date NULL,
    [DesigningDate] date NULL,
    [BiddingDate] date NULL,
    [AwardingDate] date NULL,
    [completionDate] date NULL,
    [Closing] date NULL,
    CONSTRAINT [PK_ProjectDates] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [ProjectSatuses] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_ProjectSatuses] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [ProjectTypes] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_ProjectTypes] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [Regions] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [ArabicName] nvarchar(50) NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_Regions] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [CompanyContacts] (
    [ID] uniqueidentifier NOT NULL,
    [Name] nvarchar(350) NULL,
    [NameArabic] nvarchar(350) NULL,
    [CompanyId] uniqueidentifier NULL,
    [Email] nvarchar(350) NULL,
    [Mobile] nvarchar(350) NULL,
    [OtherTitle] nvarchar(350) NULL,
    [JobTitleId] uniqueidentifier NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_CompanyContacts] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_CompanyContacts_CompanyContacts] FOREIGN KEY ([JobTitleId]) REFERENCES [JobTitles] ([ID])
);
GO

CREATE TABLE [Employees] (
    [Id] uniqueidentifier NOT NULL,
    [Username] nvarchar(100) NULL,
    [Name] nvarchar(100) NULL,
    [ArabicName] nvarchar(100) NULL,
    [email] nvarchar(100) NULL,
    [JobTitleId] uniqueidentifier NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Employees_Employees] FOREIGN KEY ([JobTitleId]) REFERENCES [JobTitles] ([ID])
);
GO

CREATE TABLE [Notifications] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(350) NULL,
    [NotificationContent] nvarchar(max) NULL,
    [NotificationTypeId] uniqueidentifier NULL,
    [Sender] nvarchar(450) NULL,
    [Receiver] nvarchar(450) NULL,
    [Date] datetime NULL,
    [Url] nvarchar(max) NULL,
    [IsRead] bit NULL,
    [IsDeleted] bit NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    CONSTRAINT [PK_Notifications] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Notifications_NotificationTypes] FOREIGN KEY ([NotificationTypeId]) REFERENCES [NotificationTypes] ([Id])
);
GO

CREATE TABLE [ActiveContract] (
    [ID] uniqueidentifier NOT NULL,
    [ContractNo] nvarchar(15) NULL,
    [Name] nvarchar(350) NULL,
    [ArabicName] nvarchar(350) NULL,
    [RegionId] int NULL,
    [CompanyID] uniqueidentifier NULL,
    [BaasicDuration] int NULL,
    [OptionalDuration] int NULL,
    [StartDate] datetime NULL,
    [EndDat] datetime NULL,
    [BasicPeriodValue] float NULL,
    [OptionalPeriodValue] float NULL,
    [LumpSum] float NULL,
    [Uitrate] float NULL,
    [OptionalValue] float NULL,
    [CotractTotal] float NULL,
    [ContractTypeId] int NULL,
    CONSTRAINT [PK_ActiveContract] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_ActiveContract_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [Companies] ([ID]),
    CONSTRAINT [FK_ActiveContract_ContractsType] FOREIGN KEY ([ContractTypeId]) REFERENCES [ContractsType] ([ID]),
    CONSTRAINT [FK_ActiveContract_Regions] FOREIGN KEY ([RegionId]) REFERENCES [Regions] ([ID])
);
GO

CREATE TABLE [CapitalProjects] (
    [ID] uniqueidentifier NOT NULL,
    [ProjectNo] nvarchar(100) NULL,
    [ContractNo] nvarchar(100) NULL,
    [BudgetYearId] uniqueidentifier NULL,
    [RegionId] int NULL,
    [CityId] int NULL,
    [LandStatusId] int NULL,
    [BussinessUnitId] int NULL,
    [ProjetTypeId] int NULL,
    [ProjectName] nvarchar(350) NULL,
    [ArabicProjectName] nvarchar(350) NULL,
    [ProjectStatusId] int NULL,
    [PlanPercentage] int NULL,
    [ActualPercentage] int NULL,
    [ProjectDatesId] int NULL,
    [EstimatBudget] int NULL,
    [ContractCost] int NULL,
    [BudgetSpent] int NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_CapitalProjects] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_CapitalProject_BudgetYears] FOREIGN KEY ([BudgetYearId]) REFERENCES [BudgetYears] ([Id]),
    CONSTRAINT [FK_CapitalProject_BussinessUnit] FOREIGN KEY ([BussinessUnitId]) REFERENCES [BussinessUnit] ([ID]),
    CONSTRAINT [FK_CapitalProject_Cities] FOREIGN KEY ([CityId]) REFERENCES [Cities] ([ID]),
    CONSTRAINT [FK_CapitalProject_landStatus] FOREIGN KEY ([LandStatusId]) REFERENCES [LandStatus] ([ID]),
    CONSTRAINT [FK_CapitalProjects_ProjectSatuses] FOREIGN KEY ([ProjectStatusId]) REFERENCES [ProjectSatuses] ([ID]),
    CONSTRAINT [FK_CapitalProjects_ProjectTypes] FOREIGN KEY ([ProjetTypeId]) REFERENCES [ProjectTypes] ([ID]),
    CONSTRAINT [FK_CapitalProjects_Regions] FOREIGN KEY ([RegionId]) REFERENCES [Regions] ([ID])
);
GO

CREATE TABLE [NewContracts] (
    [ID] uniqueidentifier NOT NULL,
    [ContractName] nvarchar(350) NOT NULL,
    [ArabicContractName] nvarchar(350) NULL,
    [RegionId] int NOT NULL,
    [ContractTypeId] int NOT NULL,
    [RequestDate] datetime NOT NULL,
    [WavierDate] datetime NULL,
    [ContractRequestDate] datetime NULL,
    [JobexDate] datetime NULL,
    [OpenBidDate] datetime NULL,
    [BidEvaluationDate] datetime NULL,
    [AwardingApprovalDate] datetime NULL,
    [AthorityApproval] int NULL,
    [CompanyId] uniqueidentifier NULL,
    [SigningDate] datetime NULL,
    [ContractorDate] datetime NULL,
    [NewContractActionId] int NULL,
    CONSTRAINT [PK_NewContracts] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_NewContracts_AthorityMatrix] FOREIGN KEY ([AthorityApproval]) REFERENCES [AthorityMatrix] ([ID]),
    CONSTRAINT [FK_NewContracts_Companies] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([ID]),
    CONSTRAINT [FK_NewContracts_ContractsType] FOREIGN KEY ([ContractTypeId]) REFERENCES [ContractsType] ([ID]),
    CONSTRAINT [FK_NewContracts_NewContractAction] FOREIGN KEY ([NewContractActionId]) REFERENCES [NewContractAction] ([ID]),
    CONSTRAINT [FK_NewContracts_Regions] FOREIGN KEY ([RegionId]) REFERENCES [Regions] ([ID])
);
GO

CREATE TABLE [OpertionalContractNotes] (
    [Id] uniqueidentifier NOT NULL,
    [Notes] nvarchar(max) NULL,
    [NoteDate] datetime NULL,
    [UserId] uniqueidentifier NULL,
    [OperationalContractId] uniqueidentifier NOT NULL,
    [IsActive] bit NULL,
    [NoDelete] bit NULL,
    [DucomentTypeId] uniqueidentifier NULL,
    CONSTRAINT [PK_OpertionalContractNotes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_OpertionalContractNotes_ActiveContract] FOREIGN KEY ([OperationalContractId]) REFERENCES [ActiveContract] ([ID]),
    CONSTRAINT [FK_OpertionalContractNotes_DucomentTypes] FOREIGN KEY ([DucomentTypeId]) REFERENCES [DucomentTypes] ([Id]),
    CONSTRAINT [FK_OpertionalContractNotes_Employees] FOREIGN KEY ([UserId]) REFERENCES [Employees] ([Id]),
    CONSTRAINT [FK_OpertionalContractNotes_NewContracts] FOREIGN KEY ([OperationalContractId]) REFERENCES [NewContracts] ([ID])
);
GO

CREATE INDEX [IX_ActiveContract_CompanyID] ON [ActiveContract] ([CompanyID]);
GO

CREATE INDEX [IX_ActiveContract_ContractTypeId] ON [ActiveContract] ([ContractTypeId]);
GO

CREATE INDEX [IX_ActiveContract_RegionId] ON [ActiveContract] ([RegionId]);
GO

CREATE INDEX [IX_CapitalProjects_BudgetYearId] ON [CapitalProjects] ([BudgetYearId]);
GO

CREATE INDEX [IX_CapitalProjects_BussinessUnitId] ON [CapitalProjects] ([BussinessUnitId]);
GO

CREATE INDEX [IX_CapitalProjects_CityId] ON [CapitalProjects] ([CityId]);
GO

CREATE INDEX [IX_CapitalProjects_LandStatusId] ON [CapitalProjects] ([LandStatusId]);
GO

CREATE INDEX [IX_CapitalProjects_ProjectStatusId] ON [CapitalProjects] ([ProjectStatusId]);
GO

CREATE INDEX [IX_CapitalProjects_ProjetTypeId] ON [CapitalProjects] ([ProjetTypeId]);
GO

CREATE INDEX [IX_CapitalProjects_RegionId] ON [CapitalProjects] ([RegionId]);
GO

CREATE INDEX [IX_CompanyContacts_JobTitleId] ON [CompanyContacts] ([JobTitleId]);
GO

CREATE INDEX [IX_Employees_JobTitleId] ON [Employees] ([JobTitleId]);
GO

CREATE INDEX [IX_NewContracts_AthorityApproval] ON [NewContracts] ([AthorityApproval]);
GO

CREATE INDEX [IX_NewContracts_CompanyId] ON [NewContracts] ([CompanyId]);
GO

CREATE INDEX [IX_NewContracts_ContractTypeId] ON [NewContracts] ([ContractTypeId]);
GO

CREATE INDEX [IX_NewContracts_NewContractActionId] ON [NewContracts] ([NewContractActionId]);
GO

CREATE INDEX [IX_NewContracts_RegionId] ON [NewContracts] ([RegionId]);
GO

CREATE INDEX [IX_Notifications_NotificationTypeId] ON [Notifications] ([NotificationTypeId]);
GO

CREATE INDEX [IX_OpertionalContractNotes_DucomentTypeId] ON [OpertionalContractNotes] ([DucomentTypeId]);
GO

CREATE INDEX [IX_OpertionalContractNotes_OperationalContractId] ON [OpertionalContractNotes] ([OperationalContractId]);
GO

CREATE INDEX [IX_OpertionalContractNotes_UserId] ON [OpertionalContractNotes] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220522054317_init', N'6.0.5');
GO

COMMIT;
GO

