using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BMS.Data.Enums;
using BMS.Data.Interfaces;

namespace BMS.Data.Entities;

public class SalaryDetail : IDateTracking
{
    public int Id { get; set; }
    public int SalaryId { get; set; }
    public Salary? Salary { get; set; }
    [DataType(DataType.Date)]
    public DateTime LastOfMonth { get; set; }
    public int TotalHour { get; set; }
    [Column(TypeName = "decimal(18,0)")]
    public double SalaryAmount { get; set; }
    public SalaryStatus SalaryStatus { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}