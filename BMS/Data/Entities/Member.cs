using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Entities;

public class Member
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public int CumulativeHour { get; set; }
    [DataType(DataType.Date)]
    public DateTime JoiningDate { get; set; }
    public ICollection<MemberDetail>? MemberDetails { get; set; }
    public ICollection<Order>? Orders { get; set; }
}