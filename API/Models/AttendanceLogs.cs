using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class AttendanceLogs  
    {
        [Key]
        public int Id { get; set; }
        public int AttendanceLogId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public int EmployeeId { get; set; }
        public string InTime { get; set; }
        public string InDeviceId { get; set; }
        public string? OutTime { get; set; }
        public string OutDeviceId { get; set; }
        public float Duration { get; set; }
        public int LateBy { get; set; }
        public int EarlyBy { get; set; }
        public bool IsOnLeave { get; set; }
        public string LeaveType { get; set; }
        public float LeaveDuration { get; set; }
        public int WeeklyOff { get; set; }
        public int Holiday { get; set; }
        public string LeaveRemarks { get; set; }
        public string PunchRecords { get; set; }
        public int ShiftId { get; set; }
        public float Present { get; set; }
        public float Absent { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public string P1Status { get; set; }
        public string P2Status { get; set; }
        public string P3Status { get; set; }
        public bool IsonSpecialOff { get; set; }
        public string SpecialOffType { get; set; }
        public string SpecialOffRemark { get; set; }
        public int SpecialOffDuration { get; set; }
        public int OverTime { get; set; }
        public int OverTimeE { get; set; }
        public bool MissedOutPunch { get; set; }
        public bool MissedInPunch { get; set; }
        public string? C1 { get; set; }
        public string? C2 { get; set; }
        public string? C3 { get; set; }
        public string? C4 { get; set; }
        public string? C5 { get; set; }
        public string? C6 { get; set; }
        public string? C7 { get; set; }
        public string Remarks { get; set; }
        public int LeaveTypeId { get; set; }
        public float LossOfHours { get; set; }

    }
}
