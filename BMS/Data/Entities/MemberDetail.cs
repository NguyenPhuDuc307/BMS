using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Entities;

public class MemberDetail
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public Member? Member { get; set; }

    [DataType(DataType.Date)]
    public DateTime LastOfMonth { get; set; }
    public int RemainingHour { get; set; }
}