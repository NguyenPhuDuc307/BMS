using BMS.Data.Entities.System;

namespace BMS.Data.Entities;

public class Salary
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? EmployeeId { get; set; }
    public User? Employee { get; set; }
    public ICollection<SalaryDetail>? SalaryDetails { get; set; }
}