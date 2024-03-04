using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Employees  
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public string? StringCode { get; set; }
        public int? NumericCode { get; set; }
        public string? Gender { get; set; }
        public int? CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public string? Designation { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? DOJ { get; set; }
        public DateTime? DOR { get; set; }
        public DateTime? DOC { get; set; }
        public string? EmployeeCodeInDevice { get; set; }
        public string? EmployeeRFIDNumber { get; set; }
        public string? EmployementType { get; set; }
        public string? Status { get; set; }
        public string? EmployeeDevicePassword { get; set; }
        public string? EmployeeDeviceGroup { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? ResidentialAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public DateTime? DOB { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Nomenee1 { get; set; }
        public string? Nomenee2 { get; set; }
        public string? Remarks { get; set; }
        public int? RecordStatus { get; set; }
        public string? C1 { get; set; }
        public string? C2 { get; set; }
        public string? C3 { get; set; }
        public string? C4 { get; set; }
        public string? C5 { get; set; }
        public string? C6 { get; set; }
        public string? C7 { get; set; }
        public string? Location { get; set; }
        public string? BloodGroup { get; set; }
        public string? WorkPlace { get; set; }
        public string? ExtensionNo { get; set; }
        public string? LoginName { get; set; }
        public string? LoginPassword { get; set; }
        public string? Grade { get; set; }
        public string? Team { get; set; }
        public bool? IsRecieveNotification { get; set; }
        public float? HolidayGroup { get; set; }
        public float? ShiftGroupId { get; set; }
        public int? ShiftRosterId { get; set; }
        public string? LastModifiedBy { get; set; }
        public string? AadhaarNumber { get; set; }
        public byte[]? EmployeePhoto { get; set; }
        public int? MasterDeviceId { get; set; }
        public byte[]? BIOPhoto1 { get; set; }
        public byte[]? BIOPhotoPic { get; set; }
        public string? DeviceExpiryRule { get; set; }

        public DateTime? DeviceExpiryStartDate { get; set; }
        public DateTime? DeviceExpiryEndDate { get; set; }
        public float? DeviceId { get; set; }
        public DateTime? EnrolledDate { get; set; }
        public float? MigrateToOtherCryptography { get; set; }
        public float? GeofenceId { get; set; }
    }
}
