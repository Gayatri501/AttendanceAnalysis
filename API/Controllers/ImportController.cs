using API.Data;
using API.Models;
using CsvHelper;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.OleDb;
using System.Globalization;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        private readonly DatabaseContext _dbContext;

        public ImportController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult ImportData()
        {
            try
            {
                string accessConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gayatri Khairnar\\Downloads\\eTimeTrackLite1\\eTimeTrackLite1.mdb";


                using (OleDbConnection accessConnection = new OleDbConnection(accessConnectionString))
                {
                    accessConnection.Open();

                    // Import AttendaceLog data
                    var attendanceLogs = accessConnection.Query<AttendanceLogs>("SELECT * FROM AttendanceLogs").ToList();
                    _dbContext.AttendanceLogs.AddRange(attendanceLogs);

                    // Import Employee data
                    var employees = accessConnection.Query<Employees>("SELECT * FROM Employees").ToList();
                    _dbContext.Employees.AddRange(employees);

                    _dbContext.SaveChanges();
                }

                return Ok("Data imported successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error importing data: {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult ExportDataToCsv()
        {
            var attendanceLogs = _dbContext.AttendanceLogs.ToList();
            var employees = _dbContext.Employees.ToList();

            var records = attendanceLogs.Select(log =>
            {
                var employee = employees.FirstOrDefault(e => e.EmployeeId == log.EmployeeId);
                return new
                {
                    
                    log.AttendanceDate,
                    log.EmployeeId,
                    employee?.EmployeeCode,
                    EmployeeName = employee?.EmployeeName,
                    log.InTime,
                    log.InDeviceId,
                    log.OutTime,
                    log.OutDeviceId,
                    log.Duration,
                    log.LateBy,
                    log.EarlyBy,
                    log.IsOnLeave,
                    log.LeaveType,
                    log.LeaveDuration,
                    log.OverTime,
                    log.Present,
                    log.Absent,
                    log.Status,
                    log.StatusCode,    
                    employee?.Designation,
                    employee?.EmployementType,
                    employee?.Gender,
                    employee?.CompanyId,
                    employee?.DepartmentId,
                    employee?.CategoryId
                };
            });

            using (var writer = new StreamWriter("attendance_data.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }

            return Ok("Data exported to CSV successfully.");
        }

    }
}

