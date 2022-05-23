using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FTSD2.Migrations
{
    public partial class FTSDContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmendmentContracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicContractName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContractTypeId = table.Column<int>(type: "int", nullable: true),
                    AthorityApproval = table.Column<int>(type: "int", nullable: true),
                    NewContractActionId = table.Column<int>(type: "int", nullable: true),
                    AmendmentRequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmendmentLetterApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SigntureDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractorSignutreDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmendmentCost = table.Column<double>(type: "float", nullable: true),
                    OptionalPeriodValue = table.Column<int>(type: "int", nullable: true),
                    AmendmentPercentage = table.Column<int>(type: "int", nullable: true),
                    ModificationDuration = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmendmentContracts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmendmentContracts");
        }
    }
}
