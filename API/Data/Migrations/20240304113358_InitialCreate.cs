using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceLogId = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    InTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InDeviceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutDeviceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<float>(type: "real", nullable: false),
                    LateBy = table.Column<int>(type: "int", nullable: false),
                    EarlyBy = table.Column<int>(type: "int", nullable: false),
                    IsOnLeave = table.Column<bool>(type: "bit", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveDuration = table.Column<float>(type: "real", nullable: false),
                    WeeklyOff = table.Column<int>(type: "int", nullable: false),
                    Holiday = table.Column<int>(type: "int", nullable: false),
                    LeaveRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PunchRecords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    Present = table.Column<float>(type: "real", nullable: false),
                    Absent = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P1Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P2Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P3Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsonSpecialOff = table.Column<bool>(type: "bit", nullable: false),
                    SpecialOffType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialOffRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialOffDuration = table.Column<int>(type: "int", nullable: false),
                    OverTime = table.Column<int>(type: "int", nullable: false),
                    OverTimeE = table.Column<int>(type: "int", nullable: false),
                    MissedOutPunch = table.Column<bool>(type: "bit", nullable: false),
                    MissedInPunch = table.Column<bool>(type: "bit", nullable: false),
                    C1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    LossOfHours = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StringCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumericCode = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DOJ = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeCodeInDevice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeRFIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployementType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDevicePassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDeviceGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidentialAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nomenee1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nomenee2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: true),
                    C1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtensionNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRecieveNotification = table.Column<bool>(type: "bit", nullable: true),
                    HolidayGroup = table.Column<float>(type: "real", nullable: true),
                    ShiftGroupId = table.Column<float>(type: "real", nullable: true),
                    ShiftRosterId = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AadhaarNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MasterDeviceId = table.Column<int>(type: "int", nullable: true),
                    BIOPhoto1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BIOPhotoPic = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DeviceExpiryRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceExpiryStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeviceExpiryEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeviceId = table.Column<float>(type: "real", nullable: true),
                    EnrolledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MigrateToOtherCryptography = table.Column<float>(type: "real", nullable: true),
                    GeofenceId = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceLogs");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
