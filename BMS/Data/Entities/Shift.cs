using BMS.Data.Entities.System;
using BMS.Data.Enums;
using BMS.Data.Interfaces;

namespace BMS.Data.Entities;

public class Shift : IDateTracking
{
    public int Id { get; set; }
    public int BranchId { get; set; }
    public Branch? Branch { get; set; }
    public string? EmployeeId { get; set; }
    public User? Employee { get; set; }
    public int StartTime { get; set; }
    public int EndTime { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public ShiftConfirm ShiftConfirm { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}